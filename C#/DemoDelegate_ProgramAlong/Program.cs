using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate_ProgramAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<double> data = new List<double> { 2, 4, 6, 8, 10 };

            // TODO a) create ConversionDelegate with 1 parameter of type double and return type double

            // TODO b) create instance of ConversionDelegate and assign InchToCm; invoke delegate

            // TODO c) implement ConvertList

            // TODO d) convert list then call DisplayList

            // TODO e) repeat for InchToM

            // TODO f) What about FeetToInch? (adapter method, anonymous method)

            Console.WriteLine("\n");
        }

        // private static void DisplayList<T>(IList<T> list, string title)

        // private static IList<double> ConvertList(IList<double> data, ConversionDelegate convert)

    }
}