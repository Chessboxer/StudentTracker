using System;
using System.Collections.Generic;

namespace StudentTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT

    }
    class Program 
    {
        static List<Student> Students = new List<Student>();
        

        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            payroll.PayAll();

            var adding = true;
            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = util.Console.Ask("Student name: ");

                    newStudent.Grade = util.Console.AskInt(newStudent.Name + "'s Grade: ");

                    newStudent.School = (School) util.Console.AskInt("Enter school corresponding school: \n 0 - Hogwarts \n 1 - Harvard \n 2 - MIT \n");

                    newStudent.Birthday = util.Console.Ask(newStudent.Name + "'s Birthday: ");

                    newStudent.Address = util.Console.Ask(newStudent.Name + "'s Address: ");

                    newStudent.Phone = util.Console.AskInt(newStudent.Name + "'s Phone Number: ");

                    Students.Add(newStudent);
                    Student.Count++;

                    Console.WriteLine("Student Count:  {0}", Student.Count);
                    

                    Console.Write("Add another? y/n ");

                    if (Console.ReadLine() != "y") {
                        adding = false;
                    }
                }

                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }

                catch (Exception)
                {
                    Console.WriteLine("Error adding student, please try again");
                }
                
                ShowGrade("Tom");

            }
            Exports();
            foreach (var student in Students)
            {
                Console.WriteLine("Name: {0}     | Grade: {1}", student.Name, student.Grade);       
            }
        }

        public static void Exports()
        {
            foreach (var student in Students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;  
                    default:
                        break;
                }
            }
        }

        static void ShowGrade(String name)
        {
            var found = Students.Find(student => student.Name == name);
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }

 
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

    }

    class Student : Member {
        public static int Count { get; set; } = 0;
        public int Grade { get; set; }
        public School School { get; set; }
        public string Birthday { get; set; }


        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday; 
            Address = address;
            Phone = phone; 
        }
    }

}