// Create DateTime Object
DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00

// Set Date & Time
//assigns default value 01/01/0001 00:00:00
DateTime dt1 = new DateTime(); 

//assigns year, month, day
DateTime dt2 = new DateTime(2015, 12, 31); 

//assigns year, month, day, hour, min, seconds
DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
 
//assigns year, month, day, hour, min, seconds, UTC timezone
DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

// Ticks
DateTime dt = new DateTime(636370000000000000); 
DateTime.MinValue.Ticks;  //min value of ticks
DateTime.MaxValue.Ticks; // max value of ticks

// Static Fields
DateTime currentDateTime = DateTime.Now;  //returns current date and time
DateTime todaysDate = DateTime.Today; // returns today's date
DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

// TimeSpan
DateTime dt = new DateTime(2015, 12, 31);
           
TimeSpan ts = new TimeSpan(25,20,55);
 
DateTime newDate = dt.Add(ts);

Console.WriteLine(newDate);//1/1/2016 1:20:55 AM

// Subtract Dates
DateTime dt1 = new DateTime(2015, 12, 31); 
DateTime dt2 = new DateTime(2016, 2, 2);
TimeSpan result = dt2.Subtract(dt1);//33.00:00:00

// Operators
DateTime dt1 = new DateTime(2015, 12, 20);
DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20); 
TimeSpan time = new TimeSpan(10, 5, 25, 50);

Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
Console.WriteLine(dt2 - dt1); //377.05:10:20
Console.WriteLine(dt1 == dt2); //False
Console.WriteLine(dt1 != dt2); //True
Console.WriteLine(dt1 > dt2); //False
Console.WriteLine(dt1 < dt2); //True
Console.WriteLine(dt1 >= dt2); //False
Console.WriteLine(dt1 <= dt2);//True

// Convert String to DateTime
// Parse()
// ParseExact()
// TryParse()
// TryParseExact()

var str = "5/12/2020";
DateTime dt;
            
var isValidDate = DateTime.TryParse(str, out dt);

if(isValidDate)
    Console.WriteLine(dt);
else
    Console.WriteLine($"{str} is not a valid date string");