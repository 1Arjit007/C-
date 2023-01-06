// for Loop
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Value of i: {0}", i);
}

// for Loop
for(int i = 0; i < 10; i++)
    Console.WriteLine("Value of i: {0}", i);

// for loop C#
int i = 0;

for(;;)
{
    if (i < 10)
    {
        Console.WriteLine("Value of i: {0}", i);
        i++;
    }
    else
        break;
}

// Infinite for Loop
for ( ; ; )
{
    Console.Write(1);
}

// Decimal for Loop
for (double d = 1.01D; d < 1.10; d+= 0.01D)
{
    Console.WriteLine("Value of i: {0}", d);
}

// Reverse for Loop
for(int i = 10; i > 0; i--)
{
    Console.WriteLine("Value of i: {0}", i);
}

// break in for loop
for (int i = 0; i < 10; i++)
{
    if( i == 5 )
        break;

    Console.WriteLine("Value of i: {0}", i);
}

// Multiple Expressions
for (int i = 0, j = 0; i+j < 5; i++, j++)
{
    Console.WriteLine("Value of i: {0}, J: {1} ", i,j);
}

//  Initializer and Iterator Statements
int i = 0, j = 5;
for (Console.WriteLine($"Initializer: i={i}, j={j}"); 
    i++ < j--; 
    Console.WriteLine($"Iterator: i={i}, j={j}"))
    {
    }

// Nested for loop
for (int i = 0; i < 2; i++)
{
    for(int j =i; j < 4; j++)
        Console.WriteLine("Value of i: {0}, J: {1} ", i,j);
}

