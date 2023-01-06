// Class Hierarchy
public class Small { }

public class Big : Small { }

public class Bigger : Big { }

// Covariance with Delegate
public delegate Small covarDel(Big mc);

public class Program
{
    public static Big Method1(Big bg)
    {
        Console.WriteLine("Method1");

        return new Big();
    }

    public static Small Method2(Big bg)
    {
        Console.WriteLine("Method2");

        return new Small();
    }

    public static void Main(string[] args)
    {
        covarDel del = Method1;

        Small sm1 = del(new Big());

        del = Method2;
        Small sm2 = del(new Big());
    }
}

// Contravariance with Delegate
delegate Small covarDel(Big mc);

class Program
{
    static Big Method1(Big bg)
    {
        Console.WriteLine("Method1");
        return new Big();
    }
    static Small Method2(Big bg)
    {
        Console.WriteLine("Method2");
        return new Small();
    }

    static Small Method3(Small sml)
    {
        Console.WriteLine("Method3");
        
        return new Small();
    }
    static void Main(string[] args)
    {
        covarDel del = Method1;
        del += Method2;
        del += Method3;

        Small sm = del(new Big());
}

// Covariance and Contravariance
delegate Small covarDel(Big mc);

class Program
{

    static Big Method4(Small sml)
    {
        Console.WriteLine("Method3");
    
        return new Big();
    }

    static void Main(string[] args)
    {
        covarDel del = Method4;
    
        Small sm = del(new Big());
    }
}