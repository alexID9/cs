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

        DirectoryInfo currDir = new DirectoryInfo(@"/home/aignatova24/senior/student");
        currDir.Create();

        Console.WriteLine("name:");
        var file = $"{currDir}/{Console.ReadLine()}.txt";
        string[] info = new string[5];

        Console.WriteLine("class/section");
        info[0] = Console.ReadLine();
        Console.WriteLine("profile");
        info[1] = Console.ReadLine();
        Console.WriteLine("gpa");
        info[2] = Console.ReadLine();

        File.WriteAllLines(file, info) ;

        foreach (string s in info) {
          Console.WriteLine(s);
        }

    }

}
