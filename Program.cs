using System.Text;

//storing A.txt file path into Afilepath variable
var Afilepath = "E:/Promact/C#/Assignment5/A.txt";

//Reading A.txt file content and storing them into AfileItem variable asynchronously
using var sr = new StreamReader(new FileStream(Afilepath, FileMode.Open, FileAccess.Read), Encoding.UTF8);
string AfileItem = await sr.ReadToEndAsync();

//storing B.txt file path into Bfilepath variable
var Bfilepath = "E:/Promact/C#/Assignment5/B.txt";

//Copying content of A.txt into B.txt asynchronously
await File.WriteAllTextAsync(Bfilepath, AfileItem);

//Checking A.txt file is empty or not and Reading B.txt
if (File.ReadAllText("B.txt") != string.Empty)
{
    Console.WriteLine("Content of A.txt file : \n" + AfileItem);
    Console.WriteLine("\nB.txt file has been written Successfully! Kindly check out your B.txt file");
}
else
{
    Console.WriteLine("A.txt is empty. Nothing left to read or write.");
}