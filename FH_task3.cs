using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

class Test
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"/home/aignatova24/github/cs/");
        DirectoryInfo newDir = new DirectoryInfo(@"/home/aignatova24/github/cs/files");
        currDir.Create();
        newDir.Create();
        Console.WriteLine("say something");
        var file = $"{currDir}/text.txt";
        var newFile = $"{newDir}/newText.txt";
        string info;
        info = Console.ReadLine();
        File.AppendAllText(file, info);
        File.Move(file,newFile);
    }

}
