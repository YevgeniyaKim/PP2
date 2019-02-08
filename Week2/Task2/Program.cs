using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //write a function to check for prime numbers
        public static bool IsPrime(string a)
        {
            int x = int.Parse(a);
            if (x <= 1) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0) return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            //create a list only for prime numbers
            List<string> res = new List<string>();
            //open file of input
            FileStream fs = new FileStream(@"C:\PP2\W2\Week2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //read a string
            string line = sr.ReadLine();
            //create an array of string line
            string[] nums = line.Split(' ');
            //if an element in array is prime, add to the list
            foreach (var x in nums)
            {
                if (IsPrime(x))
                {
                    res.Add(x);
                }
            }
            //close file
            sr.Close();
            fs.Close();
            //create a new file to output
            FileStream fs2 = new FileStream(@"C:\PP2\W2\Week2\Task2\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            //write a result in output file
            foreach (var x in res)
            {
                sw.Write(x + " ");
            }
            //close file
            sw.Close();
            fs2.Close();
        }
    }
}
