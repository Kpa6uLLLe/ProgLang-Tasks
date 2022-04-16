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
         static void ConsApp()
        {
            Console.WriteLine("[0] Exit!");
            Console.WriteLine("[1] Hello world!");
            Console.WriteLine("[2] Calc: ");
            Console.WriteLine("[3] Recursion Calc: ");
        }
         static void HelloWorld()
         {
             Console.Clear();
             Console.WriteLine("Hello world!");
             Console.ReadKey();
             Console.Clear();
             Menu();

         }
         static double Formula()
         {
             Console.Clear();
             double x, y, z;
             Console.WriteLine("Input x,y,z:\n");
             x = Convert.ToDouble(Console.ReadLine());
             y = Convert.ToDouble(Console.ReadLine());
             z = Convert.ToDouble(Console.ReadLine());
             if (x < 0 || z == 0)
             {
                 CatchError();
                 return Formula();
             }

             Console.WriteLine("(8V)\n");
             Console.WriteLine("sqrt(x) - 6/z:");
             return Math.Sqrt(x) - (6 / z);
         }
        static void DateCalc() {
            int days;
            string answ = "";
            int rem = -1;
            try
            {
                Console.WriteLine("1st range\n Date1\n");
                DateTime Date1 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Date2\n");
                DateTime Date2 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("2nd range\n Date1\n");
                DateTime Date21 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Date2\n");
                DateTime Date22 = DateTime.Parse(Console.ReadLine());
                DateTime temp;
                if (Date1 > Date2)
                {
                    temp = Date2;
                    Date2 = Date1;
                    Date1 = temp;

                }
                if (Date21 > Date22)
                {
                    temp = Date22;
                    Date22 = Date21;
                    Date21 = temp;

                }


                if (Date2 < Date21 || Date22 < Date1)
                    days = 0;
                else if (Date2 == Date22 && Date1 == Date21)
                    days = 1;
                else if (Date1 > Date21)
                {
                    if (Date2 < Date22)
                        days = Math.Abs((Date1 - Date2).Days) + 1;
                    else
                        days = Math.Abs((Date1 - Date22).Days) + 1;
                }
                else if (Date21 > Date1)
                {
                    if (Date22 < Date2)
                        days = Math.Abs((Date21 - Date22).Days) + 1;
                    else
                        days = Math.Abs((Date21 - Date2).Days) + 1;
                }
                else
                    days = -1;

                if (days >= 16384)
                {
                    Console.WriteLine("N is too big");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
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
                Console.WriteLine($"RecForm result(If N is a power of 2, N={days}): {answ}\n");

                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            catch
            {

                CatchError();
                Menu();
            }
        }
      static int RecursiveFormula(int days)
        {
            
            if (days%2==1)
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
        static void Menu()
        {
            ConsApp();
            string a="-1";
            a=Console.ReadLine();
            switch (a) 
            {
                case "0":
                    break;
                case "1":
                    HelloWorld();
                    break;
                case "2":
                    Console.WriteLine(String.Format("{0:f3}", Formula()));

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    DateCalc();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    CatchError();
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
/*using System;
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
*/