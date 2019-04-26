using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTimer
{
    class MyTimer {
        int timeToCount;

        public MyTimer(int time) {
            timeToCount = time;
        }

        public void StartTimer() {
            for (int i = 0; i <= timeToCount; i++) {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyTimer timer = new MyTimer(10);
            timer.StartTimer();
        }
    }
}
