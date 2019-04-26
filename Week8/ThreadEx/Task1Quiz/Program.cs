using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1Quiz
{
    class Program
    {
        static ConsoleColor[] colors = new ConsoleColor[3]{ ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Yellow };

        static void ShowLetter(string s) {
            for (int i = 0; i < s.Length; i++) {
                Console.Write(s[i]);
                Thread.Sleep(500);
            }
        }

        static void ChangeColor() {
            int ind = 0;
            while (true) {
                Console.BackgroundColor = colors[ind];
                if (ind == 2)
                {
                    ind = 0;
                }
                else {
                    ind++;
                }
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            string s = "Hello! How are you?";
            Thread t1 = new Thread(() => {
                ShowLetter(s);
            });
            //Thread t2 = new Thread(ChangeColor);
            t1.Start();
            //t2.Start();
        }
    }
}
