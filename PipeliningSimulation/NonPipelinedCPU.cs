using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation {
    public class NonPipelinedCPU {
        public Instruction[] instructions;
        public int cycles = 1;
        public List<List<string>> Results = new List<List<string>>(); // let's not change the values in our instructions (: 
        public NonPipelinedCPU(List<Instruction> insts) {
            instructions = insts.ToArray(); 
            for (int i = 0; i < instructions.Length; i++) {
                Results.Add(new List<string>());
            }
        }

        public void Run() {
            for (int i = 0; i < instructions.Length; i++) {
                Results[i].Add(cycles + "");
                cycles++;
                Results[i].Add(cycles + " - " + (cycles + instructions[i].TotalCycles - 1));
                cycles += instructions[i].TotalCycles;
                Results[i].Add(cycles + "");
                cycles++;
                Results[i].Add(cycles + "");
                cycles++;
                Results[i].Add(cycles + "");
                cycles++;
            }
        }
    }
}
