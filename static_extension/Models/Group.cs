using System;
namespace static_extension.Models
{
    public class Group
    {
        public int GroupNo;
        public int StudentLimit;
        private Student[] students = new Student[0];

        public int stufentlimit
        {
            get { return StudentLimit; }
            set
            {
                if (value<5 && value>18)
                {
                    Console.WriteLine("limit should be between 5-18");
                    return;
                }
            }
        }


    }
}
