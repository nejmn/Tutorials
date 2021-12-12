using System;

namespace ConsoleApp4
{//Write a C# program to create a function to check whether a number is prime or not
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (Check(x))
            {
                Console.WriteLine(x + "jest liczba pierwsza");
                
            }
            else
            {
                Console.WriteLine(x + "nie jest liczba pierwsza");
            }
            Console.Read();
        }


        public static bool Check(int number)
        {
            for(int i=2;i<number;i++)
            
                if (number % i == 0)
                    return false;
              
                    return true;
            
        }
    }
}
