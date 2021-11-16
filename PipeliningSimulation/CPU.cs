using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation {
    class CPU {
        public List<Instruction> instructions = new List<Instruction>();
        int idxInst = 0; // index of curr instruction 
        List<List<Instruction>> pipeline = new List<List<Instruction>>(); // instructions in each stage of pipeline 
        public int cycle = 0;
        Register[] registers = new Register[16];
        public int trueDependenceDelays = 0;
        bool completed = false; 

        public CPU(List<Instruction> inst) {

            for (int i = 0; i < 5; i++) {
                pipeline.Add(new List<Instruction>());
            }

            for (int i = 0; i < 16; i++)
                registers[i] = new Register(i);

            instructions = inst;

        }

        /// <summary>
        /// Step through each stage of pipeline 
        /// </summary>
        public void Cycle() {
            if (completed)
                return; 
            Issue();
            Execute();
            MemoryRead();
            WriteResult();
            Commit();

            ResetPipeline();
            cycle++;
            if (IsPipelineEmpty())
                completed = true; 
        }

        private void Issue() {
            // move previous instruction up pipeline 
            if (pipeline[0].Count > 0) {
                pipeline[0][0].MovedUpPipeline = true;
                pipeline[0][0].Results[0] = cycle.ToString();

                pipeline[1].Add(pipeline[0][0]); // move up pipeline to next stage 
                pipeline[0].Clear();
            }

            if (idxInst >= instructions.Count)
                return;

            // fetch first instruction;
            pipeline[0].Add(instructions[idxInst]);

            // mark destination reg as being used 
            SetDestRegisterUseage(instructions[idxInst]);

            idxInst++;
        }

        private void Execute() {
            List<Instruction> exe = pipeline[1];
            for (int i = 0; i < exe.Count; i++) {
                // if instruction was just moved up pipeline 
                if (exe[i].MovedUpPipeline)
                    continue;

                // now we need to check for dependencies 
                if (CheckDependency(exe[i])) {
                    trueDependenceDelays++;
                    continue;
                }

                // if first cycle of execution 
                if (exe[i].CyclesLeft == exe[i].TotalCycles) {
                    exe[i].Results[1] = cycle + " - ";
                }

                exe[i].CyclesLeft--;
                if (exe[i].CyclesLeft == 0) {
                    // execution is complete, move to next stage 
                    exe[i].Results[1] += cycle.ToString();
                    exe[i].MovedUpPipeline = true;
                    // we should skip the 'memory read' stage unless this is a store or load instruction  
                    if (exe[i].Type == "STORE" || exe[i].Type == "LOAD") 
                        pipeline[2].Add(exe[i]);
                    else
                        pipeline[3].Add(exe[i]);

                    exe.Remove(exe[i]);
                }
            }
        }

        private void MemoryRead() {
            List<Instruction> memRead = pipeline[2];
            if (memRead.Count == 0 || memRead[0].MovedUpPipeline)
                return;

            memRead[0].Results[2] = cycle.ToString();
            memRead[0].MovedUpPipeline = true;
            pipeline[3].Add(memRead[0]);
            memRead.RemoveAt(0);
        }

        private void WriteResult() {
            List<Instruction> write = pipeline[3];
            if (write.Count == 0 || write[0].MovedUpPipeline)
                return;

            write[0].Results[3] = cycle.ToString();
            write[0].MovedUpPipeline = true;
            pipeline[4].Add(write[0]);

            // dest register is no longer in use 
            int destID = OperandToRegID(write[0].Destination);
            registers[destID].InUse = false;
            registers[destID].instIDX.Remove(instructions.IndexOf(write[0]));

            write.RemoveAt(0);
        }

        private void Commit() {
            List<Instruction> commit = pipeline[4];
            // very messy and probably very not good way to make sure instructions commit in order 
            // TLDR: find first instruction that hasn't committed and commit it 
            for (int i = 0; i < commit.Count; i++) {
                if (commit[i].MovedUpPipeline)
                    continue;
                // has the previous instruction been committed yet? 
                int instIdx = instructions.IndexOf(commit[i]);
                if (instIdx > 0) {
                    if (!instructions[instIdx - 1].Committed)
                        continue;
                }

                commit[i].Results[4] = cycle.ToString();
                commit[i].MovedUpPipeline = true;
                commit[i].Committed = true;

                commit.RemoveAt(i);
                return;
            }

        }

        private bool IsPipelineEmpty() {
            for (int i = 0; i < pipeline.Count; i++) {
                if (pipeline[i].Count > 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Resets all 'MovedUpPipeline' attributes of instructions for next cycle
        /// </summary>s
        private void ResetPipeline() {
            for (int i = 0; i < pipeline.Count; i++) {
                for (int j = 0; j < pipeline[i].Count; j++) {
                    pipeline[i][j].MovedUpPipeline = false;
                }
            }
        }

        private int OperandToRegID(string op) {
            return int.Parse(op.Remove(0, 1));
        }

        private void SetDestRegisterUseage(Instruction inst) {
            int destRegID = OperandToRegID(inst.Destination);
            registers[destRegID].InUse = true;
            registers[destRegID].instIDX.Add(idxInst);
        }

        /// <summary>
        /// Determines if we are trying to use any registers which are currently in use 
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>True if dependency is found</returns>
        private bool CheckDependency(Instruction inst) {
            // if an operand is a register, check to see if it's being used by an instruction that is before the current instruction
            // if so, this will be a dependency and we should return true

            int destID = OperandToRegID(inst.Destination); // write after write 
            if (registers[destID].InUse) {
                foreach (int n in registers[destID].instIDX) {
                    if (n < instructions.IndexOf(inst))
                        return true; 
                }
            }
            // read after write 
            if (inst.Operand1.Contains("f")) {
                int op1ID = OperandToRegID(inst.Operand1);
                if (registers[op1ID].InUse) {
                    foreach (int n in registers[op1ID].instIDX) {
                        if (n < instructions.IndexOf(inst))
                            return true;
                    }
                }
            }
            if (inst.Operand2.Contains("f")) {
                int op2ID = OperandToRegID(inst.Operand2);
                if (registers[op2ID].InUse) {
                    foreach (int n in registers[op2ID].instIDX) {
                        if (n < instructions.IndexOf(inst))
                            return true;
                    }
                }
            }
            return false; 
        }

        public void RunToEnd() {
            do {
                Cycle();
            } while (!IsPipelineEmpty());
        }

        public void Step() {
            Cycle();
        }
    }
}
