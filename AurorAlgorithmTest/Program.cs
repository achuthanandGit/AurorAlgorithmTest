using AurorAlgorithmAssessment;
using System.Collections.Generic;

namespace AurorAlgorithmTest
{
    class Program
    {
        public static void Main(string[] args) {
            StringInterpolation stringInterpolation = new StringInterpolation();
            stringInterpolation.Interpolate("Hello [name], [[author]",
                     new Dictionary<string, string> { { "name", "Jim" } });
                }
    }
}
