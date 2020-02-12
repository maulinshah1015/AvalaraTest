using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvalaraTest.Model;
using AvalaraTest.Solution.GreedySwap;
using AvalaraTest.Solution.Grouper;

namespace AvalaraTest
{
    class Program
    {
        public static string OutputPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Output\\";
        public static string InputExt = ".txt";
        public static string OutputExt = ".txt";

        static void Main(string[] args)
        {
            Directory.CreateDirectory(OutputPath);
            var io = new IO.IO(
                new StreamReader(@"../../DataSets/a" + InputExt),
                new StreamWriter(OutputPath + "a" + OutputExt));
            Solve(io);
        }

        private static void Solve(IO.IO io)
        {
            var inputData = io.Read();
            
            var solver = new GreedySwapSolver();


            var outputData = solver.Solve(inputData);
            io.Write(outputData);
        }
    }
}
