using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    //Write a program in C# Sharp to display the top nth records.
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 15, 5564, 1, 56, 45, 65, 71, 315,854, 65 };
            Console.WriteLine("Ile najwiuekszych wartosci chcesz zobaczyc?");
            int n = Convert.ToInt32(Console.ReadLine());
            list.Sort();
            list.Reverse();
            Console.WriteLine("{0} najwieksze wartosci to:\n",n);
            foreach (int record in list.Take(n))
            {
                Console.WriteLine(record);
            }

            Console.ReadLine();

        }
    }
}
