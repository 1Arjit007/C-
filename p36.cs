// Adding elements in List
List<int> primeNumbers = new List<int>();
primeNumbers.Add(1); // adding elements using add() method
primeNumbers.Add(3);
primeNumbers.Add(5);
primeNumbers.Add(7);

var cities = new List<string>();
cities.Add("New York");
cities.Add("London");
cities.Add("Mumbai");
cities.Add("Chicago");
cities.Add(null); // nulls are allowed for reference type list

//adding elements using collection-initializer syntax
var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

// Add Custom Class Objects in List
var students = new List<Student>()
{
    new Student() { Id = 1, Name = "Bill" },
    new Student() { Id = 2, Name = "Steve" },
    new Student() { Id = 3, Name = "Ram" },
    new Student() { Id = 4, Name = "Abdul" }
};

// Add Arrays in List
string[] cities = new string[3] { "Mumbai", "London", "New York" };

var popularCities = new List<string>();

// adding an array in a List
popularCities.AddRange(cities);

var favouriteCities = new List<string>();

// adding a List
favouriteCities.AddRange(popularCities);

// Accessing List
List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
Console.WriteLine(numbers[0]); // prints 1
Console.WriteLine(numbers[1]); // prints 2
Console.WriteLine(numbers[2]); // prints 5
Console.WriteLine(numbers[3]); // prints 7

// using foreach LINQ method
numbers.ForEach(num => Console.WriteLine(num + ", ")); //prints 1, 2, 5, 7, 8, 10,

// using for loop
for (int i = 0; i < numbers.Count; i++)
    Console.WriteLine(numbers[i]);

// LINQ Query on List
var students = new List<Student>()
{
    new Student() { Id = 1, Name = "Bill" },
    new Student() { Id = 2, Name = "Steve" },
    new Student() { Id = 3, Name = "Ram" },
    new Student() { Id = 4, Name = "Abdul" }
};

//get all students whose name is Bill
var result = from s in students where s.Name == "Bill" select s;

foreach (var student in result)
    Console.WriteLine(student.Id + ", " + student.Name);

// Insert elements into List
var numbers = new List<int>() { 10, 20, 30, 40 };

numbers.Insert(1, 11); // inserts 11 at 1st index: after 10.

foreach (var num in numbers)
    Console.Write(num);

// Remove elements from List
var numbers = new List<int>() { 10, 20, 30, 40, 10 };

numbers.Remove(10); // removes the first 10 from a list

numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

//numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

foreach (var el in intList)
    Console.Write(el); //prints 20 30

// Contains()
var numbers = new List<int>(){ 10, 20, 30, 40 };
numbers.Contains(10); // returns true
numbers.Contains(11); // returns false
numbers.Contains(20); // returns true

// Class Properties and Methods
// Property
// Items
// Count

// Method
// Add
// AddRange
// BinarySearch
// Clear
// Contains
// Find
// Foreach
// Insert
// InsertRange
// Remove
// RemoveAt
// RemoveRange
// Sort
// TrimExcess
// TrueForAll

