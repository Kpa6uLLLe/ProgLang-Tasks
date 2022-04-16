using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsApp
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
  
}
