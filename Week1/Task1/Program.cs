using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //writing a function to check for prime numbers
        public static bool IsPrime(int a)
        {
            if (a <= 1) return false;
            else
            {
                for(int i=2; i<Math.Sqrt(a); i++)
                {
                    if (a % i == 0) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //creating an empty list to collect only primes out of the array
            List<int> num = new List<int>();
            //reading first line of an input, converting it into an int 
            int n = int.Parse(Console.ReadLine());
            //creating an array of size n numbers
            int[] arr = new int[n];
            //reading second line of an input and separating it
            string[] nums = Console.ReadLine().Split(' ');
            //adding numbers to an array
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
            //running through the array and checking every element for prime using function
            foreach (int item in arr)
            {
                //if the function returns "true", adding an element to the list
                if (IsPrime(item)==true)
                {
                    num.Add(item);
                }
            }
            
            //printing the amount of elements of the list
            Console.WriteLine(num.Count);
            //joining elements into a string and separating them by space to print the list in a single line
            var combined = string.Join(" ", num);
            //printing the list in a single line
            Console.WriteLine(combined);
        }
    }
}
