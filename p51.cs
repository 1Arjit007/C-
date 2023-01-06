// Predicate signature: 
public delegate bool Predicate<in T>(T obj);

// Predicate delegate
static bool IsUpperCase(string str)
{
    return str.Equals(str.ToUpper());
}

static void Main(string[] args)
{
    Predicate<string> isUpper = IsUpperCase;

    bool result = isUpper("hello world!!");

    Console.WriteLine(result);
}

// Predicate delegate with anonymous method
static void Main(string[] args)
{
    Predicate<string> isUpper = delegate(string s) { return s.Equals(s.ToUpper());};
    bool result = isUpper("hello world!!");
}

// Predicate delegate with lambda expression
static void Main(string[] args)
{
    Predicate<string> isUpper = s => s.Equals(s.ToUpper());
    bool result = isUpper("hello world!!");
}