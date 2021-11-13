using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation {
    class Register {
        public int ID;
        public bool InUse; // tracks if register is currently waiting for a value to avoid dependencies 

        public Register(int ID) {
            this.ID = ID;
            InUse = false; 
        }
    }
}
