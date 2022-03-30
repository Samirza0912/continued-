using System;
namespace static_extension.Models
{
    public class Student:UserClass
    {



        public int Point;
        public int point { get; set; }

        public Student(string fullname, int point)
        {   
            Point = point;
            Fullname = fullname;
        }

        public Student()
        {
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{Id} {Fullname} {Point}");
        }
    }
}
