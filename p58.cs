// Important Properties and Methods of FileInfo

// Property
// Directory
// DirectoryName
// Exists
// Extension
// FullName
// IsReadOnly
// LastAccessTime
// LastWriteTime
// Length
// Name

// Method
// AppendText
// CopyTo
// Create
// CreateText
// Decrypt
// Delete
// Encrypt
// GetAccessControl
// MoveTo
// Open
// OpenRead
// OpenText
// OpenWrite
// Replace
// ToString

// Read file using FileInfo class
//Create object of FileInfo for specified path
FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

//Open file for Read\Write
FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

//create byte array of same size as FileStream length
byte[] fileBytes = new byte[fs.Length];

//define counter to check how much bytes to read. Decrease the counter as you read each byte
int numBytesToRead = (int)fileBytes.Length;

//Counter to indicate number of bytes already read
int numBytesRead = 0;

//iterate till all the bytes read from FileStream
while (numBytesToRead > 0)
{
    int n = fs.Read(fileBytes, numBytesRead, numBytesToRead);

    if (n == 0)
        break;

    numBytesRead += n;
    numBytesToRead -= n;
}

//Once you read all the bytes from FileStream, you can convert it into string using UTF8 encoding
string filestring = Encoding.UTF8.GetString(fileBytes);

// Read file using StreamReader
//Create object of FileInfo for specified path
FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

//Open file for Read\Write
FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

//Create object of StreamReader by passing FileStream object on which it needs to operates on
StreamReader sr = new StreamReader(fs);

//Use ReadToEnd method to read all the content from file
string fileContent = sr.ReadToEnd();

//Close StreamReader object after operation
sr.Close();
fs.Close();

// Write texts to file using StreamWriter
//Create object of FileInfo for specified path
FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

//Open file for Read\Write
FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

//Create StreamWriter object to write string to FileSream
StreamWriter sw = new StreamWriter(fs);
sw.WriteLine("Another line from streamwriter");
sw.Close();

// StreamReader & StreamWriter
//Create FileInfo object for DummyFile.txt
FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

//open DummyFile.txt for read operation
FileStream fsToRead = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

//open DummyFile.txt for write operation
FileStream fsToWrite = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

//get the StreamReader

StreamReader sr = new StreamReader(fsToRead);

//read all texts using StreamReader object
string fileContent = sr.ReadToEnd();
sr.Close();

//get the StreamWriter
StreamWriter sw = new StreamWriter(fsToWrite);

//write some text using StreamWriter
sw.WriteLine("Another line from streamwriter");
sw.Close();

//close all Stream objects
fsToRead.Close();
fsToWrite.Close();


