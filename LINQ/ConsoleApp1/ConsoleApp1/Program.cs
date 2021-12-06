using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
{
    //Write a program in C# Sharp to shows how the three parts of a query operation execute.
    class Program
    {
        static void Main()
        {

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var Query = from num in numbers
                        where (num % 2) == 0
                        select num;




            Console.WriteLine("Numery podzielne przez 0 z podanego zbioru liczb to:\n");
            foreach(int num in Query)
            {
                Console.WriteLine("{0}", num);
            }

            Console.Read();
        }
    }
}
