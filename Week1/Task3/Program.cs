using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading first line of an input, converting it into an int 
            int n = int.Parse(Console.ReadLine());
            //creating an array of size n numbers
            int[] arr = new int[n];
            //reading second line of an input and separating it
            string[] nums = Console.ReadLine().Split();
            //create a cycle
            for (int i=0; i<n; i++)
            {
                //adding numbers to an array
                arr[i] = int.Parse(nums[i]);
                //printing every element twice
                Console.Write(arr[i] + " " + arr[i] + " ");
            }
        }
    }
}
