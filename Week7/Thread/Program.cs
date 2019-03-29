using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] thread = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                thread[i] = new Thread(Func);
                thread[i].Name = ("Thread " + i).ToString();
                thread[i].Start();
            }

        }

        private static void Func()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
            }
        }
    }
}
