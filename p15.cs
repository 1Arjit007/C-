// dynamic Variable
dynamic MyDynamicVar = 1;

// dynamic Type at run-time
dynamic MyDynamicVar = 1;

Console.WriteLine(MyDynamicVar.GetType());

// dynamic
static void Main(string[] args)
{
    dynamic MyDynamicVar = 100;
    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

    MyDynamicVar = "Hello World!!";
    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

    MyDynamicVar = true;
    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

    MyDynamicVar = DateTime.Now;
    Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
}

// dynamic Type Conversion
dynamic d1 = 100;
int i = d1;
		
d1 = "Hello";
string greet = d1;
		
d1 = DateTime.Now;
DateTime dt = d1;

// Calling Methods
class Program
{
    static void Main(string[] args)
    {
        dynamic stud = new Student();

        stud.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
        stud.DisplayStudentInfo("1");// run-time error, no compile-time error
        stud.FakeMethod();// run-time error, no compile-time error
    }
}

public class Student
{
    public void DisplayStudentInfo(int id)
    {
    }
}

