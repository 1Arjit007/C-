// if Statement
int i = 10, j = 20;

if (i < j)
{
    Console.WriteLine("i is less than j");
}        

if (i > j)
{
    Console.WriteLine("i is greater than j");
}

// Calling Function as Condition
static void Main(string[] args)
{
    int i = 10, j = 20;

    if (isGreater(i, j))
    {
        Console.WriteLine("i is less than j");
    }        

    if (isGreater(j, i))
    {
        Console.WriteLine("j is greater than i");
    }
}

static bool isGreater(int i, int j)
{
    return i > j;                    
}

// else if Statements
int i = 10, j = 20;

if (i == j)
{
    Console.WriteLine("i is equal to j");
}
else if (i > j)
{
    Console.WriteLine("i is greater than j");
}
else if (i < j)
{
    Console.WriteLine("i is less than j");
}

// else Statement
int i = 20, j = 20;

if (i > j)
{
    Console.WriteLine("i is greater than j");
}
else if (i < j)
{
    Console.WriteLine("i is less than j");
}
else
{
    Console.WriteLine("i is equal to j");
}

// Nested if else statements
int i = 10, j = 20;

if (i != j)
{
    if (i < j)
    {
        Console.WriteLine("i is less than j");
    }
    else if (i > j)
    {
       Console.WriteLine("i is greater than j");
    }
}
else
    Console.WriteLine("i is equal to j");




