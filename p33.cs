// Syntax:
// GenericTypeName<T> where T  : contraint1, constraint2

//  Declare Generic Constraints
class DataStore<T> where T : class
{
    public T Data { get; set; }
}

DataStore<string> store = new DataStore<string>(); // valid
DataStore<MyClass> store = new DataStore<MyClass>(); // valid
DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // valid
DataStore<IEnumerable> store = new DataStore<IMyInterface>(); // valid
DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
//DataStore<int> store = new DataStore<int>(); // compile-time error

// The following table lists the types of generic constraints
// class
// class?
// struct
// new()
// notnull
// unmanaged
// base class name
// <base class name>?
// <interface name>
// <interface name>?
// where T:U

// struct Constraints
class DataStore<T> where T : struct
{
    public T Data { get; set; }
}

DataStore<int> store = new DataStore<int>(); // valid
DataStore<char> store = new DataStore<char>(); // valid
DataStore<MyStruct> store = new DataStore<MyStruct>(); // valid
//DataStore<string> store = new DataStore<string>(); // compile-time error 
//DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error 
//DataStore<ArrayList> store = new DataStore<ArrayList>(); // compile-time error 

// new() Constraint
class DataStore<T> where T : class, new()
{
    public T Data { get; set; }
}

DataStore<MyClass> store = new DataStore<MyClass>(); // valid
DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
//DataStore<string> store = new DataStore<string>(); // compile-time error 
//DataStore<int> store = new DataStore<int>(); // compile-time error 
//DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error 

// BaseClass Constraint
class DataStore<T> where T : IEnumerable
{
    public T Data { get; set; }
}

DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
DataStore<List> store = new DataStore<List>(); // valid
//DataStore<string> store = new DataStore<string>(); // compile-time error 
//DataStore<int> store = new DataStore<int>(); // compile-time error 
//DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error 
//DataStore<MyClass> store = new DataStore<MyClass>(); // compile-time error 