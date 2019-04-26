using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TimerEx
{
    class Program
    {
        static void Count(object sender, ElapsedEventArgs e) {
            Console.WriteLine(100);
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            System.Timers.Timer t1 = new System.Timers.Timer(500);
            t1.Elapsed += Count;
            t1.Start();
            Thread.CurrentThread.Join(10000);
        }
    }
}
