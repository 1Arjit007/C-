// Nullable type
Nullable<int> i = null;

// Nullable struct
[Serializable]
public struct Nullable<T> where T : struct
{        
    public bool HasValue { get; }
      
    public T Value { get; }
        
    // other implementation
}

// HasValue
static void Main(string[] args)
{
    Nullable<int> i = null;

    if (i.HasValue)
        Console.WriteLine(i.Value); // or Console.WriteLine(i)
    else
        Console.WriteLine("Null");
}

// GetValueOrDefault()
static void Main(string[] args)
{
    Nullable<int> i = null;

    Console.WriteLine(i.GetValueOrDefault()); 
}

// Shorthand syntax for Nullable types
int? i = null;
double? D = null;

// ?? operator with Nullable Type
int? i = null;
            
int j = i ?? 0;

Console.WriteLine(j);

// Nullable type as Class Field
class MyClass
{
    public Nullable<int> i;
}
class Program
{
    static void Main(string[] args)
    {
        MyClass mycls = new MyClass();

        if(mycls.i == null)
            Console.WriteLine("Null");
    }
}

// Nullable Type Comparison
static void Main(string[] args)
{
    int? i = null;
    int j = 10;


    if (i < j)
        Console.WriteLine("i < j");
    else if( i > 10)
        Console.WriteLine("i > j");
    else if( i == 10)
        Console.WriteLine("i == j");
    else
        Console.WriteLine("Could not compare");
}

// Helper Class
static void Main(string[] args)
{
    int? i = null;
    int j = 10;

    if (Nullable.Compare<int>(i, j) < 0)
        Console.WriteLine("i < j");
    else if (Nullable.Compare<int>(i, j) > 0)
        Console.WriteLine("i > j");
    else
        Console.WriteLine("i = j");
} 

