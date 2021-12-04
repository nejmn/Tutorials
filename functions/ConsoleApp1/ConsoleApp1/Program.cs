using System;

namespace ConsoleApp1
{
    //Write a program in C# Sharp to calculate the sum of elements in an array.


    class Program
    {
        public static int Sum(int[] array)
        {
            int suma = 0;
            for(int i=0;i<array.Length;i++)
            {
                suma += array[i];
               
            }
            return suma;
        }
        static void Main()
        {
            int[] array = new int[5];
            for(int j=0;j<5;j++)
            {
                Console.WriteLine("element-{0}:",j+1);
                array[j] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("Suma tych 5 liczb to:{0}", Sum(array));
            Console.Read();
        }
    }
}
