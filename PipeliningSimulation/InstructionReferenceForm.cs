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
    public partial class InstructionReferenceForm : Form
    {
        public InstructionReferenceForm()
        {
            InitializeComponent();
            FillInBoxes();
            
        }

        public void FillInBoxes()
        {
            string[] instructionTypes = { "Data Transfer", "", "", "", "", "Arithmetic", "", "", "Control", "", "", "Floating Point", "", "", "" };
            intructTypeListBox.Items.AddRange(instructionTypes);

            string[] instructions = { "lw", "flw", "sw", "fsw", "", "add", "sub", "", "beq", "bne", "", "fadd.s", "fsub.s", "fmul.s", "fdiv.s"};
            instructListBox.Items.AddRange(instructions);

            string[] formats = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            formatListBox.Items.AddRange(formats);

            string[] descriptions = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            descriptionListBox.Items.AddRange(descriptions);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
