using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

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
        public static void DeadException()
        {
            Console.WriteLine("#Something went wrong");
            Environment.Exit(0);
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
                    x = ParserFromString.Double(ConsoleArgs.ToFindAnArg("-x"));
                    y = ParserFromString.Double(ConsoleArgs.ToFindAnArg("-y")); 
                    z = ParserFromString.Double(ConsoleArgs.ToFindAnArg("-z"));
                Console.WriteLine($"#SMALLCALC:\nAnswer is: {CommonFormulaCalc(x, z)}");
            }
        
        public static double CommonFormulaCalc(double x,double z)
        {
            if (x < 0 || z == 0)
            {
               ConsoleExceptions.DeadException();
            }
            return Math.Sqrt(x) - (6 / z);
        }
    }

    public class MenuNum3
    {
        public MenuNum3()
        {
            try
            {
                DateTime[] arr = new DateTime[4];
                arr[0] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d1st"));
                arr[1] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d1end"));
                arr[2] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d2st"));
                arr[3] = ParserFromString.Date(ConsoleArgs.ToFindAnArg("-d2end"));
                Console.WriteLine("#DATERECCALC: ");
                Console.WriteLine(Calculations.DateLogic(Calculations.Date(arr)));
            }
            catch
            {

                ConsoleExceptions.DeadException();
            }
        }
    }
    public class MenuNum4
    {
        public MenuNum4()
        {
            string s1 = ConsoleArgs.ToFindAnArg("-s1"), s2 = ConsoleArgs.ToFindAnArg("-s2");
            Console.WriteLine("#STRINGS: ");
            StringsComparison.CompareDefault(s1, s2);
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
                    variable = Convert.ToDouble(message);
                    return variable;
                }
                catch
                {
                    variable = Convert.ToDouble(ConsoleExceptions.FriendlyInput("#Wrong (Double)input took place here, please reinsert the value"));
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
                    variable = Convert.ToInt32(message);
                    return variable;
                }
                catch
                {
                    variable = Convert.ToInt32(ConsoleExceptions.FriendlyInput("#Wrong (Int) input took place here, please reinsert the value"));
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
                    variable = DateTime.Parse(message);
                    return variable;
                }
                catch
                {
                    variable = DateTime.Parse(ConsoleExceptions.FriendlyInput("#Wrong (DateTime) input took place here, please reinsert the value"));
                }
            }
            return DateTime.Now;
        }
    }
    public class HelpDesk
    {
        public HelpDesk()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(
"//\tHELP DESK\n" +
"//Список аргументов:\n\n" +
"//-mi номер пункта меню\n" +
"//-x аргумент X\n" +
"/-y аргумент Y\n" +
"//-z аргумент Z\n" +
"//-d1st Дата начала первого отрезка дат\n" +
"//-d1end Дата окончания первого отрезка дат\n" +
"//-d2st Дата начала второго отрезка дат\n" +
"//-d2end Дата окончания второго отрезка дат\n" +
"//-s1 Первая строка\n" +
"//-s2 Вторая строка\n\n" +
"Example: -mi 3 -s1 'your string №1' -s2 'your string №2'\n" +
"//\tMENU's APPEARANCE:\t\n" 

) ;
            IOput.ConsApp();
            Console.ResetColor();
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
        public static void MenuSwitcher(int Option)
        {
            switch (Option)
            {
                case 0:
                    new MenuNum0();
                    break;
                case 1:
                    new MenuNum1();
                    break;
                case 2:
                    new MenuNum2();
                    break;
                case 3:
                    new MenuNum3();
                    break;
                case 4:
                    new MenuNum4();
                    break;
                default:
                    ConsoleExceptions.Exception();
                    break;
            }
        }
        public ConsoleArgs(string[] argus)
        {
            args = argus;
            string zeroElem = args[0].ToLower();
            if (args.Length == 1 && zeroElem == "-h" || zeroElem == "--h" || zeroElem == "-help" || zeroElem == "--help" || zeroElem == "help")
                new HelpDesk();
            else
            {
                try {
                    int mi = ParserFromString.Int(ToFindAnArg("-mi"));
                    Console.WriteLine($"#Task {mi}");
                    MenuSwitcher(mi);
                    }
                catch
                {
                    ConsoleExceptions.Exception();
                }
                }
        }
        public static string ToFindAnArg(string s)
        {
            for (int i=0;i<args.Length;i++)
            {
                if (args[i] == s && i + 1 != args.Length)
                {
                    return args[i + 1];
                }
            }
            throw new Exception();
        }
    }
    
        
   
}
