using System;

namespace ConsoleApp3
{
    //Write a C# Sharp program to calculate the factorial of a given number.
    class Program
    {
        static void Main(string[] args)
        {
            int i,j, x=1;


            Console.WriteLine("podaj liczbe");

        j = Convert.ToInt32(Console.ReadLine());
           
            for(i=1;i<=j;i++)
            {
                x = x * i;
            }
            Console.WriteLine("silnia twojego numer to: {0}",x);
            Console.ReadLine();
        }
    }
}
