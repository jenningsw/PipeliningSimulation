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

        public List<string> Instructions { get; set; } = new List<string>();
        public List<Instruction> InstructionList { get; set; } = new List<Instruction>();
        public List<Instruction> LabelList { get; set; } = new List<Instruction>();
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
            string[] defaultConfigText = { "Buffers: ", "Eff Addr: 2", "FP Adds: 3", "FP Muls: 3", "Ints: 3", "Reorder: 5", 
                "Latencies: ", "FP Add: 2", "FP Sub: 2", "FP Mul: 5", "FP Div: 10" };
            configListBox.Items.AddRange(defaultConfigText);

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
                    instructsListBox.Items.Clear();
                    instructsListBox.Items.AddRange(Instructions.ToArray()); 
                }

                //Reload the instruction list to accomodate changes
                InstructionList.Clear();
                foreach (string instr in Instructions)
                {
                    Instruction newInstruction = new Instruction(instr, latFPAdd, latFPSub, latFPMul, latFPDiv);
                    if (newInstruction.Type == "LABEL")
                        LabelList.Add(newInstruction);
                    else
                        InstructionList.Add(newInstruction);
                }
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
            configListBox.Items.Clear();
            configListBox.ResetText();

            cycleCountLabel.ResetText();
            cycleCountLabel.Text = "0";

            delaysListBox.Items.Clear();
            delaysListBox.ResetText();

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


