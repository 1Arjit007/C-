// Syntax
// <data type> <variable name> = <value>;

// C# Variable
int num = 100;

// C# Variables
int num = 100;
float rate = 10.2f;
decimal amount = 100.50M;
char code = 'C';
bool isValid = true;
string name = "Steve";

// Cannot assign string to int type variable
// int num = "Steve";

// Late Initialization
int num;
num = 100;

// Invalid Assignment
int i;
int j = i; //compile-time error: Use of unassigned local variable 'i'

// C# Variable
int num = 100;
num = 200;
Console.WriteLine(num); //output: 200

// Multiple Variables in a Single Line
int i, j = 10, k = 100;

// Multi-Line Declarations
int i = 0, 
    j = 10, 
    k = 100;

// Variable Assignment
int i = 100;

int j = i; // value of j will be 100

// Variable & Expression
int i = 100;

int j = i + 20; // j = 120

i = 200;
j = i + 20;// j = 220

i = 300;
Console.WriteLine("j = {0}", j);// j = 220

