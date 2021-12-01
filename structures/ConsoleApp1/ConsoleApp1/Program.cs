using System;

namespace ConsoleApp1
{

    public struct numbers
    {
       public int x, y;
        public numbers(int num1,int num2)
        {
            x = num1;
            y = num2;
        }

    }


    class Program
    {
        static void Main()
        {
            numbers numbers1 = new numbers();
            numbers numbers2 = new numbers(2,2);

            Console.WriteLine("First set of numbers: x={0}, y={1}",numbers1.x,numbers1.y);
            Console.WriteLine("\nSecond set of numbers: x={0}, y={1}", numbers2.x, numbers2.y);
            Console.ReadLine();
        }
    }
}
