using System;
namespace GpaCalculator;

public class GradeService
{
    public Grade AssignGrade(int courseScore)
    {
        var grade = new Grade();
        if (courseScore >= 0 && courseScore <= 39)
        {
            grade.grade = "F";
            grade.remark = "Fail";
            grade.gradeUnit = 0;


        }
        else if (courseScore >= 40 && courseScore <= 44)
        {
            grade.grade = "E";
            grade.remark = "Pass";
            grade.gradeUnit = 1;
        }
        else if (courseScore >= 45 && courseScore <= 49)
        {
            grade.grade = "D";
            grade.remark = "Fair";
            grade.gradeUnit = 2;
        }
        else if (courseScore >= 50 && courseScore <= 59)
        {
            grade.grade = "C";
            grade.remark = "Good";
            grade.gradeUnit = 3;
        }
        else if (courseScore >= 60 && courseScore <= 69)
        {
            grade.grade = "B";
            grade.remark = "Very Good";
            grade.gradeUnit = 4;
        }
        else if (courseScore >= 70 && courseScore <= 100)
        {
            grade.grade = "A";
            grade.remark = "Excellent";
            grade.gradeUnit = 5;
        }
        return grade;

    }
}