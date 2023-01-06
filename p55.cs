// Extension Method
int i = 10;

bool result = i.IsGreaterThan(100); //returns false

// Create a Class for Extension Methods
namespace ExtensionMethods
{
    public static class IntExtensions { }
}

// Define an Extension Method
namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}

// Extension method
using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;

        bool result = i.IsGreaterThan(100); 

        Console.WriteLine(result);
    }
}

