using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program 
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;
            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student name: ");
                newStudent.Name = Console.ReadLine();
                
                Console.Write("{0}'s grade: ", newStudent.Name);
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("{0}'s Birthday: ", newStudent.Name);
                newStudent.Birthday = Console.ReadLine();

                Console.Write("{0}'s Address: ", newStudent.Name);
                newStudent.Address = Console.ReadLine();

                Console.Write("{0}'s Phone Number: ", newStudent.Name);
                newStudent.Phone = int.Parse(Console.ReadLine()); 

                students.Add(newStudent);
                Console.Write("Add another? y/n ");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}     | Grade: {1}", student.Name, student.Grade);
            }
        }
    }

    class Student {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public int Phone { 
            set { phone = value; }
        }


    }
}