// StringBuilder
using System.Text; // include at the top
            
StringBuilder sb = new StringBuilder(); //string will be appended later
//or
StringBuilder sb = new StringBuilder("Hello World!");

// StringBuilder
StringBuilder sb = new StringBuilder(50); //string will be appended later
//or
StringBuilder sb = new StringBuilder("Hello World!", 50);

// StringBuilder Iteration
StringBuilder sb = new StringBuilder("Hello World!");

for(int i = 0; i < sb.Length; i++)
    Console.Write(sb[i]); // output: Hello World!

// Retrieve String from StringBuilder
StringBuilder sb = new StringBuilder("Hello World!");

var greet = sb.ToString(); //returns "Hello World!"

// Adding or Appending Strings in StringBuilder
StringBuilder sb = new StringBuilder();
sb.Append("Hello ");
sb.AppendLine("World!");
sb.AppendLine("Hello C#");
Console.WriteLine(sb);

// AppendFormat()
StringBuilder sbAmout = new StringBuilder("Your total amount is ");
sbAmout.AppendFormat("{0:C} ", 25);

Console.WriteLine(sbAmout);//output: Your total amount is $ 25.00

// Insert()
StringBuilder sb = new StringBuilder("Hello World!");
sb.Insert(5," C#"); 

Console.WriteLine(sb); //output: Hello C# World!

// Remove()
StringBuilder sb = new StringBuilder("Hello World!",50);
sb.Remove(6, 7);

Console.WriteLine(sb); //output: Hello

// Replace()
StringBuilder sb = new StringBuilder("Hello World!");
sb.Replace("World", "C#");

Console.WriteLine(sb);//output: Hello C#!

