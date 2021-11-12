using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PipeliningSimulation
{
    /// <summary>
    /// Instruction class containing properties for each part of an instruction
    /// </summary>
    public class Instruction
    {
        public string InstructionString { get; set; }
        public string InstructionName { get; set; }
        public string Type { get; set; }
        public string Operand1 { get; set; }
        public string Operand2 { get; set; }
        public string Destination { get; set; }

        public int TotalCycles; // how many cycles this instrution requires to execute
        public int CyclesLeft; // how many cycles left in execution stage
        public bool MovedUpPipeline = false; // has this instruction already completed the current pipeline stage and moved on to next? 
        public bool Committed = false; // if instruction has been committed 
        public string Output = ""; // probably temporary string that makes sure the memes are memeing  


        /// <summary>
        /// Initializes a new instance of the <see cref="Instruction"/> class.
        /// </summary>
        public Instruction()
        {
            this.InstructionString = "";
            this.InstructionName = "";
            this.Type = "Null";
            this.Operand1 = "";
            this.Operand2 = "";
            this.Destination = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instruction"/> class.
        /// </summary>
        /// <param name="instrString">The instruction string to build the Instruction from.</param>
        public Instruction(string instrString)
        {
            this.InstructionString = instrString;

            //Replace commas and colons with spaces for easy splitting
            instrString = instrString.Replace(',', ' ');
            instrString = instrString.Replace(':', ' ');

            //Remove any unnecessary spaces
            while (instrString.Contains("  "))
                instrString = instrString.Replace("  ", " ");
            instrString = instrString.Trim();

            //Split the instruction into individual pieces
            string[] instrElements = instrString.Split(' ');



            //Fill the object properties with the appropriate data from the string
            this.InstructionName = instrElements[0];
            this.Type = DetermineType();
            //Logic for setting operands and destination
            #region operands
            //Store instructions have different operand order; Operate specially
            if (this.Type == "STORE")
            {
                Operand1 = instrElements[1];
                Destination = CalcAddress(instrElements[2], instrElements[3]);
                Operand2 = "";
            }
            //Load instructions only have one operand; Operate specially
            else if(this.Type == "LOAD")
            {
                Destination = instrElements[1];
                Operand1 = CalcAddress(instrElements[2], instrElements[3]);
                Operand2 = "";
            }
            //Branch instructions have a specific layout; Operate specially
            else if (this.Type == "BRANCH")
            {
                Operand1 = instrElements[1];
                Operand2 = instrElements[2];
                Destination = instrElements[3];
            }
            //All arithmetic operations have same operand/destination layout
            else if (this.Type == "INT" || this.Type == "FADD" || this.Type == "FMUL")
            {
                Destination = instrElements[1];
                Operand1 = instrElements[2];
                Operand2 = instrElements[3];
            }
            //Any other type is unknown, blank out operands and destination
            else
            {
                Operand1 = "";
                Operand2 = "";
                Destination = "ttttt";
            }
            #endregion operands
        }

        /// <summary>
        /// Determines the type of instruction based on the name.
        /// </summary>
        private string DetermineType()
        {
            string type = "";

            switch(this.InstructionName.ToLower())
            {
                case "lw":
                case "flw":
                    type = "LOAD";
                    break;
                case "sw":
                case "fsw":
                    type = "STORE";
                    break;
                case "add":
                case "sub":
                    type = "INT";
                    break;
                case "beq":
                case "bne":
                    type = "BRANCH";
                    break;
                case "fadd.s":
                case "fsub.s":
                    type = "FADD";
                    break;
                case "fmul.s":
                case "fdiv.s":
                    type = "FMUL";
                    break;
                default:
                    type = "UNKNOWN";
                    break;
            }

            return type;
        }

        /// <summary>
        /// Calculates the effective address.
        /// </summary>
        /// <param name="offsetString">The string containing the offset</param>
        /// <param name="regValueString">The value in the register.</param>
        /// <returns></returns>
        private string CalcAddress(string offsetString, string regValueString)
        {
            //Convert register value string to an int
            int regValue = Convert.ToInt32(regValueString);

            //Remove register from offset string
            offsetString = Regex.Replace(offsetString, @"\(.*\)", "");

            //Convert offset string to an int
            int offsetValue = Convert.ToInt32(offsetString);

            //Calculate and return address as string
            int address = regValue + offsetValue;
            return address.ToString();
        }
    }
}
