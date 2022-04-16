using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsApp
{
    //[2]
    public class FormulaCalculation : Task
    {
        public FormulaCalculation()
        {
            IOput.NoClearMessage(String.Format("{0:f3}", Formula(IOput.CommonFormula())));
        }
        public static double Formula(double[] arr)
        {
            Console.Clear();
            Console.WriteLine("Sqrt(x) - 6/z:");
            return Calculations.CommonFormulaCalc(arr);
        }
    }
}
