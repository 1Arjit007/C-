//  C# while Loop
int i = 0; // initialization

while (i < 10) // condition
{
    Console.WriteLine("i = {0}", i);

    i++; // increment
}

// Exit from the while Loop
int i = 0;

while (true)
{
    Console.WriteLine("i = {0}", i);

    i++;

    if (i > 10)
        break;
}

// Infinite While Loop
int i = 1;

while (i > 0)
{
    Console.WriteLine("i = {0}", i);
    i++;
}

// Nested while Loop
int i = 0, j = 1;

while (i < 2)
{
    Console.WriteLine("i = {0}", i);
    i++;

    while (j < 2)
    {
        Console.WriteLine("j = {0}", j);
        j++;
    }
}

