using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation {
    class Register {
        public int ID;
        public bool InUse; // tracks if register is currently waiting for a value to avoid dependencies 

        // what if the register is in use, but for an instruction that was issued after the instruction we're trying execute? 
        // thus, we need to keep track of the which instructions are using it to make sure it matters. 
        public List<int> instIDX = new List<int>(); 

        public Register(int ID) {
            this.ID = ID;
            InUse = false; 
        }
    }
}
