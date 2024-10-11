List<Student> students = new List<Student>
{
new Student { StudentId = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
new Student { StudentId = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
new Student { StudentId = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};


List<Course> courses = new List<Course>
{
new Course { CourseId = 101, Title = "Mathematics", Credits = 4 },
new Course { CourseId = 102, Title = "Computer Science", Credits = 3 },
new Course { CourseId = 103, Title = "Physics", Credits = 4 }
};


List<Enrollment> enrollments = new List<Enrollment>
{
new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
new Enrollment { EnrollmentId = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
new Enrollment { EnrollmentId = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};

//Task #1
// var a = from s in students
// join e in enrollments on s.StudentId equals e.StudentId
// where e.CourseId==101
// select s;
// foreach(var i in a)
// {
//     System.Console.WriteLine(i.Name);
// }

//Task #2
// var charlieCourses = from course in courses join enrollment in enrollments on course.CourseId equals enrollment.CourseId where enrollment.StudentId==3 select course;
// var charlieCourses = enrollments.Where(enrollment=>enrollment.StudentId==3).Join(courses, enrollment=>enrollment.CourseId, course=>course.CourseId, (enrollment, course)=>course);
// foreach(var i in charlieCourses)
// {
//     System.Console.WriteLine(i.Title);
// }

//Task #3
// var studentsWithMultipleEnrollments = from student in students
//                                         let enrollmentCount = (from enrollment in enrollments
//                                         where enrollment.StudentId == student.StudentId
//                                         select enrollment).Count()
//                                         where enrollmentCount > 1
//                                         select student;
// foreach(var i in studentsWithMultipleEnrollments)
// {
//     System.Console.WriteLine(i.Name);
// }

//Task #5
// DateTime filteringDate = new DateTime(2020, 1, 20);
// int filteringCredits = 3;

// var result = from enrollment in enrollments 
//             join course in courses on enrollment.CourseId equals course.CourseId
//             join student in students on enrollment.StudentId equals student.StudentId
//             where enrollment.EnrollmentDate>=filteringDate
//             && course.Credits>filteringCredits
//             select new 
//             {
//                 Student = student.Name,
//                 Course = course.Title,
//                 EnrollmentDate = enrollment.EnrollmentDate,
//                 Credits = course.Credits
//             };
// foreach (var item in result)
// {
//     Console.WriteLine($"Student: {item.Student}, Course: {item.Course}, EnrollmentDate: {item.EnrollmentDate}, Credits: {item.Credits}");
// }

//Task #6
// var studentCredits = from enrollment in enrollments
//                     join student in students on enrollment.StudentId equals student.StudentId
//                     join course in courses on enrollment.CourseId equals course.CourseId
//                     group course by student.Name into newGroup
//                     select new 
//                     {
//                         StudentName = newGroup.Key,
//                         TotalCredits = newGroup.Sum(c=>c.Credits)
//                     };
// foreach (var student in studentCredits)
// {
//     Console.WriteLine($"StudentName: {student.StudentName}, TotalCredits: {student.TotalCredits}");
// }

//Task #7
// var studentCountForEachCourse = from enrollment in enrollments
//                                 join course in courses on enrollment.CourseId equals course.CourseId
//                                 group enrollment by course.Title into newGroup
//                                 select new
//                                 {
//                                     Course = newGroup.Key,
//                                     StudentCount = newGroup.Count()
//                                 };
// foreach (var course in studentCountForEachCourse)
// {
//     Console.WriteLine($"Course: {course.Course}, StudentCount: {course.StudentCount}");
// 