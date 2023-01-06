// Create and Add Elements in the Queue
Queue<int> callerIds = new Queue<int>();
callerIds.Enqueue(1);
callerIds.Enqueue(2);
callerIds.Enqueue(3);
callerIds.Enqueue(4);

foreach (var id in callerIds)
    Console.Write(id); //prints 1234

// Queue<T> Properties and Methods

// Property
// Count

// Method
// Enqueue(T)
// Dequeue
// Peek()
// Contains(T)
// Clear()

// Reading Queue
Queue<string> strQ = new Queue<string>();
strQ.Enqueue("H");
strQ.Enqueue("e");
strQ.Enqueue("l");
strQ.Enqueue("l");
strQ.Enqueue("o");

Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

while (strQ.Count > 0)
    Console.WriteLine(strQ.Dequeue()); //prints Hello

Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0

// Peek()
Queue<string> strQ = new Queue<string>();
strQ.Enqueue("H");
strQ.Enqueue("e");
strQ.Enqueue("l");
strQ.Enqueue("l");
strQ.Enqueue("o");

Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

if (strQ.Count > 0)
{
    Console.WriteLine(strQ.Peek()); //prints H
    Console.WriteLine(strQ.Peek()); //prints H
}

Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

// Contains()
Queue<int> callerIds = new Queue<int>();
callerIds.Enqueue(1);
callerIds.Enqueue(2);
callerIds.Enqueue(3);
callerIds.Enqueue(4);

callerIds.Contains(2); //true
callerIds.Contains(10); //false
