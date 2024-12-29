using System;
using System.Collections.Generic;

namespace GpaCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var courseService = new CourseService();
            var studentService = new StudentService();
            var dataStore = new DataStore();
            string? choice = "";
            do
            {
                Console.WriteLine("Please enter your course code");
                string? courseName = Console.ReadLine();
                Console.WriteLine($"Enter {courseName} course unit");
                int courseUnit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ($"Enter {courseName} course score");
                int courseScore = Convert.ToInt32(Console.ReadLine());
                
                Course course = courseService.CreateCourse(courseName, courseUnit, courseScore);
                dataStore.courses.Add(course);

                Console.WriteLine ("");
                Console.WriteLine("Calculate GPA? Y/N. Enter N to continue entering courses.");
                choice = Console.ReadLine(). ToUpper();
            }while(choice != "Y");
            Student student = studentService.CalculateTotal(dataStore.courses);
            PrintTable.Print(dataStore.courses);

            Console.WriteLine($"Total Course Unit Registered is {student.tcuRegistered}");
            Console.WriteLine($"Total Course Unit Pased is {student.tcuPassed}");
            Console.WriteLine($"Total Weight Point is {student.totalWeightPoint}");
            Console.WriteLine($"Your GPA is = {studentService.CalculateGpa(student.totalWeightPoint, student.tcuRegistered)}");

        }
    }
}