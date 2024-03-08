using EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

TrainingDbContext dbContext = new();

/*
// ****** Insert Example ******
Course course = new();
course.Name = "C#";
course.Description = "Professional C#";
course.Fees = 8000;
course.IsActive = true;

dbContext.Courses.Add(course);
dbContext.SaveChanges();
*/

/*
// ****** Update Example ******
//List<Course> courses = dbContext.Courses.Where(x => x.Id == 1).ToList();
Course course = dbContext.Courses.Where(x => x.Id == 1).FirstOrDefault();
course.Description = "Professional Programming With C#";

dbContext.SaveChanges();
*/

/*
// ****** Delete Example ****** 
Course? course = dbContext.Courses.Where(x => x.Id == 1).FirstOrDefault();
if(course != null)
{
    dbContext.Courses.Remove(course);
}
dbContext.SaveChanges();
*/

/*
// ****** Select Example ******
List<Course> allCourses = dbContext.Courses.ToList();
// List<Course> courses = dbContext.Courses.Where(x => x.Fees > 1000).ToList();
foreach(var course in allCourses)
{
    Console.WriteLine(course.Name);
    Console.WriteLine(course.Description);
}
*/


/*
// One to Many Relationshiop
// If we want to insert data through Course class 
Course c1 = new Course();
c1.Name = "C#";
c1.Description = "Professoinal C#";
c1.Fees = 2000;
c1.IsActive = true;
c1.Topics = new List<Topic>();

Topic t1 = new Topic { Title = "Getting Started", Duration = 2 };
Topic t2 = new Topic { Title = "Loop", Duration = 1 };
c1.Topics.AddRange([t1, t2]);

dbContext.Courses.Add(c1);
dbContext.SaveChanges();
*/

/* if we add public DbSet<Topic> Topics { get; set; } this property in DbContext then we will able to 
 * insert data through Topic Class */
/*
Topic t1 = new Topic { Title = "Getting Started", Duration = 2 };
Course c1 = new Course();
c1.Name = "C#";
c1.Description = "Professoinal C#";
c1.Fees = 2000;
c1.IsActive = true;
t1.Course = c1;

dbContext.Topics.Add(t1);
dbContext.SaveChanges();
*/


/*
// Fetch Course With Topics
Course? courseWithTopics = dbContext.Courses.Include(x => x.Topics).FirstOrDefault();
Console.WriteLine($"{courseWithTopics.Name}  {courseWithTopics.Description}");
Console.WriteLine("Topics - ");
Console.WriteLine(courseWithTopics.Topics[0].Title);
*/


// Many to Many RelationShip
// For Student 1


//Student s1 = new Student() { Name = "Shuva Dev", CGPA = 3.25 };
//s1.CourseEnrollments = new List<CourseEnrollment>();

//CourseEnrollment cs1 = new CourseEnrollment();
//Course c1 = new Course { Name = "C#", Description = "Professional C#", Fees = 8000, IsActive = true };
//cs1.Course = c1;

//CourseEnrollment cs2 = new CourseEnrollment();
//Course c2 = new Course { Name = "Asp.Net", Description = "Full Stack ASP.Net", Fees = 30000, IsActive = true };
//cs2.Course = c2;


//s1.CourseEnrollments.AddRange([cs1, cs2]);
//dbContext.Students.Add(s1);
//dbContext.SaveChanges();


// For Student 2
/*
Student s2 = new Student() { Name = "Mehadi Hasan", CGPA = 3.25 };
s2.CourseEnrollments = new List<CourseEnrollment>();


CourseEnrollment ce3 = new CourseEnrollment();
Course c3 = new Course { Name = "Javascript", Description = "Professional Javascript", Fees = 6000, IsActive = true };
ce3.Course = c3;

// Wrong approach
var s1 = dbContext.Students.Where(x => x.Id == 1)
    .Include(x => x.CourseEnrollments)
    .ThenInclude(y => y.Course)
    .Single();


foreach (var CourseEnrollment in s1.CourseEnrollments)
{
    s2.CourseEnrollments.Add(CourseEnrollment);
}

s2.CourseEnrollments.Add(ce3);

dbContext.Students.Add(s2);
dbContext.SaveChanges();
*/

// Fetch Data
/*
List<Student> students = dbContext.Students.Include(x => x.CourseStudents).ToList();


for (int i = 1; i <= students.Count; i++)
{
    Console.WriteLine($"Student {i} : ");
    Student student = students[i - 1];
    Console.WriteLine($"Name : {student.Name}");
    Console.WriteLine($"CGPA : {student.CGPA}");

    Console.WriteLine($"Enrolled Course of Student {i} : ");
    foreach (var CourseStudent in student.CourseStudents)
    {
        Course course = dbContext.Courses.Where(x => x.Id == CourseStudent.CourseId).Single();
        Console.WriteLine(course.Name);
    }
    Console.WriteLine();
}
*/