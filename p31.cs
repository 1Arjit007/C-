// Syntax
// <return type> this[<parameter type> index]
// {
//     get{
//         // return the value from the specified index of an internal collection
//     }
//     set{
//         // set values at the specified index in an internal collection
//     }
// }

// Indexer
class StringDataStore
{
    private string[] strArr = new string[10]; // internal data storage

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
        }

        set
        {
            if (index < 0 ||  index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            strArr[index] = value;
        }
    }
}

//  Indexer
StringDataStore strStore = new StringDataStore();

strStore[0] = "One";
strStore[1] = "Two";
strStore[2] = "Three";
strStore[3] = "Four";
        
for(int i = 0; i < 10 ; i++)
    Console.WriteLine(strStore[i]);

// Indexer
class StringDataStore
{
    private string[] strArr = new string[10]; // internal data storage

    public string this[int index]
    {
        get => strArr[index];

        set => strArr[index] = value;
    }
}

// Generic Indexer
class DataStore<T>
{
    private T[] store; 

    public DataStore()
    {
        store = new T[10];
    }

    public DataStore(int length)
    {
        store = new T[length];
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 &&  index >= store.Length)
                throw new IndexOutOfRangeException("Index out of range");

                return store[index];
        }

        set
        {
            if (index < 0 ||  index >= store.Length)
                throw new IndexOutOfRangeException("Index out of range");

            store[index] = value;
        }
    }

    public int Length
    {
        get
        {
            return store.Length;
        }
    }
}

// generic indexer
DataStore<int> grades = new DataStore<int>();
grades[0] = 100;
grades[1] = 25;
grades[2] = 34;
grades[3] = 42;
grades[4] = 12;
grades[5] = 18;
grades[6] = 2;
grades[7] = 95;
grades[8] = 75;
grades[9] = 53;

for (int i = 0; i < grades.Length;i++)
    Console.WriteLine(grades[i]);

DataStore<string> names = new DataStore<string>(5);
names[0] = "Steve";
names[1] = "Bill";
names[2] = "James";
names[3] = "Ram";
names[4] = "Andy";

for (int i = 0; i < names.Length;i++)
    Console.WriteLine(names[i]);

// Override Indexer
class StringDataStore
{
    private string[] strArr = new string[10]; // internal data storage

    // int type indexer
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return strArr[index];
        }

        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            strArr[index] = value;
        }
    }

    // string type indexer
    public string this[string name]
    {
        get
        {
            foreach (string str in strArr){
                if(str.ToLower() == name.ToLower())        
                    return str;
                }
                    
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StringDataStore strStore = new StringDataStore();

        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";
        
        Console.WriteLine(strStore["one"]);
        Console.WriteLine(strStore["two"]);
        Console.WriteLine(strStore["Three"]);
        Console.WriteLine(strStore["Four"]);
    }
}
