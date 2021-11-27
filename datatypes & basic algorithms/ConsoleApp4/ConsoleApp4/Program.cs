using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp4
{
    //Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 15,17,25,78,77,48,54,17});
            List<int> newlist = Check(list);
            foreach(var i in newlist)
            {
                Console.WriteLine(i.ToString());
            }

            Console.Read();
        }

        public static List<int>Check(List<int>numbers)
        {
            return numbers.Where(n => n%10 != 7).ToList();
        }
    }
}
