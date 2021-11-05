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

        public SimulationForm() {
            InitializeComponent();
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            string[] defaultConfigText = { "Buffers: ", "Eff Addr: ", "FP Adds: ", "FP Muls: ", "Ints: ", "Reorder: ", "Latencies: ", "FP Add: ", "FP Sub: ", "FP Mul: ", "FP Div: " };
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
                    InstructionList.Add(new Instruction(instr));
                }
            }
        }
    }
}
