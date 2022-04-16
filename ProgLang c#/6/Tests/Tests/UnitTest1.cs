using NUnit.Framework;
using ConsoleApp;
using System;



namespace Tests
{
    public class Tests
    {

        [Test]
        public void Common_Formula_9and6()
        {
            double[] arr = { 9, 0, 6 };

            double expected = 2;

            Assert.AreEqual(expected, Calculations.CommonFormulaCalc(arr));
        }
        [Test]
        public void Common_Formula_16and1()
        {
            double[] arr = { 16, 0, 1 };

            double expected = -2;

            Assert.AreEqual(expected, Calculations.CommonFormulaCalc(arr));

        }
        [Test]
        public void Common_Formula_16andMinus6()
        {
            double[] arr = { 16, 0, -6 };

            double expected = 5;

            Assert.AreEqual(expected, Calculations.CommonFormulaCalc(arr));

        }
        [Test]
        public void Recursive_Formula8()
        {
            int days = 8, expected = 0;
            Assert.AreEqual(Calculations.RecursiveFormula(days), expected);
        }
        [Test]
        public void Recursive_Formula1()
        {
            int days = 1, expected = 0;
            Assert.AreEqual(Calculations.RecursiveFormula(days), expected);
        }
        [Test]
        public void Recursive_Formula15()
        {
            int days = 15, expected = 1;
            Assert.AreEqual(Calculations.RecursiveFormula(days), expected);
        }
        [Test]
        public void Recursive_Formula16384()
        {
            int days = 16384, expected = 0;
            Assert.AreEqual(Calculations.RecursiveFormula(days), expected);
        }
        [Test]
        public void Same_Days_DateCalc()
        {
            DateTime[] dat = new DateTime[4];
            int expected = 1;
            string[] datas =
                {
                "22/12/2000",
                "22/12/2000",
                "22/12/2000",
                "22/12/2000",

            };
            for (int i = 0; i < 4; i++)
                dat[i] = DateTime.Parse(datas[i]);
            Assert.AreEqual(Calculations.Date(dat), expected);
        }
        [Test]
        public void Days10_DateCalc()
        {
            DateTime[] dat = new DateTime[4];
            int expected = 10;
            string[] datas =
                {
                "13/12/2000",
                "22/12/2000",
                "01/12/2000",
                "22/12/2000",

            };
            for (int i = 0; i < 4; i++)
                dat[i] = DateTime.Parse(datas[i]);
            Assert.AreEqual(Calculations.Date(dat), expected);
        }
        [Test]
        public void Days0_DateCalc()
        {
            DateTime[] dat = new DateTime[4];
            int expected = 0;
            string[] datas =
                {
                "13/12/2000",
                "22/12/2000",
                "23/12/2000",
                "25/12/2000",

            };
            for (int i = 0; i < 4; i++)
                dat[i] = DateTime.Parse(datas[i]);
            Assert.AreEqual(Calculations.Date(dat), expected);
        }
        [Test]
        public void Days0_DateCalcSecond()
        {
            DateTime[] dat = new DateTime[4];
            int expected = 0;
            string[] datas =
                {
                "23/12/2000",
                "25/12/2000",
                "01/12/2000",
                "03/12/2000",

            };
            for (int i = 0; i < 4; i++)
                dat[i] = DateTime.Parse(datas[i]);
            Assert.AreEqual(Calculations.Date(dat), expected);
        }
        [Test]
        public void Days23_DateCalc_Reversed()
        {
            DateTime[] dat = new DateTime[4];
            int expected = 23;
            string[] datas =
                {
                "31/12/2000",
                "01/12/2000",
                "23/12/2000",
                "05/11/2000",

            };
            for (int i = 0; i < 4; i++)
                dat[i] = DateTime.Parse(datas[i]);
            Assert.AreEqual(Calculations.Date(dat), expected);
        }
        [Test]
        public void DateLogicIsBigger()
        {
            int days = 16384;
            string expected = "N is too big";
            Assert.AreEqual(Calculations.DateLogic(days), expected);
        }
        [Test]
        public void DateLogicTestNO()
        {
            int days = 16383;
            string expected = "RecForm result(If N is a power of 2, N=16383): NO\n"; ;
            Assert.AreEqual(Calculations.DateLogic(days), expected);
        }
        [Test]
        public void DateLogicTestYES()
        {
            int days = 8192;
            string expected = "RecForm result(If N is a power of 2, N=8192): YES\n"; ;
            Assert.AreEqual(Calculations.DateLogic(days), expected);
        }
        [Test]
        public void SameStringsCompareY()
        {
            string a = "OOL", b = "OOL", expected = "Строки посимвольно равны";
            Assert.AreEqual(StringsComparison.CompareSymbol(a, b), expected);
        }
        [Test]
        public void SameStringsCompareN()
        {
            string a = "OOl", b = "OOL", expected = "Строки не равны посимвольно";
            Assert.AreEqual(StringsComparison.CompareSymbol(a, b), expected);
        }
        [Test]
        public void StringsRegCompareY()
        {
            string a = "OOl", b = "OOL", expected = "Строки равны при приведении к одному регистру";
            Assert.AreEqual(StringsComparison.CompareReg(a, b), expected);
        }
        [Test]
        public void StringsRegCompareN()
        {
            string a = "OO1", b = "OOl", expected = "Строки не совпадают при приведении к одному регистру";
            Assert.AreEqual(StringsComparison.CompareReg(a, b), expected);
        }
        [Test]
        public void StringsReverseCompareY()
        {
            string a = "LOO", b = "OOL", expected = "Строки являются перевертышами";
            Assert.AreEqual(StringsComparison.CompareReverse(a, b), expected);
        }
        [Test]
        public void StringsReverseCompareN()
        {
            string a = "lOO", b = "OO1", expected = "Строки не являются перевертышами";
            Assert.AreEqual(StringsComparison.CompareReverse(a, b), expected);
        }
        [Test]
        public void StringRegexEmailY()
        {
            string a = "ten@net.ten", expected = $"Строка {a} - это email";
            Assert.AreEqual(StringsComparison.CompareRegexEmail(a), expected);
        }
        [Test]
        public void StringRegexEmailN()
        {
            string a = "tenet.t", expected = $"Строка {a} не является email'ом";
            Assert.AreEqual(StringsComparison.CompareRegexEmail(a), expected);

        }
        [Test]
        public void StringRegexPhoneY()
        {
            string a = "79990387948", expected = $"Строка {a} - это телефонный номер";
            Assert.AreEqual(StringsComparison.CompareRegexPhone(a), expected);
        }
        [Test]
        public void StringRegexPhoneN()
        {
            string a = "", expected = $"Строка {a} не является телефонным номером";
            Assert.AreEqual(StringsComparison.CompareRegexPhone(a), expected);
        }
        [Test]
        public void StringRegexIPYes()
        {
            string a = "8.8.8.8", expected = $"Строка {a} - это IP-адрес";
            Assert.AreEqual(StringsComparison.CompareRegexIP(a), expected);
        }
        [Test]
        public void StringRegexIPNo()
        {
            string a = "", expected = $"Строка {a} не является IP-адресом";
            Assert.AreEqual(StringsComparison.CompareRegexIP(a), expected);
        }

    }
}

