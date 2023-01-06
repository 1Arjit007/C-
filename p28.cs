// Array Declaration
int[] evenNums;  // integer array

string[] cities; // string array

// Array Declaration & Initialization
int[] evenNums = new int[5]{ 2, 4, 6, 8, 10 }; 

string[] cities = new string[3]{ "Mumbai", "London", "New York" };

// Array Declaration using var
var evenNums = new int[]{ 2, 4, 6, 8, 10}; 

var cities = new string[]{ "Mumbai", "London", "New York" };

// Short Syntax of Array Declaration
int[] evenNums = { 2, 4, 6, 8, 10}; 

string[] cities = { "Mumbai", "London", "New York" }

// Invalid Array Creation
//must specify the size 
// int[] evenNums = new int[]; 

//number of elements must be equal to the specified size 
// int[] evenNums = new int[5] { 2, 4 };

//cannot use var with array initializer
// var evenNums = { 2, 4, 6, 8, 10};

//  Late Initialization
int[] evenNums;

evenNums = new int[5];
// or
evenNums = new int[]{ 2, 4, 6, 8, 10 };

// Access Array Elements using Indexes
int[] evenNums = new int[5];
evenNums[0] = 2;
evenNums[1] = 4;
//evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

Console.WriteLine(evenNums[0]);  //prints 2
Console.WriteLine(evenNums[1]);  //prints 4

// Accessing Array Elements using for Loop
int[] evenNums = { 2, 4, 6, 8, 10 };

for(int i = 0; i < evenNums.Length; i++)
    Console.WriteLine(evenNums[i]);  

for(int i = 0; i < evenNums.Length; i++)
    evenNums[i] = evenNums[i] + 10;  // update the value of each element by 10

//  Accessing Array using foreach Loop
int[] evenNums = { 2, 4, 6, 8, 10}; 
string[] cities = { "Mumbai", "London", "New York" }; 

foreach(var item in evenNums)
    Console.WriteLine(item);   

foreach(var city in cities)
    Console.WriteLine(city); 

// LINQ Methods
int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

nums.Max(); // returns 16
nums.Min(); // returns 6
nums.Sum(); // returns 55
nums.Average(); // returns 55

// Array Methods
int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

Array.Sort(nums); // sorts array 
Array.Reverse(nums); // sorts array in descending order
Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
Array.BinarySearch(nums, 5);// binary search 

// Passing Array as Argument
public static void Main(){
    int[] nums = { 1, 2, 3, 4, 5 };

    UpdateArray(nums); 

    foreach(var item in nums)
        Console.WriteLine(item);   
}
                    
public static void UpdateArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        arr[i] = arr[i] + 10;   
}


