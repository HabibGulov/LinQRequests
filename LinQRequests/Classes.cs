using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
}

class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; } = null!;
    public int Credits { get; set; }
}

class Enrollment
{
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime EnrollmentDate { get; set; }
}
