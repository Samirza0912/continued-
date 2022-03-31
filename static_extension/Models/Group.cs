using System;
namespace static_extension.Models
{
    public class Group
    {
        private string _groupNo;
        private int _studentLimit;
        private Student[] students;


        public string groupno
        {
            get { return _groupNo; }
            set
            {
                if (CheckGroupNo(value)==true)
                {
                    _groupNo = value;
                    return;
                }
                Console.WriteLine("The group number must begit with 2 upper symbols and must contain 3 numbers");
            }
        }
        public int stufentlimit
        {
            get { return _studentLimit; }
            set
            {
                if (value<5 && value>18)
                {
                    Console.WriteLine("limit should be between 5-18");
                    return;
                }
            }
        }
        public Group(string groupno, int studentlimit)
        {
            _groupNo = groupno;
            _studentLimit = studentlimit;
            students = new Student[0];
        }
        public bool CheckGroupNo(string no)
        {
            bool result1 = false;
            bool result2 = false;
            bool result3 = false;
            

            for (int i = 0; i < no.Length; i++)
            {
                if (char.IsUpper(no[0]) == true)
                {
                    result1 = true;
                }
                if (char.IsUpper(no[1]) == true)
                {
                    result2 = true;
                }

            }
            for (int i = 2; i < no.Length; i++)
            {
                if (char.IsNumber(groupno[i]))
                {
                    result3 = true;
                }
            }
            bool result4 = result1 && result2 && result3;
            return result4;
        }
        public void AddStudent(Student stud)
        {
            if (students.Length<_studentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = stud;
                Console.WriteLine($"{stud.FullName} added to: {groupno}");
                return;
            }

        }
        public void GetStudent(int? id)
        {
            bool IsExist = false;
            foreach (Student stud in students )
            {
                if (id == stud.ID)
                {
                    Console.WriteLine(stud);
                    IsExist = true;
                    return;
                }
            }
        }
        public void GetAllStudents()
        {
            foreach (Student stud in students)
            {
                Console.WriteLine(stud);
            }
        }


    }

}
