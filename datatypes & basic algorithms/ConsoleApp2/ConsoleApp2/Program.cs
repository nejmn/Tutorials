using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 55, 16, 5, 5, 1, 6, 5 };
            int[] newarray = Check(array);

            foreach (var i in newarray)
            {
            Console.Write(i.ToString()+" ");
            
            
            }
          Console.ReadLine();
        }


        static int[] Check( int[] oldarray)
        {
            int[] newarray;

            if (oldarray.Length < 2)
            {
                newarray = oldarray;
       
            }
            else if(oldarray.Length>=2)
            {
            newarray = new int[]{ oldarray[0], oldarray[1] };

            }
            else
            {
                newarray = new int[0];
            }
            return newarray;
        }

    }
}
