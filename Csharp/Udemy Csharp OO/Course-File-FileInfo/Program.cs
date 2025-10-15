

string path = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File1.txt";

Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());


// string path = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples";

// try
// {
//     var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//     Console.WriteLine("Folders: ");
//     foreach (string s in folders)
//     {
//         Console.WriteLine(s);
//     }
    
//     var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//     Console.WriteLine("Files: ");
//     foreach (string s in files)
//     {
//         Console.WriteLine(s);
//     }

//     Directory.CreateDirectory(path + "\\newfolder");
// }
// catch (IOException e)
// {
//     Console.WriteLine("An error ocurred: ");
//     Console.WriteLine(e.Message);
// }

// string sourcePath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File1.txt";
// string targetPath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File2.txt";

// try
// {
//     string[] lines = File.ReadAllLines(sourcePath);

//     using (StreamWriter sw = new StreamWriter(targetPath, false))
//     {
//         foreach (string line in lines)
//         {
//             sw.WriteLine(line.ToUpper());
//         }
//     }

//     }
//     catch (IOException e)
//     {  Console.WriteLine("An error ocurred: ");
//    Console.WriteLine(e.Message); 
// }

// string path = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File1.txt";

// try
// {
    
    
//         using (StreamReader sr = File.OpenText(path))
//         {
//             while (!sr.EndOfStream)
//             {
//                 string line = sr.ReadLine();
//                 Console.WriteLine(line);
//             }
//         }
    
// }
// catch (IOException e)
// {
//     Console.WriteLine("An error ocurred: ");
//     Console.WriteLine(e.Message);
// }

// string path = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File1.txt";

// StreamReader sr = null;
// try
// {
//     sr = File.OpenText(path);

//     while (!sr.EndOfStream)
//     {
//         string line = sr.ReadLine();
//         Console.WriteLine(line);
//     }

// }
// catch (IOException e)
// {
//     Console.WriteLine("An error ocurred: ");
//     Console.WriteLine(e.Message);
// }
// finally
// {
//     if (sr != null) sr.Close();
// }

// using System.IO;
// string sourcePath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File1.txt";
// string targetPath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\File2.txt";

// try
// {
//     FileInfo fileinfo = new FileInfo(sourcePath);
//     fileinfo.CopyTo(targetPath);
//     string[] lines = File.ReadAllLines(sourcePath);
//     foreach (string line in lines)
//     {
//         Console.WriteLine(line);
//     }

// }
// catch (IOException e)
// {
//     Console.WriteLine("An error ocurred: " + e.Message);
// }