using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace ConsoleApp
{   // MAINMENU
    class Program
    {
        public static void Menu()
        {
            IOput.ConsApp();
            string PressedButton = "-1";
            PressedButton = Console.ReadLine();
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
            Console.Clear();
            Menu();

        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}