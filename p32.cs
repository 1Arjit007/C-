// Define Generic Class
class DataStore<T>
{
    public T Data { get; set; }
}

DataStore<string> store = new DataStore<string>();

// Generic Class with Multiple Type Parameters
class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}

// Generic class
DataStore<string> strStore = new DataStore<string>();
strStore.Data = "Hello World!";
//strStore.Data = 123; // compile-time error

DataStore<int> intStore = new DataStore<int>();
intStore.Data = 100;
//intStore.Data = "Hello World!"; // compile-time error

KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
kvp1.Key = 100;
kvp1.Value = "Hundred";

KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
kvp2.Key = "IT";
kvp2.Value = "Information Technology";

// Generic Field
class DataStore<T>
{
    public T data;
}

// Generic Array
class DataStore<T>
{
    public T[] data = new T[10];
}

// Generic Methods
class DataStore<T>
{
    private T[] _data = new T[10];
    
    public void AddOrUpdate(int index, T item)
    {
        if(index >= 0 && index < 10)
            _data[index] = item;
    }

    public T GetData(int index)
    {
        if(index >= 0 && index < 10)
            return _data[index];
        else 
            return default(T);
    }
}

// Generic Methods
DataStore<string> cities = new DataStore<string>();
cities.AddOrUpdate(0, "Mumbai");
cities.AddOrUpdate(1, "Chicago");
cities.AddOrUpdate(2, "London");

DataStore<int> empIds = new DataStore<int>();
empIds.AddOrUpdate(0, 50);
empIds.AddOrUpdate(1, 65);
empIds.AddOrUpdate(2, 89);

// Generic Method Overloading
public void AddOrUpdate(int index, T data) { }
public void AddOrUpdate(T data1, T data2) { }
public void AddOrUpdate<U>(T data1, U data2) { }
public void AddOrUpdate(T data) { }

// Generic Method in Non-generic Class
class Printer
{
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

Printer printer = new Printer();
printer.Print<int>(100);
printer.Print(200); // type infer from the specified value
printer.Print<string>("Hello");
printer.Print("World!"); // type infer from the specified value


