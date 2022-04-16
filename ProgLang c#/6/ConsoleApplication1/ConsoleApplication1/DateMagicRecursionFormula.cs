using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{ 
    //[3]
    public class DateMagicRecursionFormula : Task
    {
        public DateMagicRecursionFormula()
        {
            DateCalc(IOput.DateInput());
            IOput.BurnAfterReading();

        }
        public static void DateCalc(DateTime[] DateArray)
        {
            int days;
            days = Calculations.Date(DateArray);
            IOput.NoClearMessage(Calculations.DateLogic(days));
        }

    }
}
