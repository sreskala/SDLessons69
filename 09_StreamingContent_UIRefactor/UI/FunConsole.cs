using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        private Random _randy = new Random();
        public void Clear()
        {
            Console.Clear();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            string newInput = "";
            bool capitalize = false;

            foreach(char letter in input)
            {
                if(capitalize)
                {
                    newInput += letter.ToString().ToUpper();
                    capitalize = !capitalize;
                } else
                {
                    newInput += letter.ToString().ToLower();
                    capitalize = !capitalize;
                }
            }

            return newInput;
        }

        public void WriteLine(string s)
        {
            string output = "";

            int colorPicker = _randy.Next(0, 5);
            foreach (char letter in s)
            {
                
                switch (colorPicker)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        output += letter;
                        
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        output += letter;
                        
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        output += letter;
                       
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        output += letter;
                        
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        output += letter;
                        
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        output += letter;
                        
                        break;
                    default:
                        break;
                }
            }
            
            Console.WriteLine(output);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
