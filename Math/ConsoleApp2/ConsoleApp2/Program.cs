using System;
using System.Linq;

namespace ConsoleApp2
{
    //Write a C# Sharp program to reverse the binary representation of an given integer and convert the reversed binary number into an integer.


    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Liczba:"+x);
            Console.WriteLine("Liczba ktora powstanie po odwroceniu liczby binarnej:" +ReverseBinary(x));

            int y = 100;
            Console.WriteLine("Liczba:" + y);
            Console.WriteLine("Liczba ktora powstanie po odwroceniu liczby binarnej:" + ReverseBinary(y));

            int z = 0;
            Console.WriteLine("Liczba:" + z);
            Console.WriteLine("Liczba ktora powstanie po odwroceniu liczby binarnej:" + ReverseBinary(z));

            int b = 1534;
            Console.WriteLine("Liczba:" +b);
            Console.WriteLine("Liczba ktora powstanie po odwroceniu liczby binarnej:" + ReverseBinary(b));

            int a = 254;
            Console.WriteLine("Liczba:" + a);
            Console.WriteLine("Liczba ktora powstanie po odwroceniu liczby binarnej:" + ReverseBinary(a));
            Console.ReadLine();
        }


        public static int ReverseBinary(int number)
        {
            return (Convert.ToInt32(new string(Convert.ToString(number, 2).Reverse().ToArray()), 2));
        }
    }
}
