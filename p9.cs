// String Literals
// "S"
// "String"
// "This is a string."

// String Type Variables
string ch = "S";
string word = "String";
string text = "This is a string.";

// String and string
string str1 = "Hello"; // uses string keyword
 
String str2 = "Hello"; // uses System.String class

// String as char Array
char[] chars = {'H','e','l','l','o'};

string str1 = new string(chars);  
String str2 = new String(chars); 

foreach (char c in str1)
{
    Console.WriteLine(c);
}

// Invalid String
// string text = "This is a "string" in C#.";

// Escape Char \
string text = "This is a \"string\" in C#.";
string str = "xyzdef\\rabc";
string path = "\\\\mypc\\ shared\\project";

// Verbatim Strings
string str = @"xyzdef\rabc";
string path = @"\\mypc\shared\project";
string email = @"test@test.com";

// Multi-line String
string str1 = "this is a \n" + 
        "multi line \n" + 
        "string";
		
// Verbatim string
string str2 = @"this is a 
        multi line 
        string";

// String Concatenation
string name = "Mr." + "James " + "Bond" + ", Code: 007";
 
string firstName = "James";
string lastName = "Bond";
string code = "007";
 
string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;

// String Interpolation
string firstName = "James";
string lastName = "Bond";
string code = "007";
 
string fullName = $"Mr. {firstName} {lastName}, Code: {code}";