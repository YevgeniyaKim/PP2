using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Светофор
{
    class Program
    {
        public static int cnt = 0;
        public static void ShowTraffic()
        {
            
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                cnt++;

                if(cnt==4)
                {
                    cnt = 1;
                }

                for(int i=0; i<3; i++)
                {
                    if (cnt == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*****");
                }
                Console.WriteLine(" ");

                for (int i = 0; i < 3; i++)
                {
                    if (cnt == 2)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*****");
                }
                Console.WriteLine(" ");

                for (int i = 0; i < 3; i++)
                {
                    if (cnt == 3)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*****");
                }
                Thread.Sleep(1000);

            }


        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(ShowTraffic);
            thread.Start();
            
        }
    }
}
