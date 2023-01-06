//  Create a SortedList and Add Elements
//SortedList of int keys, string values
SortedList<int, string> numberNames = new SortedList<int, string>();
numberNames.Add(3, "Three");
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(4, null);
numberNames.Add(10, "Ten");
numberNames.Add(5, "Five");

//The following will throw exceptions
//numberNames.Add("Three", 3); //Compile-time error: key must be int type
//numberNames.Add(1, "One"); //Run-time exception: duplicate key
//numberNames.Add(null, "Five");//Run-time exception: key cannot be null

//Creating a SortedList of string keys, string values
//using collection-initializer syntax
SortedList<string, string> cities = new SortedList<string, string>()
{
    { "London", "UK" },
    { "New York", "USA" },
    { "Mumbai", "India" },
    { "Johannesburg", "South Africa" }
};

// SortedList Elements Default Sorting Order
SortedList<int, string> numberNames = new SortedList<int, string>()
{
    { 3, "Three" },
    { 5, "Five" },
    { 1, "One" }
};

Console.WriteLine("---Initial key-values--");

foreach (KeyValuePair<int, string> kvp in numberNames)
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

numberNames.Add(6, "Six");
numberNames.Add(2, "Two");
numberNames.Add(4, "Four");

Console.WriteLine("---After adding new key-values--");

foreach (var kvp in numberNames)
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

// Access SortedList Values
SortedList<int, string> numberNames = new SortedList<int, string>()
{
    { 3, "Three" },
    { 1, "One" },
    { 2, "Two" }
};

Console.WriteLine(numberNames[1]); //output: One
Console.WriteLine(numberNames[2]); //output: Two
Console.WriteLine(numberNames[3]); //output: Three

//Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

numberNames[2] = "TWO"; //updates value
numberNames[4] = "Four"; //adds a new key-value if a key does not exists

// ContainsKey() and TryGetValue()
SortedList<int, string> numberNames = new SortedList<int, string>()
{
    { 3, "Three" },
    { 1, "One" },
    { 2, "Two" }
};
if (numberNames.ContainsKey(4))
{
    numberNames[4] = "four";
}

int result;
if (numberNames.TryGetValue(4, out result))
    Console.WriteLine("Key: {0}, Value: {1}", 4, result);

// Iterate SortedList using For Loop
SortedList<int, string> numberNames = new SortedList<int, string>()
{
    { 3, "Three" },
    { 1, "One" },
    { 2, "Two" }
};
for (int i = 0; i < numberNames.Count; i++)
{
    Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
}

// Remove Elements
SortedList<int, string> numberNames = new SortedList<int, string>()
{
    { 3, "Three" },
    { 1, "One" },
    { 2, "Two" },
    { 5, "Five" },
    { 4, "Four" }
};

numberNames.Remove(1); //removes key 1 pair
numberNames.Remove(10); //removes key 1 pair, no error if not exists

numberNames.RemoveAt(0); //removes key-value pair from index 0

//numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

foreach (var kvp in numberNames)
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


