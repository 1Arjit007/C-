// EmployeeProps.cs
public partial class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
}

// EmployeeMethods.cs
public partial class Employee
{
    //constructor
    public Employee(int id, string name){
        this.EmpId = id;
        this.Name = name;
    }

    public void DisplayEmpInfo() {
        Console.WriteLine(this.EmpId + " " this.Name);
    }
}

// Combined Class
public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name){
        this.EmpId = id;
        this.Name = name;
    }

    public void DisplayEmpInfo(){
        Console.WriteLine(this.EmpId + " " this.Name );
    }
}

// Partial Methods
// EmployeeProps.cs
public partial class Employee
{
    public Employee() { 
        GenerateEmpId();
    }
    public int EmpId { get; set; }
    public string Name { get; set; }

    partial void GenerateEmployeeId();

}

// EmployeeMethods.cs
public partial class Employee
{
    partial void GenerateEmployeeId()
    {
        this.EmpId = random();
    }
}

// EmployeeMethods.cs
class Program
{
    static void Main(string[] args)
    {
        var emp = new Employee();
        Console.WriteLine(emp.EmpId); // prints genereted id

        Console.ReadLine();
    }
}

