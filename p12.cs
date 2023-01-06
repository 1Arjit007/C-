// Define an Enum
enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// Default Enum Values
enum WeekDays
{
    Monday, // 0
    Tuesday, // 1
    Wednesday, // 2
    Thursday, // 3
    Friday, // 4
    Saturday, // 5
    Sunday // 6
}

// Assign Values to Enum Members
enum Categories
{
    Electronics, // 0
    Food, // 1
    Automotive = 6, // 6
    Arts, // 7
    BeautyCare, // 8
    Fashion // 9
}

// Assign Values to Enum Members
enum Categories
{
    Electronics = 1,
    Food = 5,
    Automotive = 6,
    Arts = 10,
    BeautyCare = 11,
    Fashion = 15,
    WomanFashion = 15
}

// byte Enum
enum Categories: byte
{
    Electronics = 1,  
    Food = 5, 
    Automotive = 6, 
    Arts = 10, 
    BeautyCare = 11, 
    Fashion = 15
}

// Access Enum
enum WeekDays
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday, 
    Friday, 
    Saturday,
    Sunday 
}

Console.WriteLine(WeekDays.Monday); // Monday
Console.WriteLine(WeekDays.Tuesday); // Tuesday
Console.WriteLine(WeekDays.Wednesday); // Wednesday
Console.WriteLine(WeekDays.Thursday); // Thursday
Console.WriteLine(WeekDays.Friday); // Friday
Console.WriteLine(WeekDays.Saturday); // Saturday
Console.WriteLine(WeekDays.Sunday); // Sunday

// Enum Conversion
enum WeekDays
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday, 
    Friday, 
    Saturday,
    Sunday 
}

Console.WriteLine(WeekDays.Friday); //output: Friday 
int day = (int) WeekDays.Friday; // enum to int conversion
Console.WriteLine(day); //output: 4 
		
var wd = (WeekDays) 5; // int to enum conversion
Console.WriteLine(wd);//output: Saturday


