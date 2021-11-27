using System;

namespace ConsoleApp1
{
    /*Write a program in C# Sharp to display the pattern like right angle triangle with a number.

Sample Output:

1
12
123
1234*/
    class Program
    {
        public static void Main()
        {
      
            int i, j, w;
            
            Console.WriteLine("Podaj wysokosc trójkąta:");
            w = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= w; i++)
            {

                for (j=1;j<=i;j++)
                
                    Console.Write("{0}", j);
                    Console.Write("\n");
                

               

            }
            Console.Read();
        }
 
    }
}
