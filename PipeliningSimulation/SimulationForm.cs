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
            string[] defaultConfigText = { "Buffers: T", "Eff Addr: 2", "FP Adds: 3", "FP Muls: 3", "Ints: 3", "Reorder: 5", 
                "Latencies: T", "FP Add: 2", "FP Sub: 2", "FP Mul: 5", "FP Div: 10" };
            configListBox.Items.AddRange(defaultConfigText);

            delaysListBox.Items.Clear();
            string[] defaultDelaysText = { "Reorder buffer delays: ", "Reservation station delays", "Data memory conflict delays: ", "True dependence delays: " };
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

                string[] delays = { "Reorder buffer delays: ", "Reservation station delays",
                    "Data memory conflict delays: ", "True dependence delays: "  + cpu.trueDependenceDelays};
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
                    //instructsListBox.Items.Clear();
                    //instructsListBox.Items.AddRange(Instructions.ToArray()); 
                }

                //Reload the reduced instruction list to accomodate changes
                //NOTE: the reduced instruction list is an instruction-translated copy of the trace file
                InstructionListReduced.Clear();
                foreach (string instr in Instructions)
                {
                    InstructionListReduced.Add(new Instruction(instr));
                }

                //Reload the instruction list to accomodate changes
                InstructionList.Clear();
                int instructionNumber = 1;  //Int to track instruction order
                for(int currentInstr = 0; currentInstr < Instructions.Count; currentInstr++) //For each string from the trace file
                //foreach (string instr in Instructions)     
                {
                    //Turn the string into an instruction and add it to the appropriate list
                    Instruction newInstruction = new Instruction(instr, latFPAdd, latFPSub, latFPMul, latFPDiv);
                    newInstruction.InstructionNumber = instructionNumber;
                    if (newInstruction.Type == "LABEL")
                        LabelList.Add(newInstruction);
                    else
                        InstructionList.Add(newInstruction);

                    //Increment the instruction number to prepare for the next instruction
                    instructionNumber += 1;

                    //If the newly added instruction was a BRANCH instruction...
                    if (InstructionList.Last().Type == "BRANCH")
                    {
                        //Keep track of the current position in the branch
                        int branchPosition = 0;

                        //Set currentPosition to the most recently added instruction
                        int currentPosition = InstructionList.Last().InstructionNumber;
                        //Set reducedCurrentPosition to the instruction's position in the reduced instruction list
                        int reducedCurrentPosition = InstructionListReduced.FindIndex(i => i.InstructionString == InstructionList.Last().InstructionString);
                        
                        //If the branch goes backward and is taken, add the re-run instructions to the instruction list
                        
                        branchPosition = InstructionListReduced.FindIndex(i => i.InstructionName == InstructionList.Last().Destination);

                        //If the branch goes forward and is taken, skip unrun instructions
                        if (branchPosition > reducedCurrentPosition && InstructionList.Last().LoopCount > 0)
                        {
                            //Set currentInstr to the label being branched to
                            currentInstr = InstructionListReduced.FindIndex(i => i.InstructionName == InstructionList.Last().Destination);
                        }
                        else if (branchPosition < currentPosition && InstructionList.Last().LoopCount > 0)
                        {
                            //Set the number of loops remaining to the loop count of the instruction
                            int loopsRemaining = InstructionList.Last().LoopCount;

                            //While there are more loops to expand...
                            while (loopsRemaining > 0)
                            {
                                loopsRemaining -= 1; //Decrement number of loops remaining

                                //Set branchPosition to the label being branched to
                                branchPosition = LabelList[LabelList.FindIndex(i => i.InstructionName == InstructionList.Last().Destination)].InstructionNumber;


                                //While adding the looped-through instructions...
                                while (branchPosition < currentPosition)
                                {
                                    branchPosition += 1;            //Increment branchPosition to the next instruction to duplicate
                                    InstructionList.Add(new Instruction(InstructionList[InstructionList.FindIndex(i => i.InstructionNumber == branchPosition)].InstructionString));    //Duplicate the instruction
                                    InstructionList.Last().InstructionNumber = instructionNumber;       //Set the instruction number
                                    instructionNumber += 1;         //Increment the instruction number for the next instruction

                                    //If at the duplicated branch instruction, modify loop count and string
                                    if (branchPosition == currentPosition)
                                    {
                                        InstructionList.Last().LoopCount = loopsRemaining;
                                        InstructionList.Last().InstructionString = InstructionList.Last().CreateBranchString();
                                    }
                                }
                            }
                        }
                    }
                }

                instructsListBox.Items.Clear();
                foreach (Instruction instr in InstructionList)
                    instructsListBox.Items.Add(instr.InstructionString);

                //foreach (Instruction instr in InstructionList)
                    //execListBox.Items.Add(instr.InstructionNumber);

                cpu = new CPU(InstructionList);
            }
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

                string[] delays = { "Reorder buffer delays: ", "Reservation station delays", 
                    "Data memory conflict delays: ", "True dependence delays: "  + cpu.trueDependenceDelays};
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


