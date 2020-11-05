using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    class Program
    {
        public static double Average(int a, int b)
        {
            return Convert.ToDouble((a + b) / 2);
        }
        public static void Main(string[] args)
        {
            //ProgramUI userInterface = new ProgramUI();
            //userInterface.Run();
            Console.WriteLine(Average(2, 1));
            Console.ReadKey();
        }
    }
}
