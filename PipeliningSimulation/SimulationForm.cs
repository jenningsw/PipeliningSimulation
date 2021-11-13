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

        public string[] Instructions { get; set; } = new string[50];
        public List<Instruction> InstructionList { get; set; } = new List<Instruction>();
        public List<Instruction> LabelList { get; set; } = new List<Instruction>();

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
            configForm.Show();
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            PipelineForm sim = new PipelineForm(this);
            sim.Show();
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

                    Instructions = input.Split("|".ToCharArray());
                    instructsListBox.Items.Clear();
                    instructsListBox.Items.AddRange(Instructions); 
                }

                //Reload the instruction list to accomodate changes
                InstructionList.Clear();
                foreach (string instr in Instructions)
                {
                    Instruction newInstruction = new Instruction(instr);
                    if (newInstruction.Type == "LABEL")
                        LabelList.Add(newInstruction);
                    else
                        InstructionList.Add(newInstruction);
                }
            }
        }

        //TODO: Delete this method before turning in
        //Test method for checking instruction value successful setting
        private void TestInstruction(Instruction instruction)
        {
            issuesListBox.Items.Add("name");
            issuesListBox.Items.Add(instruction.InstructionName);
            issuesListBox.Items.Add("op1");
            issuesListBox.Items.Add(instruction.Operand1);
            issuesListBox.Items.Add("op2");
            issuesListBox.Items.Add(instruction.Operand2);
            issuesListBox.Items.Add("dest");
            issuesListBox.Items.Add(instruction.Destination);
            issuesListBox.Items.Add("type");
            issuesListBox.Items.Add(instruction.Type);
            issuesListBox.Items.Add("loopcount");
            issuesListBox.Items.Add(instruction.LoopCount);
        }

        //TODO: Delete this method before turning in
        //Test method for checking branch label successful setting
        private void TestLabel(Instruction instruction)
        {
            issuesListBox.Items.Add("name");
            issuesListBox.Items.Add(instruction.InstructionName);
            issuesListBox.Items.Add("op1");
            issuesListBox.Items.Add(instruction.Operand1);
            issuesListBox.Items.Add("op2");
            issuesListBox.Items.Add(instruction.Operand2);
            issuesListBox.Items.Add("dest");
            issuesListBox.Items.Add(instruction.Destination);
            issuesListBox.Items.Add("type");
            issuesListBox.Items.Add(instruction.Type);
            issuesListBox.Items.Add("loopcount");
            issuesListBox.Items.Add(instruction.LoopCount);
        }

        private void runButton_Click(object sender, EventArgs e) {
            if (InstructionList.Count > 0) {
                CPU cpu = new CPU(InstructionList);
                foreach (Instruction i in cpu.instructions) {
                    issuesListBox.Items.Add(i.Results[0]);
                    execListBox.Items.Add(i.Results[1]);
                    readListBox.Items.Add(i.Results[2]);
                    writeListBox.Items.Add(i.Results[3]);
                    commitsListBox.Items.Add(i.Results[4]);
                }
            }
        }
    }
}
