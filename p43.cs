// ValueTuple Initialization
var person = (1, "Bill", "Gates");

//equivalent Tuple
//var person = Tuple.Create(1, "Bill", "Gates");

// ValueTuple
ValueTuple<int, string, string> person = (1, "Bill", "Gates");
person.Item1; // returns 1
person.Item2; // returns "Bill"
person.Item3; // returns "Gates"

// ValueTuple

(int, string, string) person = (1, "James", "Bond");
person.Item1; // returns 1
person.Item2; // returns "James"
person.Item3; // returns "Bond"

var number = (1); // int type, NOT a tuple
var numbers = (1, 2); //valid tuple

// Unlike Tuple, a ValueTuple can include more than eight values.
var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

// Named Members of ValueTuple
(int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
person.Id; // returns 1
person.FirstName; // returns "Bill"
person.LastName; // returns "Gates"

var person = (Id: 1, FirstName: "Bill", LastName: "Gates");

// PersonId, FName, LName will be ignored.
(int Id, string FirstName, string LastName) person = (PersonId: 1, FName: "Bill", LName: "Gates");

// PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.
(string, string, int) person = (PersonId: 1, FName: "Bill", LName: "Gates");

string firstName = "Bill",
    lastName = "Gates";
var per = (FirstName: firstName, LastName: lastName);

// ValueTuple As Parameter
static void Main(string[] args)
{
    DisplayTuple((1, "Bill", "Gates"));
}

static void DisplayTuple((int, string, string) person)
{
    Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
}

// ValueTuple As Return Type
static void Main(string[] args)
{
    var person = GetPerson();
    Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
}

static (int, string, string) GetPerson()
{
    return (1, "Bill", "Gates");
}

// ValueTuple As Return Type
static void Main(string[] args)
{
    var person = GetPerson();
    Console.WriteLine("{0}, {1}, {2}", person.Id, person.FirstName, person.LastName);
}

static (int Id, string FirstName, string LastName) GetPerson()
{
    return (Id: 1, FirstName: "Bill", LastName: "Gates");
}

// Deconstruct ValueTuple
static void Main(string[] args)
{
    // change property names
    (int PersonId, string FName, string LName) = GetPerson();
}
static (int, string, string) GetPerson()
{
    return (Id: 1, FirstName: "Bill", LastName: "Gates");
}

// Deconstruct ValueTuple
static void Main(string[] args)
{
    // use var as datatype
    (var PersonId, var FName, var LName) = GetPerson();
}
static (int, string, string) GetPerson()
{
    return (Id: 1, FirstName: "Bill", LastName: "Gates");
}
