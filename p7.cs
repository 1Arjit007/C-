// Variables of Different Data Types
string stringVar = "Hello World!!";
int intVar = 100;
float floatVar = 10.2f;
char charVar = 'A';
bool boolVar = true;

// Predefined Data Types in C#
    // byte
    // sbyte
    // short
    // ushort
    // int
    // uint
    // long
    // ulong
    // float
    // double
    // decimal
    // char
    // bool
    // object
    // string
    // DateTime

// Compile time error
// compile time error: Cannot implicitly convert type 'long' to 'int'.
int i = 21474836470;

// Value Suffix
uint ui = 100u;
float fl = 10.2f;
long l = 45755452222222l;
ulong ul = 45755452222222ul;
double d = 11452222.555d;
decimal mon = 1000.15m;

// Default Values
int i = default(int); // 0
float f = default(float);// 0
decimal d = default(decimal);// 0
bool b = default(bool);// false
char c = default(char);// '\0'

// C# 7.1 onwards
int i = default; // 0
float f = default;// 0
decimal d = default;// 0
bool b = default;// false
char c = default;// '\0'

// Implicit Conversion
int i = 345;
float f = i;

Console.WriteLine(f); //output: 345

// Explicit Conversion
public static void Main()
{
    int i = 100;
    uint u = (uint) i;
    Console.Write(i);
}

