using System;
using System.IO;
namespace ConsoleApp2
{
    //Write a program in C# Sharp to read a specific line from a file.
    class Program
    {
        static void Main()
        {
            string file = "filename.txt";
            string[] arrayOfLines;
            int x, i, z;



            if(File.Exists(file))
            {
                File.Delete(file);
            }



            Console.WriteLine("Podaj numer linijek ktore mamy wpisac do pliku:\n");

            x = Convert.ToInt32(Console.ReadLine());
            arrayOfLines = new string[x];
      
            for(i=0;i<x;i++)
            {
                Console.Write("Podaj tresc {0} linijki\n", i+1);
                arrayOfLines[i] = Console.ReadLine();

            }

            System.IO.File.WriteAllLines(file, arrayOfLines);

            Console.Write("Podaj numer linijki ktorą chcesz wyswietlic\n");
            z = Convert.ToInt32(Console.ReadLine());
            if(z>=1&&z<=x)
            {
                if(File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    Console.WriteLine("{0}", lines[z - 1]);

                }
            }
            else
            {
                Console.Write("nieprawidłowy numer linijki ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
