// C# Static Class
public static class Calculator
{
    private static int _resultStorage = 0;
    
    public static string Type = "Arithmetic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Store(int result)
    {
        _resultStorage = result;
    }
}

// Accessing Static Members
class Program
{
    static void Main(string[] args)
    {
        var result = Calculator.Sum(10, 25); // calling static method
        Calculator.Store(result); 

        var calcType = Calculator.Type; // accessing static variable
        Calculator.Type = "Scientific"; // assign value to static variable
    }
}

// Shared Static Fields
public class StopWatch
{
    public static int NoOfInstances = 0;
    
    // instance constructor
    public StopWatch()
    {
        StopWatch.NoOfInstances++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StopWatch sw1 = new StopWatch();
        StopWatch sw2 = new StopWatch();
        Console.WriteLine(StopWatch.NoOfInstances); //2 
			
        StopWatch sw3 = new StopWatch();
        StopWatch sw4 = new StopWatch();
        Console.WriteLine(StopWatch.NoOfInstances);//4
    }
}

// Static Method
class Program
{
    static int counter = 0;
    string name = "Demo Program";

    static void Main(string[] args)
    {
        counter++; // can access static fields
        Display("Hello World!"); // can call static methods

        name = "New Demo Program"; //Error: cannot access non-static members
        SetRootFolder("C:\MyProgram"); //Error: cannot call non-static method
    }

    static void Display(string text)
    {
        Console.WriteLine(text);
    }

    public void SetRootFolder(string path) {  }
}

// Static Constructor vs Instance Constructor
public class StopWatch
{
    // static constructor
    static StopWatch()
    {
        Console.WriteLine("Static constructor called");
    }

    // instance constructor
    public StopWatch()
    {
        Console.WriteLine("Instance constructor called");
    }

    // static method
    public static void DisplayInfo()
    {
        Console.WriteLine("DisplayInfo called");
    }

    // instance method
    public void Start() { }

    // instance method
    public void Stop() {  }
}

// Static Constructor Execution
StopWatch.DisplayInfo(); // static constructor called here
StopWatch.DisplayInfo(); // none of the constructors called here

// Static Constructor Execution
StopWatch sw1 = new StopWatch(); // First static constructor and then instance constructor called 
StopWatch sw2 = new StopWatch();// only instance constructor called 
StopWatch.DisplayInfo();

