using System;

namespace GpaCalculator;

public class StudentService
{
    public Student CalculateTotal(List<Course> courses)
    {
        Student result = new Student();

        foreach (var course in courses)
        {
            result.totalWeightPoint += course.weightPoint;
            result.tcuPassed += course.gradeUnit;
            result.tcuRegistered += course.courseUnit;
            
        }
        return result;
    }
    public double CalculateGpa(int totalWeightPoint, int tcuRegistered)
    {
        double gpa = (double)totalWeightPoint / (double)tcuRegistered;
        return gpa;
    }
    

}