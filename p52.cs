// Anonymous Method
public delegate void Print(int value);

static void Main(string[] args)
{
    Print print = delegate(int val) { 
        Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
    };

    print(100);
}

// Anonymous Method
public delegate void Print(int value);

static void Main(string[] args)
{
    int i = 10;
    
    Print prnt = delegate(int val) {
        val += i;
        Console.WriteLine("Anonymous method: {0}", val); 
    };

    prnt(100);
}

// Anonymous Method as Parameter
public delegate void Print(int value);

class Program
{
    public static void PrintHelperMethod(Print printDel,int val)
    { 
        val += 10;
        printDel(val);
    }

    static void Main(string[] args)
    {
        PrintHelperMethod(delegate(int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
    }
}

// Anonymous Method as Event Handler
saveButton.Click += delegate(Object o, EventArgs e)
{ 
    System.Windows.Forms.MessageBox.Show("Save Successfully!"); 
}


