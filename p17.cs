// The following data types are all of value type
// bool
// byte
// char
// decimal
// double
// enum
// float
// int
// long
// sbyte
// short
// struct
// uint
// ulong
// ushort

// Passing Value Type Variables
static void ChangeValue(int x)
{
    x =  200;

    Console.WriteLine(x);
}

static void Main(string[] args)
{
    int i = 100;

    Console.WriteLine(i);
    
    ChangeValue(i);
    
    Console.WriteLine(i);
}

// The followings are reference type data types
// String
// Arrays (even if their elements are value types)
// Class
// Delegate

// Passing Reference Type Variable
static void ChangeReferenceType(Student std2)
{
    std2.StudentName = "Steve";
}

static void Main(string[] args)
{
    Student std1 = new Student();
    std1.StudentName = "Bill";
    
    ChangeReferenceType(std1);

    Console.WriteLine(std1.StudentName);
}

// Passing String
static void ChangeReferenceType(string name)
{
    name = "Steve";
}

static void Main(string[] args)
{
    string name = "Bill";
    
    ChangeReferenceType(name);

    Console.WriteLine(name);
}

