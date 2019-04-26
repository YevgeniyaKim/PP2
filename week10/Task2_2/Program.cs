using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        public static string s;
        static void Main(string[] args)
        {
            Thread printTime = new Thread(Time);
            printTime.Start();
            Thread printString = new Thread(Subsrt);
            printString.Start();
        }

        private static void Time()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            Console.WriteLine("First Thread Ended");
        }

        private static void Subsrt()
        {
            s = Console.ReadLine();
            for (int i = 1; i < s.Length; i++)
            {
                for (int start = 0; start <= s.Length - i; start++)
                {
                    string substr = s.Substring(start, i);
                    Console.WriteLine(substr);
                }
            }
            Console.WriteLine("Second Thread Ended");
        }
    }
}
