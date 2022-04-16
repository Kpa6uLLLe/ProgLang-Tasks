using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using WinConsApp;
using System.IO;
using System.Reflection;




namespace ConsoleApp
{   // MAINMENU
    class Program
    {
        public static void MenuSwitcher(string PressedButton)
        {
            switch (PressedButton)
            {
                case "0":
                    new Exit();
                    break;
                case "1":
                    new HelloWorld();
                    break;
                case "2":
                    new FormulaCalculation();
                    break;
                case "3":
                    new DateMagicRecursionFormula();
                    break;
                case "4":
                    new StringsComparison();
                    break;
                default:
                    Exceptions.CatchError();
                    break;
            }
        }
        public static void Menu()
        {
            IOput.ConsApp();
            MenuSwitcher(IOput.GetString("\nInput number of task you want to continue with: "));
            Console.Clear();
            Menu();

        }
        static void Main(string[] args)
        {
            if(args.Length!=0)
            {
                new ConsoleArgs(args);



                Console.ReadKey();
                new Exit();
                
            }
            Menu();
        }
    }
}