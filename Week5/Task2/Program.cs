using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class MarkList
    {
        //создаем лист оценок(буквенных)
        public List<Marks> marks = new List<Marks>();
        //сериализация, десериализация
        public void Save(MarkList m)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            xs.Serialize(fs, m);
            fs.Close();
        }

        public void Show()
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            MarkList m = xs.Deserialize(fs) as MarkList;
            for (int i = 0; i < m.marks.Count; i++)
            {
                Console.WriteLine(m.marks[i]);
            }
        }
    }

    public class Marks
    {
        public double point;//баллы
        public Marks() { }//массив оценок

        public Marks(double point)
        {
            this.point = point;
        }

        public string getLetter()//массив буквенных обозначений
        {
            if (point >= 95 && point <=100) return "A";
            if (point >= 90 && point < 95) return "A-";
            if (point >= 85 && point < 90) return "B+";
            if (point >= 80 && point < 85) return "B";
            if (point >= 75 && point < 80) return "B-";
            if (point >= 70 && point < 75) return "C+";
            if (point >= 65 && point < 70) return "C";
            if (point >= 60 && point < 65) return "C-";
            if (point >= 55 && point < 60) return "D+";
            if (point >= 50 && point < 55) return "D";
            return "F";
        }

        public override string ToString()//метод вывода оценки
        {
            return "Mark is " + this.point + " " + this.getLetter();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //пишем оценки и добавляем в лист М
            Marks a = new Marks(67);
            Marks b = new Marks(89);
            Marks c = new Marks(94);

            MarkList M = new MarkList();
            M.marks.Add(a);
            M.marks.Add(b);
            M.marks.Add(c);
            //вызываем методы
            M.Save(M);
            M.Show();
            Console.ReadKey();

        }
    }
}
