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
            //fills in the instruction types for the reference table
            string[] strArray = { "Data Transfer" };
            typeListBox1.Items.AddRange(strArray);

            strArray = new string[] { "Arithmetic" };
            typeListBox2.Items.AddRange(strArray);

            strArray = new string[] { "Control" };
            typeListBox3.Items.AddRange(strArray);

            strArray = new string[] { "Floating Point" };
            typeListBox4.Items.AddRange(strArray);

            //fils in the instructions for the reference table
            strArray = new string[] { "lw", "", "flw", "", "sw", "", "fsw"};
            instructListBox1.Items.AddRange(strArray);

            strArray = new string[] { "add", "", "sub" };
            instructListBox2.Items.AddRange(strArray);

            strArray = new string[] { "beq", "", "bne" };
            instructListBox3.Items.AddRange(strArray);

            strArray = new string[] { "fadd.s", "", "fsub.s", "", "fmul.s", "", "fdiv.s" };
            instructListBox4.Items.AddRange(strArray);

            //fills in the formats for the instructions for the reference table
            strArray = new string[] { " lw rd, offset(rs1)", "", " flw rd, offset(rs1)", "", " sw rs2, offset(rs1)", "", " fsw rs2, offset(rs1)" };
            formatListBox1.Items.AddRange(strArray);

            strArray = new string[] { " add rd, rs1, rs2", "", " sub rd, rs1, rs2" };
            formatListBox2.Items.AddRange(strArray);

            strArray = new string[] { " beq rs1, rs2, offset", "", " bne rs1, rs2, offset" };
            formatListBox3.Items.AddRange(strArray);

            strArray = new string[] { " fadd.s rd, rs1, rs2", "", " fsub.s rd, rs1, rs2", "", " fmul.s rd, rs1, rs2", "", " fdiv.s rd, rs1, rs2" };
            formatListBox4.Items.AddRange(strArray);

            //fills in the decriptions of the instructions for the reference table
            strArray = new string[] { "Load word from memory location into a register", "", "Load floating point number from memory location into a register", "", "Store word into memory location from a register", "", "Store floating point number into memory location from a register" };
            descListBox1.Items.AddRange(strArray);

            strArray = new string[] { "Add two values together and store in specified register", "", "Subtract two values and store in specified register" };
            descListBox2.Items.AddRange(strArray);

            strArray = new string[] { "Branch if equal to", "", "Branch if not equal to" };
            descListBox3.Items.AddRange(strArray);

            strArray = new string[] { "Floating point add", "", "Floating point subtract", "", "Floating point multiply", "", "Floating point divide" };
            descListBox4.Items.AddRange(strArray);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
