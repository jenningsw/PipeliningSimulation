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
        int cycle = 0;

        public CPU(List<Instruction> inst) {

            for (int i = 0; i < 5; i++) {
                pipeline.Add(new List<Instruction>());
            }

            instructions = inst;

            do {
                Cycle();
            } while (!PipelineEmpty());
        }

        /// <summary>
        /// Step through each stage of pipeline 
        /// </summary>
        public void Cycle() {
            Issue();
            Execute();
            MemoryRead();
            WriteResult();
            Commit();

            ResetPipeline();
            cycle++;
        }

        private void Issue() {
            // move previous instruction up pipeline 
            if (pipeline[0].Count > 0) {
                pipeline[0][0].MovedUpPipeline = true;
                pipeline[0][0].Output = cycle + " ";

                pipeline[1].Add(pipeline[0][0]); // move up pipeline to next stage 
                pipeline[0].Clear();
            }

            if (idxInst >= instructions.Count)
                return;

            // fetch first instruction;
            pipeline[0].Add(instructions[idxInst]);
            // remove from list of instructions 
            idxInst++;
        }

        private void Execute() {
            List<Instruction> exe = pipeline[1];
            for (int i = 0; i < exe.Count; i++) {
                // if instruction was just moved up pipeline 
                if (exe[i].MovedUpPipeline)
                    continue;
                // if first cycle of execution 
                if (exe[i].CyclesLeft == exe[i].TotalCycles)
                    exe[i].Output += cycle + "-";

                exe[i].CyclesLeft--;
                if (exe[i].CyclesLeft == 0) {
                    // execution is complete, move to next stage 
                    exe[i].Output += cycle + " ";
                    exe[i].MovedUpPipeline = true;
                    pipeline[2].Add(exe[i]);
                    exe.Remove(exe[i]);
                }
            }
        }

        private void MemoryRead() {
            List<Instruction> memRead = pipeline[2];
            if (memRead.Count == 0 || memRead[0].MovedUpPipeline)
                return;

            memRead[0].Output += cycle + " ";
            memRead[0].MovedUpPipeline = true;
            pipeline[3].Add(memRead[0]);
            memRead.RemoveAt(0);
        }

        private void WriteResult() {
            List<Instruction> write = pipeline[3];
            if (write.Count == 0 || write[0].MovedUpPipeline)
                return;

            write[0].Output += cycle + " ";
            write[0].MovedUpPipeline = true;
            pipeline[4].Add(write[0]);
            write.RemoveAt(0);
        }

        private void Commit() {
            List<Instruction> commit = pipeline[4];
            // very messy and probably very not good way to make sure instructions commit in order 
            // TLDR: find first instruction that hasn't committed and commit it 
            for (int i = 0; i < commit.Count; i++) {
                if (commit[i].MovedUpPipeline)
                    continue;

                int instIdx = instructions.IndexOf(commit[i]);
                if (instIdx > 0) {
                    if (!instructions[instIdx - 1].Committed)
                        continue;
                }

                commit[i].Output += cycle + " ";
                commit[i].MovedUpPipeline = true;
                commit[i].Committed = true;
                commit.RemoveAt(i);
                return;
            }

        }

        private bool PipelineEmpty() {
            for (int i = 0; i < pipeline.Count; i++) {
                if (pipeline[i].Count > 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Resets all 'MovedUpPipeline' attributes of instructions for next cycle
        /// </summary>
        private void ResetPipeline() {
            for (int i = 0; i < pipeline.Count; i++) {
                for (int j = 0; j < pipeline[i].Count; j++) {
                    pipeline[i][j].MovedUpPipeline = false;
                }
            }
        }
    }
}
