using System;
using System.IO;
using System.Text;
namespace ConsoleApp1
{
    //Write a program in C# Sharp to create a blank file in the disk newly. 
    class Program
    {
        static void Main()
        {

            string file = @"test.txt";


            try
            {

                using (FileStream fileStream = File.Create(file))
                {
                Console.WriteLine("Został stworzony plik o nazwie{0}",file);
                }
            }
            catch(Exception exeption)
            {
                Console.WriteLine(exeption.ToString());
            }
            
        }
    }
}
