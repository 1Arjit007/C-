// C# Interface
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

// Syntax:
class ClassName : InterfaceName
{

}

// Interface Implementation
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

// Interface Implementation
public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        FileInfo file2 = new FileInfo();
		
        file1.ReadFile(); 
        file1.WriteFile("content"); 

        file2.ReadFile(); 
        file2.WriteFile("content"); 
    }
}

//  Explicit Implementation
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
    
class FileInfo : IFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    void IFile.WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

// Explicit Implementation
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    void IFile.WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }

    public void Search(string text)
    {
        Console.WriteLine("Searching in file");
    }
}

public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        FileInfo file2 = new FileInfo();
		
        file1.ReadFile(); 
        file1.WriteFile("content"); 
        //file1.Search("text to be searched")//compile-time error 
        
        file2.Search("text to be searched");
        //file2.ReadFile(); //compile-time error 
        //file2.WriteFile("content"); //compile-time error 
    }
}

// Implement Multiple Interfaces
interface IFile
{
    void ReadFile();
}

interface IBinaryFile
{
    void OpenBinaryFile();
    void ReadFile();
}

class FileInfo : IFile, IBinaryFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading Text File");
    }

    void IBinaryFile.OpenBinaryFile()
    {
        Console.WriteLine("Opening Binary File");
    }

    void IBinaryFile.ReadFile()
    {
        Console.WriteLine("Reading Binary File");
    }

    public void Search(string text)
    {
        Console.WriteLine("Searching in File");
    }
}

public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        IBinaryFile file2 = new FileInfo();
        FileInfo file3 = new FileInfo();
		
        file1.ReadFile(); 
        //file1.OpenBinaryFile(); //compile-time error 
        //file1.SearchFile("text to be searched"); //compile-time error 
        
        file2.OpenBinaryFile();
        file2.ReadFile();
        //file2.SearchFile("text to be searched"); //compile-time error 
    
        file3.Search("text to be searched");
        //file3.ReadFile(); //compile-time error 
        //file3.OpenBinaryFile(); //compile-time error 
    }
}

// Default Interface Methods
interface IFile
{
    void ReadFile();
    void WriteFile(string text);

    void DisplayName()
    {
        Console.WriteLine("IFile");
    }
}

// Interface Implementation
class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        file1.ReadFile(); 
        file1.WriteFile("content"); 
        file1.DisplayName();

        FileInfo file2 = new FileInfo();
        //file2.DisplayName(); //compile-time error 
    }
}


