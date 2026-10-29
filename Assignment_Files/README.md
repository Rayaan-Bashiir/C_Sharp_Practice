# Assignment Files

## Introduction
In this assignment I practiced working with text files in C#.
The app has three buttons: Creating New File, Other Reading, and
Delete File. The result is shown in a ListBox.

## Design
The form has 3 buttons and 1 ListBox.



![Design](Screenshots/design.png)



## 1. Creating a New File
I used the `StreamWriter` class with `File.CreateText()` to create
the file `Index.txt`. `WriteLine()` writes each line and `Close()`
saves the file.

```csharp
StreamWriter outputFile = File.CreateText(path);
outputFile.WriteLine("Welcome Jamhuuriya");
outputFile.WriteLine("Welcome CA242 & CA244");
outputFile.WriteLine("Files are easy");
outputFile.Close();
```



![Create code](Screenshots/create-code.png)




![Create result](Screenshots/create-result.png)



## 2. Reading the File (new function)
Instead of `Read()`, `ReadLine()` or `ReadToEnd()`, I used
`File.ReadAllLines()`. It reads all lines into a string array, and
a `foreach` loop adds each line to the ListBox. `File.Exists()`
checks that the file is there first.

```csharp
string[] lines = File.ReadAllLines(path);
foreach (string line in lines)
{
    listBox1.Items.Add(line);
}
```



![Read code](Screenshots/read-code.png)




![Read result](Screenshots/read-result.png)



## 3. Deleting the File
`File.Exists()` checks the file, then `File.Delete()` removes it.

```csharp
if (File.Exists(path))
{
    File.Delete(path);
    MessageBox.Show("File deleted");
}
```



![Delete code](Screenshots/delete-code.png)




![Delete result](Screenshots/delete-result.png)



After deleting, pressing Other Reading shows "File does not exist",
which proves the file was removed.



![Not exist](Screenshots/file-not-exist.png)



## Conclusion
I learned how to create, read and delete text files in C# using
StreamWriter, File.ReadAllLines() and File.Delete().