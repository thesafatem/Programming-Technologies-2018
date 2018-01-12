using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2tasktwo
{
    class Student
    {
        public string firstname;
        public string lastname;
        public double gpa;
        public Student()
        {
            firstname = "KBTU";
            lastname = "FIT";
            gpa = 0;
        }
        public Student(string a, string b, double c)
        {
            firstname = a;
            lastname = b;
            gpa = c;
        }
        public override string ToString()
        {
            return firstname + " " + lastname + " " + gpa; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
            Student q = new Student("Liam", "Terry", 3.5);
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
