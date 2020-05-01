using System.Text;

namespace IngameScript
{
    partial class Program
    {
        public class Profiler
        {
            Program program;
            double totalRuntime = 0;
            int totalRuns = 0;

            public Profiler(Program program)
            {
                this.program = program;
            }

            public void print()
            {
                totalRuns++;
                totalRuntime += program.Runtime.LastRunTimeMs;
                StringBuilder outputBuilder = new StringBuilder();
                outputBuilder.Append("\n-Runtime: ").AppendFormat("{0:0.000}", program.Runtime.LastRunTimeMs).Append("ms");
                program.Echo(outputBuilder.ToString());
                outputBuilder.Clear();
                outputBuilder.Append("-Total Runtime: ").AppendFormat("{0:0.000}", totalRuntime).Append(" ms;");
                program.Echo(outputBuilder.ToString());
                outputBuilder.Clear();
                outputBuilder.Append("-Average Runtime: ").AppendFormat("{0:0.000}", totalRuntime / totalRuns).Append(" ms");
                program.Echo(outputBuilder.ToString());
                outputBuilder.Clear();
                outputBuilder.Append("-Instructions User: ").Append(program.Runtime.CurrentInstructionCount).Append(" / ").Append(program.Runtime.MaxInstructionCount);
                program.Echo(outputBuilder.ToString());
            }
        }
    }
}
