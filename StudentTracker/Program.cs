using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program 
    {
        static List<Student> Students = new List<Student>();
        static void Main(string[] args)
        { 
            var adding = true;
            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = util.Console.Ask("Student name: ");

                    newStudent.Grade = util.Console.AskInt(newStudent.Name + "'s Grade: ");

                    newStudent.School = util.Console.AskInt("Enter school corresponding school: \n 0 - Hogwarts \n 1 - Harvard \n 2 - MIT \n");

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

            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}     | Grade: {1}", student.Name, student.Grade);       
            }
        }

        public void Exports()
        {
            foreach (var student in Students)
            {
                switch (student.School)
                {
                    case 0:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case 1:
                        Console.WriteLine("Exporting to MIT");
                        break;
                    case 2:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;
        public int Phone
        {
            set { phone = value; }
        }

    }

    class Student : Member {
        public static int Count = 0;
        public int Grade;
        public int School;
        public string Birthday;


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

    class Teacher : Member
    { 
        public string Subject;
    }
}