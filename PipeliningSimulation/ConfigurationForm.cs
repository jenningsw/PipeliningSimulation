using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //set _simForm's config struct values to the corresponding values from the text boxes
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _simForm.Enabled = true;
        }
    }
}
