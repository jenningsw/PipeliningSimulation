using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeliningSimulation {
    public partial class SimulationForm : Form {

        public struct Config 
        {
            public int buffers;
            public int effAddr;
            public int fpAdds;
            public int fpMuls;
            public int ints;
            public int reorder;
            public int latencies;
            public int fpAdd;
            public int fpSub;
            public int fpMul;
            public int fpDiv;

            public Config(int buffers, int effAddr, int fpAdds, int fpMuls, int ints, int reorder, int latencies, int fpAdd, int fpSub, int fpMul, int fpDiv)
            {
                this.buffers = buffers;
                this.effAddr = effAddr;
                this.fpAdds = fpAdds;
                this.fpMuls = fpMuls;
                this.ints = ints;
                this.reorder = reorder;
                this.latencies = latencies;
                this.fpAdd = fpAdd;
                this.fpSub = fpSub;
                this.fpMul = fpMul;
                this.fpDiv = fpDiv;
            }
        }

        public struct Delays
        {
            public int reorderBufferDelays;
            public int resStationDelays;
            public int memConflictDelays;
            public int trueDepDelays;
        }

        public Config SimConfig { get; set; }

        public Delays SimDelays { get; set; }

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

            SimConfig = new Config(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

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
    }
}
