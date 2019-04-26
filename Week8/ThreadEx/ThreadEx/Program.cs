using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadEx
{
    /*class Human{
        static public void Show(){
            Console.WriteLine("Hello");
        }
    }*/
    class Program
    {
        static public void Count() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
        }

        static public void Count2()
        {
            for (int i = 100; i <= 110; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Count2);
            t1.Start();
            Count();
        }
    }
}
