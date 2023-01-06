//  Ternary operator
int x = 20, y = 10;

var result = x > y ? "x is greater than y" : "x is less than y";

Console.WriteLine(result);

// Ternary operator
int x = 10, y = 100;

var result = x > y ? "x is greater than y" : "x is less than y";

Console.WriteLine(result);

// Ternary operator replaces if statement
int x = 10, y = 100;

if (x > y)
    Console.WriteLine("x is greater than y");
else
    Console.WriteLine("x is less than y");

// Nested ?:
int x = 10, y = 100;

string result = x > y ? "x is greater than y" : 
                    x < y ? "x is less than y" : 
                        x == y ? "x is equal to y" : "No result";

Console.WriteLine(result);

// Nested ?:
var x = 2, y = 10;

var result = x * 3 > y ? x : y > z? y : z;
Console.WriteLine(result);