using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class Complex
    {
        //[XmlIgnore]
        public int real;
        public int imaginary;
        public Complex() { }

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            return (string.Format("{0}+{1}i", real, imaginary));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Complex c = new Complex(a, b);
            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, c);
            fs.Close();

            FileStream fs1 = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs1 = new XmlSerializer(typeof(Complex));
            Complex c1 = xs1.Deserialize(fs1) as Complex;
            Console.WriteLine(c1);
            fs1.Close();
            Console.ReadKey();
        }
    }
}
