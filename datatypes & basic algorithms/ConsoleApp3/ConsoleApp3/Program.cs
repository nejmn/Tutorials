using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    //Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4.
    class Program
    {

        static void Main(string[] args)
        {

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(65);
        numbers.Add(5);
        numbers.Add(4);
        numbers.Add(2);
        numbers.Add(54);
        numbers.Add(7);
        numbers.Add(-855454);

            List<int> list = Check(numbers);

            foreach(var i in list)
            {
            Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }


        public static List<int> Check(List<int>numbers)
        {
            return numbers.Where(n => n < 4).ToList();
        }
    }
}
