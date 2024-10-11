List<Student> students = new List<Student>
{
    new Student { Id = 1, FirstName = "John", LastName = "Joe", Age = 25, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddYears(1) },
    new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 30, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddYears(-2), DateOfFinish = DateTime.Now.AddMonths(6) },
    new Student { Id = 3, FirstName = "Mike", LastName = "Johnson", Age = 22, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-3), DateOfFinish = DateTime.Now.AddMonths(3) },
    new Student { Id = 4, FirstName = "Emily", LastName = "Brown", Age = 28, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddMonths(-10), DateOfFinish = DateTime.Now.AddYears(2) },
    new Student { Id = 5, FirstName = "Chris", LastName = "Davis", Age = 35, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-4), DateOfFinish = DateTime.Now.AddMonths(4) },
    new Student { Id = 6, FirstName = "Anna", LastName = "Miller", Age = 27, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddMonths(2) },
    new Student { Id = 7, FirstName = "Tom", LastName = "Wilson", Age = 33, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-2), DateOfFinish = DateTime.Now.AddYears(1) },
    new Student { Id = 8, FirstName = "Sara", LastName = "Moore", Age = 24, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddMonths(-7), DateOfFinish = DateTime.Now.AddMonths(5) },
    new Student { Id = 9, FirstName = "David", LastName = "Taylor", Age = 31, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-5), DateOfFinish = DateTime.Now.AddYears(2) },
    new Student { Id = 10, FirstName = "Lucy", LastName = "Anderson", Age = 29, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddYears(-6), DateOfFinish = DateTime.Now.AddMonths(8) },
    new Student { Id = 11, FirstName = "Peter", LastName = "Thomas", Age = 23, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddYears(3) },
    new Student { Id = 12, FirstName = "Megan", LastName = "Jackson", Age = 26, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddMonths(-5), DateOfFinish = DateTime.Now.AddMonths(7) },
    new Student { Id = 13, FirstName = "James", LastName = "White", Age = 34, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-4), DateOfFinish = DateTime.Now.AddMonths(9) },
    new Student { Id = 14, FirstName = "Kate", LastName = "Harris", Age = 32, Gender = "Female", Status = "InActive", DateOfStart = DateTime.Now.AddYears(-3), DateOfFinish = DateTime.Now.AddYears(1) },
    new Student { Id = 15, FirstName = "Alex", LastName = "Martin", Age = 30, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-2), DateOfFinish = DateTime.Now.AddMonths(3) },
    new Student { Id = 16, FirstName = "Brian", LastName = "Green", Age = 29, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddYears(1) },
    new Student { Id = 17, FirstName = "Sophia", LastName = "Lee", Age = 26, Gender = "Female", Status = "Active", DateOfStart = DateTime.Now.AddMonths(-3), DateOfFinish = DateTime.Now.AddYears(2) },
    new Student { Id = 18, FirstName = "Daniel", LastName = "Walker", Age = 21, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-2), DateOfFinish = DateTime.Now.AddMonths(4) },
    new Student { Id = 19, FirstName = "Olivia", LastName = "Young", Age = 27, Gender = "Female", Status = "Active", DateOfStart = DateTime.Now.AddMonths(-6), DateOfFinish = DateTime.Now.AddYears(1) },
    new Student { Id = 20, FirstName = "Matthew", LastName = "King", Age = 32, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddMonths(8) },
    new Student { Id = 21, FirstName = "Chloe", LastName = "Wright", Age = 24, Gender = "Female", Status = "Active", DateOfStart = DateTime.Now.AddMonths(-2), DateOfFinish = DateTime.Now.AddYears(2) },
    new Student { Id = 22, FirstName = "Andrew", LastName = "Scott", Age = 30, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddYears(-3), DateOfFinish = DateTime.Now.AddMonths(6) },
    new Student { Id = 23, FirstName = "Isabella", LastName = "Adams", Age = 29, Gender = "Female", Status = "Active", DateOfStart = DateTime.Now.AddYears(-1), DateOfFinish = DateTime.Now.AddMonths(9) },
    new Student { Id = 24, FirstName = "Ryan", LastName = "Baker", Age = 28, Gender = "Male", Status = "Active", DateOfStart = DateTime.Now.AddMonths(-4), DateOfFinish = DateTime.Now.AddYears(3) },
    new Student { Id = 25, FirstName = "Ava", LastName = "Gonzalez", Age = 26, Gender = "Female", Status = "Active", DateOfStart = DateTime.Now.AddYears(-2), DateOfFinish = DateTime.Now.AddMonths(5) }
};


#region Task #1
// IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
// IEnumerable<Student> maleStudents = students.Where(student=>student.Gender=="Male");
// foreach (Student student in maleStudents)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #2
// IEnumerable<Student> activeStudents = from std in students where std.Status == "Active" select std;
// IEnumerable<Student> activeStudents = students.Where(std=>std.Status=="Active" && std.Gender=="Male");
// foreach (Student student in activeStudents)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #3
// IEnumerable<Student> list = students.Where(std=>DateTime.Now.Year-std.Age>2002);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #4
// IEnumerable<Student> list = students.Where(std=>std.Age>20 && std.DateOfFinish>DateTime.Now);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #5
// IEnumerable<Student> list = students.Where(std=>std.DateOfStart.Year-(DateTime.Now.Year-std.Age)==24);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #6
// IEnumerable<Student> list = students.Where(std=>std.DateOfStart.Year-(DateTime.Now.Year-std.Age)>=18);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #7
// IEnumerable<Student> list = students.Where(std=>std.FirstName.StartsWith("A") || std.FirstName.StartsWith("I"));
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #8
// IEnumerable<Student> list = students.Where(std=>std.FirstName[0]==std.LastName[0]);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #9
// IEnumerable<Student> list = students.Where(std=>std.Age+(std.DateOfFinish.Year-std.DateOfStart.Year)>=18);
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion

#region Task #10
// IEnumerable<Student> list = students.Where(std=>std.Gender!="Female" && DateTime.Now.Year-std.DateOfStart.Year>2 && std.Status=="Active");
// foreach (Student student in list)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, Gender: {student.Gender}, Status: {student.Status}, Start: {student.DateOfStart.ToShortDateString()}, Finish: {student.DateOfFinish.ToShortDateString()}");
// }
#endregion