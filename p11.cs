// Structure
struct Coordinate
{
    public int x;
    public int y;
}


// Create Structure
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point = new Coordinate();
Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0  

// Create Structure Without new Keyword
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point;
Console.Write(point.x); // Compile time error  

point.x = 10;
point.y = 20;
Console.Write(point.x); //output: 10  
Console.Write(point.y); //output: 20  

// Parameterized Constructor in Struct
struct Coordinate
{
    public int x;
    public int y;

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

Coordinate point = new Coordinate(10, 20);

Console.WriteLine(point.x); //output: 10  
Console.WriteLine(point.y); //output: 20 

// Methods and Properties in Struct
struct Coordinate
{
    public int x { get; set; }
    public int y { get; set; }

    public void SetOrigin()
    {
        this.x = 0;
        this.y = 0;
    }
}

Coordinate point = Coordinate();
point.SetOrigin();

Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0

// Static Constructor in Struct
struct Coordinate
{
    public int x;
    public int y;

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Coordinate GetOrigin()
    {
        return new Coordinate();
    }
}

Coordinate point = Coordinate.GetOrigin();

Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0  

// Event in Structure
struct Coordinate
{
    private int _x, _y;

    public int x 
    {
        get{
            return _x;
        }

        set{
            _x = value;
            CoordinatesChanged(_x);
        }
    }

    public int y
    {
        get{
            return _y;
        }

        set{
            _y = value;
            CoordinatesChanged(_y);
        }
    }

    public event Action<int> CoordinatesChanged;
}

// Handle Structure Events
class Program
{
    static void Main(string[] args)
    {

        Coordinate point = new Coordinate();
        
        point.CoordinatesChanged += StructEventHandler;
        point.x = 10;
        point.y = 20;
    }

    static void StructEventHandler(int point)
    {
        Console.WriteLine("Coordinate changed to {0}", point);
    }
}
