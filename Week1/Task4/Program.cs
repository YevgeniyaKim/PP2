using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading first line of an input, converting it into an int 
            int n = int.Parse(Console.ReadLine());
            //fill with stars
            for (int i=1; i<=n; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            } 
        }
    }
}
