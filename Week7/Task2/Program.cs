using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class Program
    {
        class MyThread
        {
            Thread thread;
            string Name;

            public MyThread(string name) 
            {
                Name = name;
            }

            public void StartThread()
            {
                thread = new Thread(Output);
                thread.Start();
            }

            public void Output()
            {
                int i = 0;

                while (i != 4)
                {
                    i++;
                    Console.WriteLine((Name + " " + "выводит" + " " + i).ToString());
                }

                if (i == 4)
                {
                    Console.WriteLine(Name + " " + "завершился");
                }
            }
        }

        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            t1.StartThread();
            t2.StartThread();
            t3.StartThread();

            Console.Read();
        }
    }

    
}
