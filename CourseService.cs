using System;
namespace GpaCalculator;

public class CourseService
{
    GradeService gradeService = new GradeService();

    public Course CreateCourse(string? courseName, int courseUnit, int courseScore)
    {
        Course course = new Course();
        course.courseName = courseName;
        course.courseUnit = courseUnit;
        course.courseScore = courseScore;
       Grade grade = gradeService.AssignGrade(courseScore);
       course.remark = grade.remark;
       course.grade = grade.grade;
       course.gradeUnit = grade.gradeUnit;
       course.weightPoint = course.courseUnit * course.gradeUnit;


      return course; //dataStore.courses.Add(course);
    }
}