using System;
using System.Collections.Generic;

namespace GpaCalculator;

public class PrintTable
{

    public static void Print(List<Course> courses)
    {
        Dash("-");
        Console.WriteLine();
        Console.WriteLine(format: "{0, -20} | {1, -15} | {2, -5} | {3, -10} | {4, -9} | {5, -10}", "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
        Dash("-");
        Console.WriteLine();
        foreach (Course course in courses)
        {
            Console.WriteLine(format: "{0, -20} | {1, -15} | {2, -5} | {3, -10} | {4, -9} | {5, -10}", course.courseName, course.courseUnit, course.grade, course.gradeUnit, course.weightPoint, course.remark);
        }
        Dash("-");
        Console.WriteLine();
    }

    public static void Dash(string dash)
    {
        for (int i = 0; i < 83; i++)
        {
            Console.Write(dash);
        }
    }
}