using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void CatchError()
        {
            Console.WriteLine("#Something went wrong, press any key to continue.\n");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ConsApp()
        {
            Console.WriteLine("[0] Exit!");
            Console.WriteLine("[1] Hello world!");
            Console.WriteLine("[2] Calc: ");
        }
        public static double Formula(double x, double y, double z)
        {
            Console.Clear();
            double a, b, c;

                if (x < 0 || z == 0)
                {
                    CatchError();
                Console.WriteLine("Input x,y,z:\n");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                return Formula(a, b, c);
                }
                
                Console.WriteLine("(8V)\n");
                Console.WriteLine("sqrt(x) - 6/z:");
                return Math.Sqrt(x) - (6 / z);
        }
        public static void mem()
        {
            double a, b, c;
            string input="-1";
            ConsApp();
            for (; ; )
            {
                input = (Console.ReadLine());
                if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Hello world!\n");
                    Console.ReadKey();
                    Console.Clear();
                    ConsApp();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    ConsApp();
                    Console.WriteLine("Input x,y,z:\n");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(String.Format("{0:f3}",Formula(a, b, c)));
                    Console.ReadKey();
                    Console.Clear();
                    ConsApp();
                }
                else
                {
                    CatchError();
                    ConsApp();
                }

            }
        }
        static void Main(string[] args)
        {
            mem();
        }
    }
}
