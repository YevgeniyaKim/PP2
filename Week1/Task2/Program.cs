using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //create a class
    class Student
    {
        //create new public variables
        public string name, id;
        public int year=0;
        //create a constructor
        public Student(string n, string i)
        {
            name = n;
            id = i;
        }
        //describe the behaviour of the constructor
        public void PrintInfo()
        {
            Console.WriteLine("Name of student: " + name);
            Console.WriteLine("ID of student: " + id);
        }
        //describe the behaviour of variable "year"
        public void inc()
        {
            year++;
            Console.WriteLine("Year of student now is: " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create a new student with some data
            Student s1 = new Student("Yevgeniya", "18BD110606");
            //use the behaviour from the class and print all information
            s1.PrintInfo();
            s1.inc();
        }
    }
}
