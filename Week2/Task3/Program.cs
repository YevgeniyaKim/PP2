using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static void PrintInfo(FileSystemInfo fsi, int k)
        {
            //create an empty string
            string line = new string(' ', k);
            //write a file's name
            line = line + fsi.Name;
            Console.WriteLine(line);
            //if fsi is folder, the we get info about file inside this folder
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();
                foreach(var i in items)
                {
                    PrintInfo(i, k + 4);
                }
            }

        }
        static void Main(string[] args)
        {
            //choose a folder
            DirectoryInfo di = new DirectoryInfo(@"C:\PP2\W2");
            PrintInfo(di, 1);
        }
    }
}
