using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 
namespace ConsoleApplication1
{
    public class TaskInfo
    {
        public static string[] Tasks = { 
            "[0] Exit!",
            "[1] Hello world!",
            "[2] Calc: ",
            "[3] Recursion Calc: ",
            "[4] Strings: "};
    }
    public class Task : TaskInfo
    {
        
        public static int TaskNumber;
    }
    public class Utility : TaskInfo
    {
        
    }
    //Utilities
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
            catch {
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
                Exceptions.CatchError();
                return CommonFormulaCalc(arr);
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
            Console.WriteLine("#Something went wrong, press any key to continue.\n");
            IOput.BurnAfterReading();
        }
        public static void CatchError(string message)
        {
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

    //Tasks
    public class Exit : Task
    {
        public Exit()
        {
            Environment.Exit(0);
        }
    }
    public class FormCalc : Task
    {
        public static double Formula(double[] arr)
        {
            Console.Clear();
            Console.WriteLine("sqrt(x) - 6/z:");
            return Calculations.CommonFormulaCalc(arr);
        }
    }
    public class Hello : Task
    {
        public static void HelloWorld()
        {
            IOput.NewMessage("Hello, World!");
        }
    }
    public class DateMagic : Task
    {
        public static void DateCalc(DateTime[] DateArray)
        {
                int days;
                days = Calculations.Date(DateArray);
                IOput.NoClearMessage(Calculations.DateLogic(days));
        }
        
    }
    public class Strings
    {
        
        public static void CompareSymbol(string a, string b)
        {
            if (a == b)
                Exceptions.Success("Строки посимвольно равны");
            else
                Exceptions.ValidationException("Строки не равны посимвольно");


    }
        public static void CompareReg(string a, string b)
        {
            a = a.ToUpper();
            b = b.ToUpper();
            while (a.Contains("  "))
            {
                a = a.Replace("  ", " ");
            }
            while (b.Contains("  "))
            {
                b = b.Replace("  ", " ");
            }
            a = a.Trim();
            b = b.Trim();
            if (a == b)
                Exceptions.Success("Строки равны при приведении к одному регистру");
            else
                Exceptions.ValidationException("Строки не совпадают при приведении к одному регистру");
        }
        public static void CompareReverse(string a, string b)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            a = new string(arr);
            if (a == b)
                Exceptions.Success("Строки являются перевертышами");
            else
                Exceptions.ValidationException("Строки не являются перевертышами");
        }
        public static void CompareRegexEmail(string a)
        {
            Regex r = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
            if (r.IsMatch(a))
                Exceptions.Success($"Строка {a} - это email");
            else
                Exceptions.ValidationException($"Строка {a} не является email'ом");
        }
        public static void CompareRegexPhone(string a)
        {
            Regex r = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
            if (r.IsMatch(a))
                Exceptions.Success($"Строка {a} - это телефонный номер");
            else
                Exceptions.ValidationException($"Строка {a} не является телефонным номером");
        }
        public static void CompareRegexIP(string a)
        {
            Regex r = new Regex(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
            if (r.IsMatch(a))
                Exceptions.Success($"Строка {a} - это IP-адрес");
            else
                Exceptions.ValidationException($"Строка {a} не является IP-адресом");
        }
        public static void CompareRegex(string a)
        {
            CompareRegexEmail(a);
            CompareRegexPhone(a);
            CompareRegexIP(a);
            //Console.WriteLine($"'{a}' Regex Email: {CompareRegexEmail(a)} ");
            //Console.WriteLine($"'{a}' Regex Phone Number: {CompareRegexPhone(a)}");
            //Console.WriteLine($"'{a}' Regex IP: {CompareRegexIP(a)}");

        }
        public static void CompareDefault(string a, string b)
        {
            Console.WriteLine("\n\nСравнение строк между собой");
            Strings.CompareSymbol(a, b);
            Strings.CompareReg(a, b);
            Strings.CompareReverse(a, b);
            Console.WriteLine("\n\n1-я строка\n");
            Strings.CompareRegex(a);
            Console.WriteLine("\n\n2-я строка\n");
            Strings.CompareRegex(b);
            
        }
    }
  
    // MAINMENU
    class Program
    {
        public static void Menu()
        {
            IOput.ConsApp();
            string a = "-1";
            a = Console.ReadLine();
            switch (a)
            {
                case "0":
                    new Exit();
                    break;
                case "1":
                    Hello.HelloWorld();
                    break;
                case "2":
                    IOput.NoClearMessage(String.Format("{0:f3}", FormCalc.Formula(IOput.CommonFormula())));
                    break;
                case "3":
                    DateMagic.DateCalc(IOput.DateInput());
                    IOput.BurnAfterReading();
                    break;
                case "4":
                    Strings.CompareDefault(IOput.GetString("Input string 1\n"), IOput.GetString("Input string 2\n"));
                    IOput.BurnAfterReading();
                    break;
                default:
                    Exceptions.CatchError();
                    break;
            }
            Console.Clear();
            Menu();

        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
