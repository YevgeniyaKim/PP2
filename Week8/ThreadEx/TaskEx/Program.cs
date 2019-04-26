using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            });
            t1.RunSynchronously();
        }
    }
}
