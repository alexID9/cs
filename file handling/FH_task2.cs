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

        DirectoryInfo currDir = new DirectoryInfo(@"/home/aignatova24/senior");
        currDir.Create();

        var file = $"{currDir}/IgnatovaA.txt";
        string info;

        info = Console.ReadLine();

        while(info.Contains("like")){
          info = info.Replace("like ", "");
        }
        File.WriteAllText(file, info);
    }

}
