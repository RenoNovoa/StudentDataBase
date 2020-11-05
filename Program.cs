using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml;

namespace StudentDataBase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our C# class!");
            Console.WriteLine("-------------------------");

            student student1 = new student() { Code = "1", Name = "Anthony", HomeTown = "Detroit", FavoriteFood = "Tacos" };
            student student2 = new student() { Code = "2", Name = "Bayron", HomeTown = "CostaRica", FavoriteFood = "Pizza" };
            student student3 = new student() { Code = "3", Name = "Camila", HomeTown = "Panama", FavoriteFood = "Sandwish" };
            student student4 = new student() { Code = "4", Name = "Donthe", HomeTown = "Colombia", FavoriteFood = "HotDog" };
            student student5 = new student() { Code = "5", Name = "Ememly", HomeTown = "Nicaragua", FavoriteFood = "Arepas" };


            List<student> liststudents = new List<student>();
            liststudents.Add(student1);
            liststudents.Add(student2);
            liststudents.Add(student3);
            liststudents.Add(student4);
            liststudents.Add(student5);

            do
            {
                try
                {
                    Console.Write("which student would you like to learn about? \n Enter a number (1 - 5):");
                    string strStudenCode = Console.ReadLine();


                    student resultStudent = liststudents.Find(student => student.Code == strStudenCode);

                    if (resultStudent == null)
                    {
                        Console.WriteLine("That student does not exist.Please try again.");
                    }
                    else
                    {
                        Console.WriteLine(" Student  {0}, is {1} ", resultStudent.Code, resultStudent.Name);
                    }
                    Console.WriteLine("Do you want to coontinu(Y/N)");
                    string response = Console.ReadLine();
                    if (response == "N")
                    {
                        break;
                    }
                    //else
                    //{
         
                    Console.WriteLine($"Student {strStudenCode} is {resultStudent.Name} What woul you like to know about {resultStudent.Name}? \n(enter HomeTown/FavoriteFood) ");
                        string seconChoice = Console.ReadLine();
                    if (seconChoice == null)
                    {
                        Console.WriteLine($"{resultStudent.Name} is from { resultStudent.HomeTown}.  Would you like to know more? (Enter Y/N)");
                        string knowMore = Console.ReadLine();
                        if (knowMore == "N")
                        {
                            break;
                        }
                    }
                    //}

                }
                catch (FormatException)
                 {
                    Console.WriteLine("Enter a number ");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number of student don't exist!");
                }
            } while (true);

           

        }

        public class student
        {
            public string Code { get; set; }
            public string  Name { get; set; }
            public string HomeTown { get; set; }
            public string FavoriteFood { get; set; }
        }
        
    }
}
