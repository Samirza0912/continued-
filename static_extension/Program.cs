using System;
using static_extension.Models;

namespace static_extension
{
    class Program
    {
        enum UserChoice { ShowInfo = 1, CreateNewGroup, ShowAllGroups };
        enum StudentChoice { ShowAllAtudents = 1, GetStudentbyID, AddStudent, Quit };

        static void Main(string[] args)
        {
            Group[] groups = new Group[0];
            do
            {

                {
                    Console.WriteLine("Please write your Fullame: ");
                    string fullname1 = Console.ReadLine();
                    Console.WriteLine("Please write your Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Please write your Password: ");
                    string password = Console.ReadLine();

                    UserClass user1 = new UserClass(email, password);
                    user1.Fullname = fullname1;
                    user1.ShowInfo();
                    int type_count = int.Parse(Console.ReadLine());

                    Student[] students = new Student[type_count];
                    do
                    {
                        Console.WriteLine("\n1) Show user info");
                        Console.WriteLine("2) Create new group");
                        Console.WriteLine("3) Show All Groups and Students");
                        int result = int.Parse(Console.ReadLine());

                        switch (result)
                        {
                            case (int)UserChoice.ShowInfo:
                                user1.ShowInfo();
                                break;

                            case (int)UserChoice.CreateNewGroup:

                                Console.WriteLine("Please write the name of group: ");
                                string groupName = Console.ReadLine();
                                Console.WriteLine("Please enter the limit for the groupname: ");
                                int studentlimit = int.Parse(Console.ReadLine());
                                Group group1 = new Group(groupName, studentlimit);

                                if (group1.stufentlimit != 0 && group1.groupno != null)
                                {
                                    Array.Resize(ref groups, groups.Length + 1);
                                    groups[groups.Length - 1] = group1;
                                    Console.WriteLine("group1 has been created");
                                }
                                if (groups.Length > 0)
                                {
                                    int result2;
                                    do
                                    {
                                        Console.WriteLine("\n1) Show all students");
                                        Console.WriteLine("\n2) Get student by id");
                                        Console.WriteLine("\n3) Add student");
                                        Console.WriteLine("\n0) Back to Main Menu");

                                        result2 = int.Parse(Console.ReadLine());
                                        switch (result2)
                                        {
                                            case (int)StudentChoice.ShowAllAtudents:
                                                group1.GetAllStudents();
                                                break;

                                            case (int)StudentChoice.GetStudentbyID:

                                                Console.Write("Please enter the student ID: ");
                                                int id = int.Parse(Console.ReadLine());
                                                group1.GetStudent(id);
                                                break;

                                            case (int)StudentChoice.AddStudent:


                                                Console.Write("Enter student surname: ");
                                                string studentfullname = Console.ReadLine();
                                                Console.Write("Enter the point: ");
                                                int point = int.Parse(Console.ReadLine());
                                                Student student1 = new Student(studentfullname, point);
                                                group1.AddStudent(student1);
                                                break;

                                            case (int)StudentChoice.Quit:
                                                break;

                                        }
                                    } while (result2 != 0);
                                }
                                break;

                            case (int)UserChoice.ShowAllGroups:

                                if (groups.Length > 0)
                                {
                                    foreach (Group groups1 in groups)
                                    {
                                        Console.WriteLine(groups);
                                        groups1.GetAllStudents();
                                    }

                                }
                                else
                                {

                                    Console.WriteLine("invalid");

                                }
                                break;
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.Escape);

                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);



        }   
    }
}
    

