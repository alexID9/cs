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
      DirectoryInfo currDir = new DirectoryInfo(@"/home/aignatova24/github/cs");
      currDir.Create();
      var file = $"{currDir}/test.txt";
      string info;
      Console.WriteLine("say something");
      info = Console.ReadLine();
      File.AppendAllText(file, info);
      File.Move("test.txt","tester.txt");
    }
}
