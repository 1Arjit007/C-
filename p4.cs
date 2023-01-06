// Namespace
namespace School
{
    // define classes here

}

// Namespace
namespace School
{
    class Student
    {

    }

    class Course
    {

    }
}

// Refer a Class with Namespace
namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            School.Student std = new School.Student();
        
            School.Course cs = new School.Course();
        }
    }
}

// Namespace
using System; //built-in namespace
using School;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
        }
    }
}

// Namespace
namespace School.Education
{
    class Student
    {

    }
}

// C# 10 Namespace
namespace School.Education
    
class Student
{

}