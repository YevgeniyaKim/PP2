using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace traffic
{
    class Program
    {
        static int cnt = 0;
        static public int Cnt {
            get {
                return cnt;
            }
            set {
                if (value > 2)
                {
                    cnt = 0;
                }
                else {
                    cnt = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("0");
            Console.WriteLine("0");
            Console.WriteLine("0");

            ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 3; i++) {
                    if (i == Cnt)
                    {
                        Console.ForegroundColor = colors[i];
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine('0');
                }
                Cnt++;
                Thread.Sleep(2000);
            }
        }
    }
}
