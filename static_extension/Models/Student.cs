using System;
namespace static_extension.Models
{
    public class Student
    {
        private static int _id;
        public string FullName;
        public int Point;

        public int ID { get; }
        public string fullName { get; set; }
        public int point { get; set; }

        public Student(string fullname, int point)
        {   
            Point = point;
            FullName = fullname;
            _id++;
            ID = _id;
        }

        public override string ToString()
        {
            return StudentInfo();
        }

        public string StudentInfo()
        {
            return ($"{ID} {FullName} {Point}");
        }
    }
}
