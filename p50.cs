// C# Delegate
public delegate void Print(int val);

static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{           
    Print prnt = ConsolePrint;
    prnt(10);
}

// Action delegate
static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{
    Action<int> printActionDel = ConsolePrint;
    printActionDel(10);
}

Action<int> printActionDel = ConsolePrint;

//Or

Action<int> printActionDel = new Action<int>(ConsolePrint);

// Anonymous method with Action delegate
static void Main(string[] args)
{
    Action<int> printActionDel = delegate(int i)
                                {
                                    Console.WriteLine(i);
                                };

    printActionDel(10);
}

// Lambda expression with Action delegate
static void Main(string[] args)
{

    Action<int> printActionDel = i => Console.WriteLine(i);
       
    printActionDel(10);
}