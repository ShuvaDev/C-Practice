using System.Text;

var fileName = "demo.txt";

/*
if(File.Exists(fileName))
    File.Delete(fileName);

File.WriteAllText(fileName, """
Test
String
""");


// Copy one file content to another file 
if(File.Exists("test.txt"))
{
    File.Delete("test.txt");
}
File.Copy(fileName, "test.txt");

string content = File.ReadAllText("test.txt");
Console.WriteLine(content);
*/

// Object oriented approach to work with file
/*
FileInfo fileInfo = new FileInfo(fileName);
if(fileInfo.Exists)
{
    //Console.WriteLine(fileInfo.FullName);
    fileInfo.Delete();
}

using (FileStream stream = fileInfo.Open(FileMode.OpenOrCreate))
{
    string streamContent = "This is a text";
    byte[] bytes = Encoding.UTF8.GetBytes(streamContent);

    stream.Write(bytes, 0, 6);
}

using (FileStream stream = fileInfo.Open(FileMode.Open))
{
    byte[] bytes = new byte[1];
    for(int i = 0; i < fileInfo.Length; i++)
    {
        stream.Read(bytes, 0, 1);
        Console.WriteLine(Encoding.UTF8.GetString(bytes));
    }
}
*/

// Working With Directory
/*
var folderName = "All Files";
Directory.CreateDirectory(folderName);

if(Directory.Exists(folderName))
{
    Directory.Delete(folderName, true);
}
*/

/*
DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
string pathForFiles = di.Parent.Parent.Parent.FullName;

string fullPath = Path.Combine(pathForFiles, "MyFolder");

Directory.CreateDirectory(fullPath);

foreach(var file in di.GetFiles("*.json"))
{
    Console.WriteLine(file.Name);
}
*/


/*
FileInfo fi = new FileInfo(fileName);
FileStream stream = fi.Open(FileMode.OpenOrCreate);

byte[] bytes = new byte[1];

for(int i = 0; i < fi.Length; i++)
{
    stream.Read(bytes, 0, 1);
    Console.Write(Encoding.UTF8.GetString(bytes));
}
*/

/*
Task - 01
In this task you have to create a large text file of random letters. Size of this file has to be 5 MB. 
You have to calculate how many characters you need to put in this file to make it 5 MB. You have to 
write the file content byte by byte. You have to put the created file alongside the solution file 
(outside of the project folder).
*/

/*
DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
string path = di.Parent.Parent.Parent.Parent.FullName;

string filePath = Path.Combine(path, "task1.txt");

FileInfo fi = new FileInfo(filePath);
FileStream stream = fi.Open(FileMode.Create);

for(long i = 1; i <= 5242880; i++)
{
    byte[] bytes;
    Random random = new Random();

    string randChar = "" + Convert.ToChar(random.Next(97, 123));
    bytes = Encoding.UTF8.GetBytes(randChar);

    stream.Write(bytes, 0, 1);
}
stream.Close();
*/

/*
Task - 02
In this task, you have to split the file created in task 1. You have to take 1 MB from the file and
create another file with the content. Next 1 MB in another file and so on. If there is a
possibility of more than 10 files to put all the contents of the original file, then you have to put 10
files in a folder. You have to create a folder with names such as: “Folder1”, “Folder2”, “Folder3”
etc. These folders and files should be inside the project folder.
*/

/*
DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());

string destPath = di.Parent.Parent.Parent.Parent.FullName;

string destFilePath = Path.Combine(destPath, "task1.txt");
Console.WriteLine(destFilePath);

FileInfo destFileInfo = new FileInfo(destFilePath);
FileStream destStream = destFileInfo.Open(FileMode.Open);


for (int i = 1; i <= destFileInfo.Length / 1048576; i++)
{
    byte[] bytes = new byte[1048576];
    destStream.Read(bytes, 0, 1048576);

    string srcPath = di.Parent.Parent.Parent.FullName;
    Directory.CreateDirectory(srcPath + $"/Folder{i}");

    string srcFilePath = Path.Combine(srcPath, $"Folder{i}/file.txt");
    Console.WriteLine();
    FileInfo srcFileInfo = new FileInfo(srcFilePath);
    FileStream srcFileStream = srcFileInfo.Open(FileMode.Create);

    srcFileStream.Write(bytes, 0, 1048576);
}
*/
