using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> studentGradebook = CreateStudentDictionary();
            PrintStudentDictionary(studentGradebook);
        }

        static Dictionary<String, int> CreateStudentDictionary()
        {
            Dictionary<String, int> nameAndGrade = new Dictionary<string, int>();
            Console.WriteLine("How many students are there?");
            int numberOfStudents = 0;
            numberOfStudents = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfStudents; i++) { 
                Console.Write("Please enter the name of student: ");
                string name = Console.ReadLine();
                // validate input
                Console.Write("Please {0}'s grade: ", name);
                int grade = int.Parse(Console.ReadLine());
                // validate input
                nameAndGrade.Add(name, grade);
            }
            return nameAndGrade;
        }

        bool ValidateAsInt()
        {

            return false;
        }

        static void PrintStudentDictionary(Dictionary<string, int> StudentDictionary)
        {
            foreach (var student in StudentDictionary)
            {
                Console.WriteLine("Name: {0}          Grade: {1}", student.Key, student.Value);
            }
        }

        void HardCodeList() {
            var studentGrades = new int[] { 80, 77, 45, 88, 91, 50, 66, 90, 103, 29 };
            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }

    }
}