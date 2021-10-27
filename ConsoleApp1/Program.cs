using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public class Class1
{
    static void Main()
    {
        string ulaz = @"d:\ulaz";
        string izlaz = @"d:\izlaz\";

        string[] mapa = Directory.GetFiles(ulaz);

        foreach (var datoteka in mapa)
        {
            Console.WriteLine(datoteka.Remove(0,8));
            string imeDat = datoteka.Substring(ulaz.Length + 1);
            File.Copy(Path.Combine(ulaz, imeDat), Path.Combine(izlaz, imeDat), true);
            Console.WriteLine(imeDat + " kopirano");
        }

        Console.WriteLine("\n Kraj kopiranja!");
        Console.ReadLine();

    }
}
