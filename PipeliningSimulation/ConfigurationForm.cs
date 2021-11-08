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

namespace PipeliningSimulation
{
    public partial class ConfigurationForm : Form
    {

        private SimulationForm _simForm;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        public ConfigurationForm(SimulationForm simForm)
        {
            _simForm = simForm;
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //read in a text config file and set the values to the corresponding text boxes

            OpenFileDialog configFile = new OpenFileDialog();
            configFile.InitialDirectory = "..\\..\\Config Files";
            configFile.Filter = "txt files (*.txt)|*.txt|config files (*.cfg)|*.cfg|All files (*.*)|*.*";
            configFile.FilterIndex = 2;

            if (configFile.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = configFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;
                    do { line = reader.ReadLine();  } while (line == "");
                    if (line == "buffers")
                    {
                        buffersTextBox.Text = "Yes";
                        do { line = reader.ReadLine(); } while (line == "");
                    }
                    else
                        buffersTextBox.Text = "No";

                    effAddrTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    fpAddsTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    fpMulsTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    intsTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    reorderTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    if (line == "latencies")
                    {
                        latenciesTextBox.Text = "Yes";
                        do { line = reader.ReadLine(); } while (line == "");
                    }
                    else
                        latenciesTextBox.Text = "No";

                    fpAddTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    fpSubTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    fpMulTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");

                    fpDivTextBox.Text = line.Substring(line.LastIndexOf(" "));
                    do { line = reader.ReadLine(); } while (line == "");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //set _simForm's config listbox values to the corresponding values from the text boxes

            if (buffersTextBox.Text.Substring(0,1).ToUpper() != "Y" && buffersTextBox.Text.Substring(0,1).ToUpper() != "N")
            {
                MessageBox.Show("Please change \"Buffers\" value to appropriate value: (Yes/No)");
                return;
            }

            else if (Int32.Parse(effAddrTextBox.Text) < 0 || Int32.Parse(effAddrTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"Eff Addr\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(fpAddsTextBox.Text) < 0 || Int32.Parse(fpAddsTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"FP Adds\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(fpMulsTextBox.Text) < 0 || Int32.Parse(fpMulsTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"FP Muls\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(intsTextBox.Text) < 0 || Int32.Parse(intsTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"Ints\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(reorderTextBox.Text) < 0 || Int32.Parse(reorderTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"Reorder\" value to appropriate value: (0-5)");
                return;
            }

            else if (latenciesTextBox.Text.Substring(0,1).ToUpper() != "Y" && latenciesTextBox.Text.Substring(0,1).ToUpper() != "N")
            {
                MessageBox.Show("Please change \"Latencies\" value to appropriate value: (Yes/No)");
                return;
            }

            else if (Int32.Parse(fpAddTextBox.Text) < 0 || Int32.Parse(fpAddTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"FP Add\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(fpSubTextBox.Text) < 0 || Int32.Parse(fpSubTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"FP Sub\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(fpMulTextBox.Text) < 0 || Int32.Parse(fpMulTextBox.Text) > 5)
            {
                MessageBox.Show("Please change \"FP Mul\" value to appropriate value: (0-5)");
                return;
            }

            else if (Int32.Parse(fpDivTextBox.Text) < 0 || Int32.Parse(fpDivTextBox.Text) > 10)
            {
                MessageBox.Show("Please change \"FP Div\" value to appropriate value: (0-5)");
                return;
            }

            ListBox configListBox = _simForm.Controls["configListBox"] as ListBox;

            if(buffersTextBox.Text.Substring(0,1).ToUpper() == "Y")   
                configListBox.Items[0] = "Buffers: T";
            else
                configListBox.Items[0] = "Buffers: F";

            configListBox.Items[1] = "Eff Addr: " + effAddrTextBox.Text;
            configListBox.Items[2] = "FP Adds: " + fpAddsTextBox.Text;
            configListBox.Items[3] = "FP Muls: " + fpMulsTextBox.Text;
            configListBox.Items[4] = "Ints: " + intsTextBox.Text;
            configListBox.Items[5] = "Reorder: " + reorderTextBox.Text;

            if(latenciesTextBox.Text.Substring(0,1).ToUpper() == "Y")
                configListBox.Items[6] = "Latencies: T";
            else
                configListBox.Items[6] = "Latencies: F";

            configListBox.Items[7] = "FP Add: " + fpAddTextBox.Text;
            configListBox.Items[8] = "FP Sub: " + fpSubTextBox.Text;
            configListBox.Items[9] = "FP Mul: " + fpMulTextBox.Text;
            configListBox.Items[10] = "FP Div: " + fpDivTextBox.Text;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _simForm.Enabled = true;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            //Set values in the configuration form based on already existing configuration settings

            ListBox configListBox = _simForm.Controls["configListBox"] as ListBox;

            if (configListBox.Items[0].ToString().Split(':')[1].Trim().Equals("T"))
                buffersTextBox.Text = "Yes";
            else
                buffersTextBox.Text = "No";

            effAddrTextBox.Text = configListBox.Items[1].ToString().Split(':')[1].Trim();
            fpAddsTextBox.Text = configListBox.Items[2].ToString().Split(':')[1].Trim();
            fpMulsTextBox.Text = configListBox.Items[3].ToString().Split(':')[1].Trim();
            intsTextBox.Text = configListBox.Items[4].ToString().Split(':')[1].Trim();
            reorderTextBox.Text = configListBox.Items[5].ToString().Split(':')[1].Trim();

            if (configListBox.Items[6].ToString().Split(':')[1].Trim().Equals("T"))
                latenciesTextBox.Text = "Yes";
            else
                latenciesTextBox.Text = "No";

            fpAddTextBox.Text = configListBox.Items[7].ToString().Split(':')[1].Trim();
            fpSubTextBox.Text = configListBox.Items[8].ToString().Split(':')[1].Trim();
            fpMulTextBox.Text = configListBox.Items[9].ToString().Split(':')[1].Trim();
            fpDivTextBox.Text = configListBox.Items[10].ToString().Split(':')[1].Trim();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            //Create a new save file dialog, set filter and initial directory settings, and show
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = "..\\..\\Config Files";
            saveDialog.Filter = "txt files (*.txt)|*.txt|config files (*.cfg)|*.cfg|All files (*.*)|*.*";
            saveDialog.FilterIndex = 4;
            saveDialog.ShowDialog();

            //If file name is not blank, safe the configuration settings
            if (saveDialog.FileName != "")
            {
                StreamWriter streamWriter = new StreamWriter(saveDialog.OpenFile());

                if (buffersTextBox.Text == "Yes")
                    streamWriter.WriteLine("buffers\n");

                streamWriter.WriteLine("eff addr: " + effAddrTextBox.Text);
                streamWriter.WriteLine("fp adds: " + fpAddsTextBox.Text);
                streamWriter.WriteLine("fp muls: " + fpMulsTextBox.Text);
                streamWriter.WriteLine("ints: " + intsTextBox.Text);
                streamWriter.WriteLine("reorder: " + reorderTextBox.Text);


                streamWriter.WriteLine("");

                if (latenciesTextBox.Text == "Yes")
                    streamWriter.WriteLine("latencies\n");

                streamWriter.WriteLine("fp_add: " + fpAddTextBox.Text);
                streamWriter.WriteLine("fp_sub: " + fpSubTextBox.Text);
                streamWriter.WriteLine("fp_mul: " + fpMulTextBox.Text);
                streamWriter.WriteLine("fp_div: " + fpDivTextBox.Text);

                streamWriter.Dispose();
                streamWriter.Close();
            }
        }
    }
}
