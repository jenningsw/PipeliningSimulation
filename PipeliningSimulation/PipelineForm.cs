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
    public partial class PipelineForm : Form
    {
        private SimulationForm _simForm;

        public PipelineForm()
        {
            InitializeComponent();
        }

        public PipelineForm(SimulationForm simForm)
        {
            _simForm = simForm;
            InitializeComponent();
        }

        private void PipelineForm_Load(object sender, EventArgs e)
        {

        }
    }
}
