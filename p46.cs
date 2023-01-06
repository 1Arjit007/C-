// throw an exception
static void Main(string[] args)
{
    Student std = null;

    try
    {
        PrintStudentName(std);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message );
    }                      

    Console.ReadKey();
}

private static void PrintStudentName( Student std)
{
    if (std  == null)
        throw new NullReferenceException("Student object is null.");
        
    Console.WriteLine(std.StudentName);
}

// throw an exception
static void Main(string[] args)
{
    try
    {
        Method1();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.StackTrace);
    }                      
}

static void Method1()
{
    try
    {
        Method2();
    }
    catch(Exception ex)
    {
        throw;
    } 
}

static void Method2()
{
    string str = null;
    try
    {
        Console.WriteLine(str[0]);
    }
    catch(Exception ex)
    {
        throw;
    } 
}

// throw an exception
static void Main(string[] args)
{
    try
    {
        Method1();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.StackTrace);
    }                      
}

static void Method1()
{
    try
    {
        Method2();
    }
    catch(Exception ex)
    {
        throw ex;
    } 
}

static void Method2()
{
    string str = null;
    try
    {
        Console.WriteLine(str[0]);
    }
    catch(Exception ex)
    {
        throw;
    } 
}

