// Create and Add Elements in Stack
Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

foreach (var item in myStack)
    Console.Write(item + ","); //prints 4,3,2,1,

// Create and Add Elements in Stack
int[] arr = new int[] { 1, 2, 3, 4 };
Stack<int> myStack = new Stack<int>(arr);

foreach (var item in myStack)
    Console.Write(item + ","); //prints 4,3,2,1,

// Stack<T> Properties and Methods:

// Property
// Count

// Method
// Push(T)
// Peek()
// Pop()
// Contains(T)
// Clear()

// Access Stack using Pop()
Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

Console.Write("Number of elements in Stack: {0}", myStack.Count);

while (myStack.Count > 0)
    Console.Write(myStack.Pop() + ",");

Console.Write("Number of elements in Stack: {0}", myStack.Count);

// Retrieve Elements usign Peek()
Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

Console.Write("Number of elements in Stack: {0}", myStack.Count); // prints 4

if (myStack.Count > 0)
{
    Console.WriteLine(myStack.Peek()); // prints 4
    Console.WriteLine(myStack.Peek()); // prints 4
}

Console.Write("Number of elements in Stack: {0}", myStack.Count); // prints 4

// Contains()
Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

myStack.Contains(2); // returns true
myStack.Contains(10); // returns false
