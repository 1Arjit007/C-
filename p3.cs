// Define a Class
class Student { }

// Field
class Student
{
    public int id;
}

// Property
class Student
{
    private int id;

    public int StudentId
    {
        get { return id; }
        set { id = value; }
    }
}

// Property
class Student
{
    private int id;

    public int StudentId
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
        }
    }
}

// Example: Auto-implemented Property
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// Method
// Syntax
[access-modifier] return-type MethodName(type parameterName1, type parameterName2,...)
{
    

}

// C# Method
public int Sum(int num1, int num2)
{
    var total = num1 + num2;
    
    return total;
}

// C# Method
public void Greet()
{
    Console.Write("Hello World!");
}

// Method
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}

// Constructor
class Student
{
    public Student()
    {
        //constructor
    }
}

// Create an Object of a Class
Student mystudent = new Student();

// Access Members of a Class
Student mystudent = new Student();
mystudent.FirstName = "Steve";
mystudent.LastName = "Jobs";
mystudent.GetFullName();

// Create Multiple Objects of a Class
Student mystudent1 = new Student();
mystudent1.FirstName = "Steve";
mystudent1.LastName = "Jobs";

Student mystudent2 = new Student();
mystudent2.FirstName = "Bill";
mystudent2.LastName = "Gates";