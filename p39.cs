// Creating a Hashtable
// Create and Add Elements
Hashtable numberNames = new Hashtable();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three");

foreach (DictionaryEntry de in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

//creating a Hashtable using collection-initializer syntax
var cities = new Hashtable()
{
    { "UK", "London, Manchester, Birmingham" },
    { "USA", "Chicago, New York, Washington" },
    { "India", "Mumbai, New Delhi, Pune" }
};

foreach (DictionaryEntry de in cities)
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

// Add Dictionary in Hashtable
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "one");
dict.Add(2, "two");
dict.Add(3, "three");

Hashtable ht = new Hashtable(dict);

// Update Hashtable
//creating a Hashtable using collection-initializer syntax
var cities = new Hashtable()
{
    { "UK", "London, Manchester, Birmingham" },
    { "USA", "Chicago, New York, Washington" },
    { "India", "Mumbai, New Delhi, Pune" }
};

string citiesOfUK = (string)cities["UK"]; //cast to string
string citiesOfUSA = (string)cities["USA"]; //cast to string

Console.WriteLine(citiesOfUK);
Console.WriteLine(citiesOfUSA);

cities["UK"] = "Liverpool, Bristol"; // update value of UK key
cities["USA"] = "Los Angeles, Boston"; // update value of USA key

if (!cities.ContainsKey("France"))
{
    cities["France"] = "Paris";
}

// Remove Elements from Hashtable
var cities = new Hashtable()
{
    { "UK", "London, Manchester, Birmingham" },
    { "USA", "Chicago, New York, Washington" },
    { "India", "Mumbai, New Delhi, Pune" }
};

cities.Remove("UK"); // removes UK

//cities.Remove("France"); //throws run-time exception: KeyNotFoundException

if (cities.ContainsKey("France"))
{ // check key before removing it
    cities.Remove("France");
}

cities.Clear(); //removes all elements

