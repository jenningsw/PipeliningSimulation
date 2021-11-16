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
    public partial class NonPipelined : Form {
        public NonPipelined(NonPipelinedCPU npCPU) {
            InitializeComponent();
            npCPU.Run();
            for (int i = 0; i < npCPU.instructions.Length; i++) {
                instructsListBox.Items.Add(npCPU.instructions[i].InstructionString);
                issuesListBox.Items.Add(npCPU.Results[i][0]);
                execListBox.Items.Add(npCPU.Results[i][1]);
                readListBox.Items.Add(npCPU.Results[i][2]);
                writeListBox.Items.Add(npCPU.Results[i][3]);
                commitsListBox.Items.Add(npCPU.Results[i][4]);
            }
            lblTotalCycles.Text = "Total Cycles: " + (npCPU.cycles - 1);
        }
    }
}
