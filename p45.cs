// Syntax:
// try
// {
//     // put the code here that may raise exceptions
// }
// catch
// {
//     // handle exception here
// }
// finally
// {
//     // final cleanup code
// }

// C# Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        var num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Squre of {num} is {num * num}");
    }
}

// Exception handling using try-catch blocks
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        catch
        {
            Console.Write("Error occurred.");
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
}

// Exception handling using try catch block
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        catch (Exception ex)
        {
            Console.Write("Error info:" + ex.Message);
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
}

// Exception Filters
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number to divide 100: ");

        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.Write("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.Write("Invalid operation. Please try again.");
        }
        catch (FormatException ex)
        {
            Console.Write("Not a valid format. Please try again.");
        }
        catch (Exception ex)
        {
            Console.Write("Error occurred! Please try again.");
        }
    }
}

// Invalid catch
try
{
    //code that may raise an exception
}
catch //cannot have both catch and catch(Exception ex)
{ 
    Console.WriteLine("Exception occurred");
}
catch(Exception ex) //cannot have both catch and catch(Exception ex)
{
    Console.WriteLine("Exception occurred");
}

// Invalid catch
try
{
    //code that may raise an exception
}
catch
{ 
    // this catch block must be last block
}
catch (NullReferenceException nullEx)
{
    Console.WriteLine(nullEx.Message);
}
catch (InvalidCastException inEx)
{
    Console.WriteLine(inEx.Message);
}

// finally Block
static void Main(string[] args)
{
    FileInfo file = null;

    try
    {
        Console.Write("Enter a file name to write: ");
        string fileName = Console.ReadLine();
        file = new FileInfo(fileName);
        file.AppendText("Hello World!")
    }
    catch(Exception ex)
    {
        Console.WriteLine("Error occurred: {0}", ex.Message );
    }
    finally
    {
        // clean up file object here;
        file = null;
    }
}

// Nested try-catch
static void Main(string[] args)
{
    var divider = 0;

    try
    {
        try
        {
            var result = 100/divider;
        }
        catch
        {
            Console.WriteLine("Inner catch");
        }
    }
    catch
    {
        Console.WriteLine("Outer catch");
    }
}

// Nested try-catch
static void Main(string[] args)
{
    var divider = 0;

    try
    {
        try
        {
            var result = 100/divider;
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine("Inner catch");
        }
    }
    catch
    {
        Console.WriteLine("Outer catch");
    }
}




