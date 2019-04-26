using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[4];
            for (int i = 1; i <= 3; i++)
            {
                threads[i] = new Thread(PrintV);
                threads[i].Name = ("Thread " + i).ToString();
                threads[i].Start();
            }
        }

        private static void PrintV()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
        }
    }
}
