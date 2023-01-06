// do-while Loop
int i = 0;

do
{
    Console.WriteLine("i = {0}", i);
    i++;

} while (i < 5);

// Exit from the do-while Loop
int i = 0;

do
{
    Console.WriteLine("i = {0}", i);
    i++;
    
    if (i > 5)
        break;

} while (i < 10);

// Nested do-while Loop
int i = 0;

do
{
    Console.WriteLine("Value of i: {0}", i);
    int j = i;

    i++;
                
    do
    {
        Console.WriteLine("Value of j: {0}", j);
        j++;
    } while (j < 2);

} while (i < 2);

