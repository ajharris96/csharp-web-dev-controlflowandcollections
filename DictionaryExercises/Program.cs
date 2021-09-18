using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID: ");
                    input = Console.ReadLine();
                    int idNumber = int.Parse(input);
                    students.Add(idNumber, newStudent);

                   
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + " (" + student.Key + ")");
               
            }

           
        }
    }
}
