using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
//    Write a program in C# Sharp to generate a cartesian product of three sets.
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4 };
            char[] characters = { 'A', 'B', 'C' };
            string[] words = { "alfa", "omega" };


            var cartProd = from number in numbers
                           from character in characters
                           from word in words
                           select new { word, character,number};






            Console.WriteLine("Iloczyn lartezjański wyglada nastepujaco:\n");
            foreach(var product in cartProd)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
