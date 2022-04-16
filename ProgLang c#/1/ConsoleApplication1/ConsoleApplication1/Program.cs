using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void ConsApp()
        {
            Console.WriteLine("[0] Exit!");
            Console.WriteLine("[1] Hello world!");
            Console.WriteLine("[2] Calc: ");
        }
        public static double Formula(int x, int y, int z)
        {

            Console.Clear();
            Console.WriteLine("[3] Va8");
            Console.WriteLine("[4] Va10");
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D3)
            {
                if (x < 0 || z == 0)
                {
                    mem();
                }
                Console.WriteLine("(8v)\n");
                Console.WriteLine("sqrt(x) -6/z:");
                return Math.Sqrt(x) - 6 / z;
            }
            else if (key.Key == ConsoleKey.D4)
            {
                if (y < 0 || z == 0)
                {
                    mem();

                }
                Console.WriteLine("(10v)");
                Console.WriteLine("(x + sqrt(y))/z:");
                return (x + Math.Sqrt(y)) / z;
            }
            else
            {
                Formula(x, y, z);
                return 0;
            }
        }
        public static void mem()
        {
            int a, b, c;
            ConsApp();
            for (int i = 1000; i > 0; i++)
            {
                i--;
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    break;
                }
                else if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Hello world!\n");
                    ConsApp();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Formula(a, b, c));
                    ConsApp();
                }
                else
                    ConsApp();
            }
        }
        static void Main(string[] args)
        {
            mem();
        }
    }
}
