// Create an ArrayList
using System.Collections;

ArrayList arlist = new ArrayList();

// or
var arlist = new ArrayList(); // recommended

// Adding Elements in ArrayList

// adding elements using ArrayList.Add() method
var arlist1 = new ArrayList();
arlist1.Add(1);
arlist1.Add("Bill");
arlist1.Add(" ");
arlist1.Add(true);
arlist1.Add(4.5);
arlist1.Add(null);

// adding elements using object initializer syntax
var arlist2 = new ArrayList() { 2, "Steve", " ", true, 4.5, null };

// Adding Entire Array/ArrayList into ArrayList
var arlist1 = new ArrayList();

var arlist2 = new ArrayList() { 1, "Bill", " ", true, 4.5, null };

int[] arr = { 100, 200, 300, 400 };

Queue myQ = new Queue();
myQ.Enqueue("Hello");
myQ.Enqueue("World!");

arlist1.AddRange(arlist2); //adding arraylist in arraylist
arlist1.AddRange(arr); //adding array in arraylist
arlist1.AddRange(myQ); //adding Queue in arraylist

// Accessing Elements of ArrayList
var arlist = new ArrayList() { 1, "Bill", 300, 4.5f };

//Access individual item using indexer
int firstElement = (int)arlist[0]; //returns 1
string secondElement = (string)arlist[1]; //returns "Bill"

//int secondElement = (int) arlist[1]; //Error: cannot cover string to int

//using var keyword without explicit casting
var firstElement = arlist[0]; //returns 1
var secondElement = arlist[1]; //returns "Bill"

//var fifthElement = arlist[5]; //Error: Index out of range

//update elements
arlist[0] = "Steve";
arlist[1] = 100;

//arlist[5] = 500; //Error: Index out of range

// Iterate ArrayList
ArrayList arlist = new ArrayList() { 1, "Bill", 300, 4.5F };

foreach (var item in arlist)
    Console.Write(item + ", "); //output: 1, Bill, 300, 4.5,

for (int i = 0; i < arlist.Count; i++)
    Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5,

// Insert Element in ArrayList
ArrayList arlist = new ArrayList() { 1, "Bill", 300, 4.5f };

arlist.Insert(1, "Second Item");

foreach (var val in arlist)
    Console.WriteLine(val);

// Insert Collection in ArrayList
ArrayList arlist1 = new ArrayList() { 100, 200, 600 };

ArrayList arlist2 = new ArrayList() { 300, 400, 500 };
arlist1.InsertRange(2, arlist2);

foreach (var item in arlist1)
    Console.Write(item + ", "); //output: 100, 200, 300, 400, 500, 600,

// Remove Elements from ArrayList
ArrayList arList = new ArrayList() { 1, null, "Bill", 300, " ", 4.5f, 300, };

arList.Remove(null); //Removes first occurance of null
arList.RemoveAt(4); //Removes element at index 4
arList.RemoveRange(0, 2); //Removes two elements starting from 1st item (0 index)

// Check for Elements
ArrayList arList = new ArrayList() { 1, "Bill", 300, 4.5f, 300 };

Console.WriteLine(arList.Contains(300)); // true
Console.WriteLine(arList.Contains("Bill")); // true
Console.WriteLine(arList.Contains(10)); // false
Console.WriteLine(arList.Contains("Steve")); // false

// ArrayList Properties
// Capacity
// Count
// IsFixedSize
// IsReadOnly
// Item

// ArrayList Methods
// Add()/AddRange()
// Insert()/InsertRange()
// Remove()/RemoveRange()
// RemoveAt()
// Sort()
// Reverse()
// Contains
// Clear
// CopyTo
// GetRange
// IndexOf
// ToArray