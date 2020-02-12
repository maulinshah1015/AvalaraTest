using System.Collections.Generic;
using AvalaraTest.IO;
using AvalaraTest.Model;

namespace AvalaraTest.Solution
{
    public interface ISolver
    {
        IEnumerable<Slide> Solve(InputData inputData);
    }
}