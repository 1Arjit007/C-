// Func
namespace System
{
    public delegate TResult Func<in T, out TResult>(T arg);
}

// Func
class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result);
    }
}

// Func with Zero Input Parameter
Func<int> getRandomNumber;

// Func with Anonymous Method
Func<int> getRandomNumber = delegate()
                            {
                                Random rnd = new Random();
                                return rnd.Next(1, 100);
                            };

//  Func with lambda expression
Func<int> getRandomNumber = () => new Random().Next(1, 100);

//Or 

Func<int, int, int>  Sum  = (x, y) => x + y;
