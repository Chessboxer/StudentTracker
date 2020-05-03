﻿using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program 
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> studentGrades = CreateStudentDictionary();
            PrintStudentDictionary(studentGrades);
        }

        static Dictionary<String, int> CreateStudentDictionary()
        {
            var student = new Student();

            Dictionary<String, int> nameAndGrade = new Dictionary<string, int>();
            Console.WriteLine("How many students are there?");
            int numberOfStudents = 0;
            numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++) {
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
    class Student {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;
    }
}