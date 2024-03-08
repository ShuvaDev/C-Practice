using TestProject;

StudentDbContext sc = new StudentDbContext();



// For Student 1
Student s1 = new Student();
s1.Name = "Shuva Dev";

CourseEnrollment ce1 = new CourseEnrollment();
Course c1 = new Course { Name = "Professional C#" };
ce1.Course = c1;

CourseEnrollment ce2 = new CourseEnrollment();
Course c2 = new Course { Name = "ASP.Net Core MVC" };
ce2.Course = c2;

CourseEnrollment ce3 = new CourseEnrollment();
Course c3 = new Course { Name = "Javascript" };
ce3.Course = c3;

if (s1.CourseEnrollments == null) s1.CourseEnrollments = new();
s1.CourseEnrollments.AddRange([ce1, ce2]);

// For Student 2
Student s2 = new Student();
s2.Name = "Joyel Rana";

if (s2.CourseEnrollments == null) s2.CourseEnrollments = new();
s2.CourseEnrollments.AddRange([ce1, ce2, ce3]);

sc.Students.AddRange(s1, s2);
sc.SaveChanges();


