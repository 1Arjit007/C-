Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");

var person = Tuple.Create(1, "Steve", "Jobs");

var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

// Accessing Tuple Elements
var person = Tuple.Create(1, "Steve", "Jobs");
person.Item1; // returns 1
person.Item2; // returns "Steve"
person.Item3; // returns "Jobs"

var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
numbers.Item1; // returns "One"
numbers.Item2; // returns 2
numbers.Item3; // returns 3
numbers.Item4; // returns "Four"
numbers.Item5; // returns 5
numbers.Item6; // returns "Six"
numbers.Item7; // returns 7
numbers.Rest; // returns (8)
numbers.Rest.Item1; // returns 8

// Nested Tuple
var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
numbers.Item1; // returns 1
numbers.Item7; // returns 7
numbers.Rest.Item1; //returns (8, 9, 10, 11, 12, 13)
numbers.Rest.Item1.Item1; //returns 8
numbers.Rest.Item1.Item2; //returns 9

// Nested Tuple
var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
numbers.Item1; // returns 1
numbers.Item2; // returns 2
numbers.Item3; // returns (3, 4, 5, 6, 7,  8)
numbers.Item3.Item1; // returns 3
numbers.Item4; // returns 9
numbers.Rest.Item1; //returns 13

// Tuple as a Method Parameter
static void Main(string[] args)
{
    var person = Tuple.Create(1, "Steve", "Jobs");
    DisplayTuple(person);
}

static void DisplayTuple(Tuple<int, string, string> person)
{
    Console.WriteLine($"Id = {person.Item1}");
    Console.WriteLine($"First Name = {person.Item2}");
    Console.WriteLine($"Last Name = {person.Item3}");
}

// Tuple as a Return Type
static void Main(string[] args)
{
    var person = GetPerson();
}

static Tuple<int, string, string> GetPerson()
{
    return Tuple.Create(1, "Bill", "Gates");
}
