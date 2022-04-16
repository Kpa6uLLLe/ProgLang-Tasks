using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace WinConsApp
{
    //[4]
    public class StringsComparison : Task
    {
        public StringsComparison()
        {
            CompareDefault(IOput.GetString("Input string 1\n"), IOput.GetString("Input string 2\n"));
            IOput.BurnAfterReading();
        }

        public static string CompareSymbol(string a, string b)
        {
            if (a == b)
            {
                Exceptions.Success("Строки посимвольно равны");
                return "Строки посимвольно равны";
            }
            else
            {
                Exceptions.ValidationException("Строки не равны посимвольно");
                return "Строки не равны посимвольно";
            }


        }
        public static string CompareReg(string a, string b)
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
            {
                Exceptions.Success("Строки равны при приведении к одному регистру");
                return "Строки равны при приведении к одному регистру";
            }
            else
            {
                Exceptions.ValidationException("Строки не совпадают при приведении к одному регистру");
                return "Строки не совпадают при приведении к одному регистру";
            }
        }
        public static string CompareReverse(string a, string b)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            a = new string(arr);
            if (a == b)
            {
                Exceptions.Success("Строки являются перевертышами");
                return "Строки являются перевертышами";
            }
            else
            {
                Exceptions.ValidationException("Строки не являются перевертышами");
                return "Строки не являются перевертышами";
            }
        }
        public static string CompareRegexEmail(string a)
        {
            Regex r = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
            if (r.IsMatch(a))
            {
                Exceptions.Success($"Строка {a} - это email");
                return $"Строка {a} - это email";
            }
            else
            {
                Exceptions.ValidationException($"Строка {a} не является email'ом");
                return $"Строка {a} не является email'ом";
            }
        }
        public static string CompareRegexPhone(string a)
        {
            Regex r = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
            if (r.IsMatch(a))
            {
                Exceptions.Success($"Строка {a} - это телефонный номер");
                return $"Строка {a} - это телефонный номер";
            }
            else
            {
                Exceptions.ValidationException($"Строка {a} не является телефонным номером");
                return $"Строка {a} не является телефонным номером";
            }
        }
        public static string CompareRegexIP(string a)
        {
            Regex r = new Regex(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
            if (r.IsMatch(a))
            {
                Exceptions.Success($"Строка {a} - это IP-адрес");
                return $"Строка {a} - это IP-адрес";
            }
            else
            {
                Exceptions.ValidationException($"Строка {a} не является IP-адресом");
                return $"Строка {a} не является IP-адресом";
            }
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
            StringsComparison.CompareSymbol(a, b);
            StringsComparison.CompareReg(a, b);
            StringsComparison.CompareReverse(a, b);
            Console.WriteLine("\n\n1-я строка\n");
            StringsComparison.CompareRegex(a);
            Console.WriteLine("\n\n2-я строка\n");
            StringsComparison.CompareRegex(b);

        }
    }

}
