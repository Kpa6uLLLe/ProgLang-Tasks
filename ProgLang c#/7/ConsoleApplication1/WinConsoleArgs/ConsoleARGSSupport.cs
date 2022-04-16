using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//-mi номер пункта меню
//-x аргумент X
//-y аргумент Y
//-z аргумент Z
//-d1st Дата начала первого отрезка дат
//-d1end Дата окончания первого отрезка дат
//-d2st Дата начала второго отрезка дат
//-d2end Дата окончания второго отрезка дат
//-s1 Первая строка
//-s2 Вторая строка


namespace WinConsApp
{
    public class ConsoleExceptions : Exception
    {

        public static void Exception()
        {
            Console.WriteLine("#Something went wrong");
        }
        public static void Exception(string message)
        {
            Console.WriteLine(message);
        }
        public static void ExceptionWithInfo()
        {
            Console.WriteLine("#Correct syntax is: -mi [num] -<mArg> [mValue]");
        }
        public static string FriendlyInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
   
    public class MenuNum0
    {
        public MenuNum0()
        {
            Environment.Exit(0);
        }
    }
    public class MenuNum1
    {
        public MenuNum1()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class MenuNum2
    {
        double x, y, z;
        public MenuNum2()
        {
                    x = ParserFromString.Double("-x");
                    y = ParserFromString.Double("-y"); 
                    z = ParserFromString.Double("-z");
                Console.WriteLine(CommonFormulaCalc(x, z));
            }
        
        public static double CommonFormulaCalc(double x,double z)
        {
            if (x < 0 || z == 0)
            {
                Exceptions.CatchError();
            }
            return Math.Sqrt(x) - (6 / z);
        }
    }
    public class MenuNum3
    {
        public MenuNum3()
        {
            string s1 = ConsoleArgs.ToFindAnArg("-s1"), s2 = ConsoleArgs.ToFindAnArg("-s2");
            StringsComparison.CompareDefault(s1,s2);
        }
    }
    public class MenuNum4
    {
        public MenuNum4()
        {
            DateTime[] arr= { };
            arr[0]= ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d1st"));
            arr[1] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d1end"));
            arr[2] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d2st"));
            arr[3] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d2end"));
            Console.WriteLine(Calculations.DateLogic(Calculations.Date(arr)));
        }
    }
    public class ParserFromString
    {
        public static double Double(string message)
        {
            int check = -1;
            double variable;
            while (check<0)
            {
                try
                {
                    variable = Convert.ToDouble(ConsoleArgs.ToFindAnArg(message));
                    return variable;
                }
                catch
                {
                    variable = Convert.ToDouble(ConsoleExceptions.FriendlyInput("#Wrong input took place here, please reinsert the value"));
                }
            }
            return double.NaN;
        }
        public static int Int(string message)
        {
            int check = -1;
            int variable;
            while (check < 0)
            {
                try
                {
                    variable = Convert.ToInt32(ConsoleArgs.ToFindAnArg(message));
                    return variable;
                }
                catch
                {
                    variable = Convert.ToInt32(ConsoleExceptions.FriendlyInput("#Wrong input took place here, please reinsert the value"));
                }
            }
            return 0;
        }
        public static DateTime Date(string message)
        {
            int check = -1;
            DateTime variable;
            while (check < 0)
            {
                try
                {
                    variable = DateTime.Parse(ConsoleArgs.ToFindAnArg(message));
                    return variable;
                }
                catch
                {
                    variable = DateTime.Parse(ConsoleExceptions.FriendlyInput("#Wrong input took place here, please reinsert the value"));
                }
            }
            return DateTime.Now;
        }
    }
    public class ConsoleArgs
    {
        public static string[] args;
        public static string[] PossibleArgs = {
            "-mi",
            "-x",
            "-y",
            "-z",
            "-d1st",
            "-d1end",
            "-d2st",
            "-d2end",
            "-s1",
            "-s2"
        };
        public static void MenuSwitcher(string Option)
        {
            switch (Option)
            {
                case "0":
                    new MenuNum0();
                    break;
                case "1":
                    new MenuNum1();
                    break;
                case "2":
                    new MenuNum2();
                    break;
                case "3":
                    new MenuNum3();
                    break;
                case "4":
                    new MenuNum4();
                    break;
                default:
                    Exceptions.CatchError();
                    break;
            }
        }
        public ConsoleArgs(string[] argus)
        {
            args = argus;
            int mi = ParserFromString.Int(ToFindAnArg("-mi"));
        }
        public static string ToFindAnArg(string s)
        {
            for (int i=0;i<args.Length;i++)
            {
                if (args[i] == s && i + 1 != args.Length)
                    return args[i + 1];
            }
            throw new Exception();
        }
        static void Main(string[] args)
        {
        }
    }
    
        
   
}
