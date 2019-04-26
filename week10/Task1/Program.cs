using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    class Program
    {
        public class Employe
        {
            private string name;
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            private int id;
            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }
            private int salary;
            public int Salary
            {
                get
                {
                    return this.salary;
                }
                set
                {
                    this.salary = value;
                }
            }
            public void Increase(int salary)
            {
                this.salary = this.salary + 50000;
            }
            public override string ToString()
            {
                return name + " " + id + " " + salary;
            }
            public Employe()
            {

            }

        }

        static void Main(string[] args)
        {
            Employe e1 = new Employe();
            e1.Name = "AAAA";
            e1.Id = 1;
            e1.Salary = 50000;
            e1.Increase(e1.Salary);
            e1.Increase(e1.Salary);
            Ser(e1);
            Des();
        }
        static void Ser(Employe e1)
        {
            FileStream fs = new FileStream("employe.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            xs.Serialize(fs, e1);
            fs.Close();
        }
        static void Des()
        {
            FileStream fs = new FileStream("employe.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            Employe e1des = xs.Deserialize(fs) as Employe;
            fs.Close();
            Console.WriteLine(e1des);
        }
    }

}
