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
      var file = $"{currDir}/text.txt";
      string info;
      Console.WriteLine("say something");
      info = Console.ReadLine();
      File.AppendAllText(file, info);
      var copypasta = $"{currDir}/copy.txt";
      using (StreamReader str = new StreamReader("text.txt")){
        string s;
        while((s = str.ReadLine()) != null){
          File.AppendAllText(copypasta, s);
          Console.WriteLine(s);
        }
      }
    }
}
