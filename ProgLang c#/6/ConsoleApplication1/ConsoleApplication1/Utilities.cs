using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Utilities
namespace ConsoleApp
{
    public class IOput : Utility
    {

        public static DateTime[] DateInput()
        {
            DateTime[] arr = new DateTime[4];
            try
            {
                Console.WriteLine("1st range\n Date1\n");
                arr[0] = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Date2\n");
                arr[1] = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("2nd range\n Date1\n");
                arr[2] = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Date2\n");
                arr[3] = DateTime.Parse(Console.ReadLine());

            }
            catch
            {
                Exceptions.CaughtToMenu();
            }
            return arr;
        }

        public static double[] CommonFormula()
        {
            double[] arr = new double[3];
            Console.WriteLine("Input x,y,z:\n");
            try
            {
                arr[0] = Convert.ToDouble(Console.ReadLine());
                arr[1] = Convert.ToDouble(Console.ReadLine());
                arr[2] = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Exceptions.CaughtToMenu();
            }
            return arr;
        }
        public static void NewMessage(string message)
        {
            //this method resets console before and after its output, then opens main menu
            Console.Clear();
            NoClearMessage(message);
        }
        public static void NoClearMessage(string message)
        {
            Console.WriteLine(message);
            BurnAfterReading();
            Program.Menu();
        }
        public static void BurnAfterReading()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public static void ConsApp()
        {
            foreach (string i in Tasks)
                Console.WriteLine(i);
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
    public class Calculations : Utility
    {
        public static int Date(DateTime[] DateArray)
        {
            int days;
            DateTime temp;
            if (DateArray[0] > DateArray[1])
            {
                temp = DateArray[1];
                DateArray[1] = DateArray[0];
                DateArray[0] = temp;

            }
            if (DateArray[2] > DateArray[3])
            {
                temp = DateArray[3];
                DateArray[3] = DateArray[2];
                DateArray[2] = temp;

            }


            if (DateArray[1] < DateArray[2] || DateArray[3] < DateArray[0])
                days = 0;
            else if (DateArray[1] == DateArray[3] && DateArray[0] == DateArray[2])
                days = 1;
            else if (DateArray[0] > DateArray[2])
            {
                if (DateArray[1] < DateArray[3])
                    days = Math.Abs((DateArray[0] - DateArray[1]).Days) + 1;
                else
                    days = Math.Abs((DateArray[0] - DateArray[3]).Days) + 1;
            }
            else if (DateArray[2] > DateArray[0])
            {
                if (DateArray[3] < DateArray[1])
                    days = Math.Abs((DateArray[2] - DateArray[3]).Days) + 1;
                else
                    days = Math.Abs((DateArray[2] - DateArray[1]).Days) + 1;
            }
            else
                days = -1;
            return days;
        }
        public static string DateLogic(int days)
        {
            int rem = -1;

            string answ = "";
            if (days >= 16384)
            {
                return "N is too big";
            }

            else if (days != 0)
            {
                rem = RecursiveFormula(days);

            }
            else
                rem = 1;
            if (rem == 0)
                answ = "YES";
            else if (rem == 1)
                answ = "NO";
            return $"RecForm result(If N is a power of 2, N={days}): {answ}\n";
        }
        public static int RecursiveFormula(int days)
        {

            if (days % 2 == 1)
            {
                if (days == 1)
                    return 0;
                else
                    return 1;
            }
            else
            {
                return RecursiveFormula(days / 2);
            }
        }
        public static double CommonFormulaCalc(double[] arr)
        {
            if (arr[0] < 0 || arr[2] == 0)
            {

                Exceptions.CaughtToMenu();
            }
            return Math.Sqrt(arr[0]) - (6 / arr[2]);
        }
    }
    public class Exceptions : Utility
    {

        public static void ValidationException(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Validation Exception] {message}");
            Console.ResetColor();
        }
        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
        public static void CatchError()
        {
            Console.Clear();
            Console.WriteLine("#Something went wrong, press any key to continue.\n");
            IOput.BurnAfterReading();
        }
        public static void CatchError(string message)
        {
            Console.Clear();
            Console.WriteLine($"#Something went wrong, press any key to continue.\n#Info: {message}");
            IOput.BurnAfterReading();
        }
        public static void CaughtToMenu()
        {
            CatchError();
            Program.Menu();
        }
        public static void CaughtToMenu(string message)
        {
            CatchError(message);
            Program.Menu();
        }
      
    }
 
}