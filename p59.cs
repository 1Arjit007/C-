// Object Initializer Syntax
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student()
        {
            StudentID = 1,
            StudentName = "Bill",
            Age = 20,
            Address = "New York"
        };
    }
}

// Object Initializer Syntax at Compile time
Student __student = new Student();
__student.StudentID = 1;
__student.StudentName = "Bill";
__student.Age = 20;
__student.StandardID = 10;
__student.Address = "Test";

Student std = __student;

// Object initializer Syntax
var student1 = new Student() { StudentID = 1, StudentName = "John" };
var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
var student3 = new Student() { StudentID = 3, StudentName = "Bill" } ;
var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

IList<Student> studentList = new List<Student>() { 
                                                    student1, 
                                                    student2, 
                                                    student3, 
                                                    student4, 
                                                    student5 
                                                };

// Collection initializer Syntax
IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John"} ,
                    new Student() { StudentID = 2, StudentName = "Steve"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 4, StudentName = "Ram" } ,
                    new Student() { StudentID = 5, StudentName = "Ron" } 
                };

// Collection initializer Syntax
IList<Student> studentList = new List<Student>() { 
                                    new Student() { StudentID = 1, StudentName = "John"} ,
                                    null
                                };