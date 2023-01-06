// Explicitly Typed Variable
int i = 100; // explicitly typed variable

// Implicitly Typed Local Variable
var j = 100; // implicitly typed local variable

// var from expression
int i = 10;
var j = i + 1; // compiles as int

// Implicitly-Typed Variable
static void Main(string[] args)
{
    var i = 10;
    Console.WriteLine("Type of i is {0}", i.GetType());

    var str = "Hello World!!";
    Console.WriteLine("Type of str is {0}", str.GetType());

    var dbl = 100.50d;
    Console.WriteLine("Type of dbl is {0}", dbl.GetType());

    var isValid = true;
    Console.WriteLine("Type of isValid is {0}", isValid.GetType());

    var ano = new { name = "Steve" };
    Console.WriteLine("Type of ano is {0}", ano.GetType());

    var arr = new[] { 1, 10, 20, 30 };
    Console.WriteLine("Type of arr is {0}", arr.GetType());

    var file = new FileInfo("MyFile");
    Console.WriteLine("Type of file is {0}", file.GetType());
}

// Implicitly-typed variables must be initialized
var i; // Compile-time error: Implicitly-typed variables must be initialized
i = 100;

// Multiple declarations of var variables in a single statement are not allowed
var i = 100,
    j = 200,
    k = 300; // Error: cannot declare var variables in a single statement

//The followings are also valid
var i = 100;
var j = 200;
var k = 300;

// var cannot be used for function parameters
void Display(var param) //Compile-time error
{
    Console.Write(param);
}

// var can be used in for, and foreach loops
for(var i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// LINQ Query Syntax in C#
// string collection
IList<string> stringList = new List<string>() { 
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" 
};

// LINQ Query Syntax
var result = from s in stringList
            where s.Contains("Tutorials") 
            select s;
