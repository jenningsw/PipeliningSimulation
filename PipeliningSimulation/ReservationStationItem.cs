using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation
{
    public class ReservationStationItem
    {
        public Instruction instruction { get; set; }            //Instruction in buffer
        public bool Operand1Received { get; set; }              //Bool for if first operand is received
        public List<int> Instruction1ToWaitFor { get; set; }    //Number of instruction working on operand 1
        public bool Operand2Received { get; set; }              //Bool for if second operand is receives
        public List<int> Instruction2ToWaitFor { get; set; }    //Number of instruction working on operand 2
    }
}
