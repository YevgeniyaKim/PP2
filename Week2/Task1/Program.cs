using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {

        public static bool Pal(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j]) return false;
            }
                return true;
        } 

        static void Main(string[] args)
        {
            //open the file at the specified path and read it
            FileStream fs = new FileStream(@"input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            //close the file
            sr.Close();
            fs.Close();
            //create an array of chars with the size of string s
            if (Pal(s)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
