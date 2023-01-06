// Anonymous Type
var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

// Access Anonymous Type
var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
Console.WriteLine(student.Id); //output: 1
Console.WriteLine(student.FirstName); //output: James
Console.WriteLine(student.LastName); //output: Bond

student.Id = 2; //Error: cannot chage value
student.FirstName = "Steve"; //Error: cannot chage value

// Nested Anonymous Type
var student = new
{
    Id = 1,
    FirstName = "James",
    LastName = "Bond",
    Address = new { Id = 1, City = "London", Country = "UK" }
};

// Array of Anonymous Types
var students = new[]
{
    new { Id = 1, FirstName = "James", LastName = "Bond" },
    new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
    new { Id = 3, FirstName = "Bill", LastName = "Gates" }
};

// LINQ Query returns an Anonymous Type
class Program
{
    static void Main(string[] args)
    {
        IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 } 
        };

        var students = from s in studentList
                       select new { Id = s.StudentID, Name = s.StudentName };

        foreach(var stud in students)
            Console.WriteLine(stud.Id + "-" + stud.Name);
    }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int age { get; set; }
}

// Internal Name of an Anonymous Type
static void Main(string[] args)
{
    var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
    Console.WriteLine(student.GetType().ToString());
}

