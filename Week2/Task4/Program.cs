using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new file1
            FileStream fs = new FileStream(@"C:\PP2\W2\Week2\Task4\create.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter wr = new StreamWriter(fs);
            
            string line = "Ich auch";
            //write the string line in a file1
            wr.WriteLine(line);
            //close the file
            wr.Close();
            fs.Close();
            //copy file from the path, where exist file1 to file2
            File.Copy(@"C:\PP2\W2\Week2\Task4\create.txt", @"C:\PP2\W2\Week2\Task4\copy.txt");
            //delete file1
            File.Delete(@"C:\PP2\W2\Week2\Task4\create.txt");
        }
    }
}
