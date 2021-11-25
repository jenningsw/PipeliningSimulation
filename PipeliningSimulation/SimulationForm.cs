using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeliningSimulation {
    public partial class SimulationForm : Form {

        public List<string> Instructions { get; set; } = new List<string>();                        //List of instructions as string
        public List<Instruction> InstructionListReduced { get; set; } = new List<Instruction>();    //All instructions and labels from the trace file in order
        public List<Instruction> InstructionList { get; set; } = new List<Instruction>();           //All instructions to be run (with branches expanded)
        public List<Instruction> LabelList { get; set; } = new List<Instruction>();                 //All labels from the trace file in order
        CPU cpu; 
        private int latFPAdd = 2;
        private int latFPSub = 2;
        private int latFPMul = 5;
        private int latFPDiv = 10;

        public SimulationForm() {
            InitializeComponent();
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            configListBox.Items.Clear();
            string[] defaultConfigText = { "Latencies: T", "FP Add: 2", "FP Sub: 2", "FP Mul: 5", "FP Div: 10" };
            configListBox.Items.AddRange(defaultConfigText);

            delaysListBox.Items.Clear();
            string[] defaultDelaysText = { "True dependence delays: " };

            delaysListBox.Items.AddRange(defaultDelaysText);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configButtion_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ConfigurationForm(this);
            this.Enabled = false;
            configForm.ShowDialog();
            latFPAdd = configForm.latFPAdd;
            latFPSub = configForm.latFPSub;
            latFPMul = configForm.latFPMul;
            latFPDiv = configForm.latFPDiv;
        }

        private void stepButton_Click(object sender, EventArgs e)
        {

            if (InstructionList.Count > 0) {
                cpu.Step();

                lblCycleCount.Text = "Current Cycle: " + (cpu.cycle - 1); 
                cycleCountLabel.Text = ""+(cpu.cycle - 1);

                ClearPipelineInfo();

                foreach (Instruction i in cpu.instructions) {
                    issuesListBox.Items.Add(i.Results[0]);
                    execListBox.Items.Add(i.Results[1]);
                    readListBox.Items.Add(i.Results[2]);
                    writeListBox.Items.Add(i.Results[3]);
                    commitsListBox.Items.Add(i.Results[4]);
                }

                string[] delays = { "True dependence delays: "  + cpu.trueDependenceDelays};
                delaysListBox.Items.Clear();
                delaysListBox.Items.AddRange(delays);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog traceFile = new OpenFileDialog();
            traceFile.InitialDirectory = "..\\..\\Trace Files";

            if (traceFile.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = traceFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream, System.Text.Encoding.Default))
                {
                    string line = reader.ReadLine(), input = line;
                    while((line = reader.ReadLine()) != null)
                        input += "|" + line;

                    Instructions = input.Split("|".ToCharArray()).ToList();
                }

                //Reload the reduced instruction list to accomodate changes
                //NOTE: the reduced instruction list is an instruction-translated copy of the trace file
                InstructionListReduced.Clear();
                //int instructionNumber = 1;  //Int to track instruction order
                for(int currentInstrNum = 0; currentInstrNum < Instructions.Count; currentInstrNum++)
                {
                    Instruction newInstr = new Instruction(Instructions[currentInstrNum]);
                    newInstr.InstructionNumber = currentInstrNum;
                    InstructionListReduced.Add(newInstr);
                }


                //Reload the instruction list to accomodate changes
                InstructionList.Clear();
                for(int currentInstrNum = 0; currentInstrNum < Instructions.Count; currentInstrNum += 0) //For each string from the trace file
                {
                    Instruction newInstruction = new Instruction(Instructions[currentInstrNum]);

                    //Turn the string into an instruction and add it to the list if it isn't a label
                    if (newInstruction.Type != "LABEL")
                        currentInstrNum = AddInstruction(currentInstrNum);
                    else
                        currentInstrNum += 1;
                }


                instructsListBox.Items.Clear();
                foreach (Instruction instr in InstructionList)
                    instructsListBox.Items.Add(instr.InstructionString);

                cpu = new CPU(InstructionList);
            }
        }

        /// <summary>
        /// Method to add an instruction to the expanded instruction list
        /// </summary>
        /// <param name="instrNum">The number of the instruction in the reduced instruction list</param>
        /// <returns>The new current instruction pointer</returns>
        private int AddInstruction(int instrNum)
        {
            //Default new instruction position is one instruction after the current one
            int newInstrPosition = instrNum+1;

            //Add the instruction to the expanded list
            Instruction newInstruction = new Instruction(Instructions[instrNum], latFPAdd, latFPSub, latFPMul, latFPDiv);
            newInstruction.InstructionNumber = instrNum;
            newInstruction.LoopCount = InstructionListReduced[instrNum].LoopCount;
            if (newInstruction.Type != "LABEL")
                InstructionList.Add(newInstruction);

            //If new instruction was a branch, run branch operation
            if (newInstruction.Type == "BRANCH")
            {
                InstructionListReduced[instrNum].LoopCount -= 1;    //Reduce remaining loops for the branch instruction
                InstructionList.Last().InstructionString = InstructionList.Last().CreateBranchString(); //Regenerate the instruction string
                if (InstructionList.Last().LoopCount <= 0)  //If the loop count is at or below 0, set to 0 and regenerate the instruction string again
                {
                    InstructionList.Last().LoopCount = 0;
                    InstructionList.Last().InstructionString = InstructionList.Last().CreateBranchString();
                }
                //Branch can still loop, run AddBranch method
                else
                    newInstrPosition = AddBranch(instrNum);
            }

            return newInstrPosition;
        }


        /// <summary>
        /// Method to handle adding branches to the expanded instruction list
        /// </summary>
        /// <param name="instrNum">The number of the instruction in the reduced instruction list</param>
        /// <returns>The new current instruction pointer</returns>
        private int AddBranch(int instrNum)
        {
            //Keep track of the current position in the branch
            int branchPosition = InstructionListReduced.FindIndex(i => i.InstructionName == InstructionList.Last().Destination);
            if (branchPosition == -1)
                return Int32.MaxValue;  //Something went wrong; Abort

            //Set currentPosition to the most recently added instruction
            int currentPosition = InstructionList.Last().InstructionNumber;

            //If the branch goes backward and is taken, add the re-run instructions to the instruction list
            //If the branch goes forward and is taken, skip unrun instructions
            if (branchPosition > currentPosition && InstructionList.Last().LoopCount > 0)
            {
                //Set the next instruction to the label being branched to
                return InstructionListReduced.FindIndex(i => i.InstructionName == InstructionList.Last().Destination);
            }
            else if (branchPosition < currentPosition && InstructionList.Last().LoopCount > 0)
            {
                //Point branchPosition to the first instruction after the label
                branchPosition += 1;

                //Return the new instruction position
                return branchPosition;
            }

            return instrNum+1;  //If no branches are followed, just proceed to the next instruction
        }

        private void runButton_Click(object sender, EventArgs e) {
            if (InstructionList.Count > 0) {
                ClearPipelineInfo();
                cpu.RunToEnd();
                foreach (Instruction i in cpu.instructions) {
                    issuesListBox.Items.Add(i.Results[0]);
                    execListBox.Items.Add(i.Results[1]);
                    readListBox.Items.Add(i.Results[2]);
                    writeListBox.Items.Add(i.Results[3]);
                    commitsListBox.Items.Add(i.Results[4]);
                }


                lblCycleCount.Text = "Current Cycle: " + (cpu.cycle - 1);
                cycleCountLabel.Text = "" + (cpu.cycle - 1);

                string[] delays = { "True dependence delays: "  + cpu.trueDependenceDelays};
                delaysListBox.Items.Clear();
                delaysListBox.Items.AddRange(delays);

            }
        }

        private void ClearPipelineInfo() {
            issuesListBox.Items.Clear();
            execListBox.Items.Clear();
            readListBox.Items.Clear();
            writeListBox.Items.Clear();
            commitsListBox.Items.Clear();
        }

        private void referencePageButton_Click(object sender, EventArgs e)
        {
            InstructionReferenceForm refform = new InstructionReferenceForm();
            refform.Show();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            //configListBox.Items.Clear();
            //configListBox.ResetText();

            cycleCountLabel.ResetText();
            cycleCountLabel.Text = "0";

            //delaysListBox.Items.Clear();
            //delaysListBox.ResetText();

            instructsListBox.Items.Clear();
            instructsListBox.ResetText();

            issuesListBox.Items.Clear();
            issuesListBox.ResetText();

            execListBox.Items.Clear();
            execListBox.ResetText();

            readListBox.Items.Clear();
            readListBox.ResetText();

            writeListBox.Items.Clear();
            writeListBox.ResetText();

            commitsListBox.Items.Clear();
            commitsListBox.ResetText();

            InstructionList.Clear();

            SetDefaults();

            lblCycleCount.Text = "Current Cycle:";
            cpu = null;  

        }

        private void btnRunWithoutPipeline_Click(object sender, EventArgs e) {
            NonPipelinedCPU npCPU = new NonPipelinedCPU(InstructionList);
            NonPipelined np = new NonPipelined(npCPU);
            np.ShowDialog();

        }
    }
}


