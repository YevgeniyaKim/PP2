
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            System.Timers.Timer timer = new System.Timers.Timer(1);
            timer.Elapsed += Elapse;
            timer.Start();
            while (true)
            {

            }
        }

        private static void Elapse(object sender, ElapsedEventArgs e)
        {
            Console.SetCursorPosition(5, 3);
            DateTime time = DateTime.Now;
            Console.Write(time.Hour + ":" + time.Minute + ":" + time.Second + ":" + time.Millisecond);
        }


    }
}
