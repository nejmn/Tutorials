using System;

namespace ConsoleApp1
{

    //Write a C# Sharp program to create a new array of length 3
    //from a given array (length at least 3) using the elements from the middle of the array.
    class Exercise
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5,8,4,1,3,6,5,4,1,2,8,4,1,52,4};
            int[] newarray=TaketheMiddle(array);
            Console.Write("New array:");

            foreach (var i in newarray)
            {
                Console.Write(i.ToString() + " ");
            }
          
                Console.ReadLine();
            
        }

        static int[] TaketheMiddle(int[] oldarray)
        {
            return new int[] { oldarray[oldarray.Length/2-1],oldarray[oldarray.Length/2], oldarray[oldarray.Length/2+1] };
        }

    }
}
