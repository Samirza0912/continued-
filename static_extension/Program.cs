using System;
using static_extension.Models;

namespace static_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                        int p = Check("Menu Bar\n1-Show info\n2-create new group\n0-end program");
                        if (p == 1)
                        {
                            foreach (var item in students)
                            {
                                item.ShowInfo();

                                Console.WriteLine("++++++++++++++++++++++");
                            }
                        }
                        else if (p == 2)
                        {
                    
                        }
                        else if (p == 0)
                        {
                            return;
                        }

                    } while (true);


                    static int Check(string name)
                    {
                        int n;

                        do
                        {
                            Console.Write(name);
                            n = int.Parse(Console.ReadLine());

                        } while (n > 2 || n < 0);
                        return n;
                    }
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            




        }
    }
}
