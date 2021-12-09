using System;
using System.Text;
namespace ConsoleApp1
{
    //Write a C# Sharp program to determine the sign of a single value and display it to the console.
    class Program
    {
        static void Main()
        {
            int integer=-789;
            float float1 = 23.34f;
            byte byte1 = 0;
            long long1 = -4;
            double double1=2.2;
            Console.WriteLine("{0} {1}\n",integer,Check(Math.Sign(integer)));
            Console.WriteLine("{0} {1}\n", float1, Check(Math.Sign(float1)));
            Console.WriteLine("{0} {1}\n", byte1, Check(Math.Sign(byte1)));
            Console.WriteLine("{0} {1}\n", long1, Check(Math.Sign(long1)));
            Console.WriteLine("{0} {1}\n", double1, Check(Math.Sign(double1)));
            Console.ReadLine();
        }



        public static string Check(int value)
        {
            if (value == 0) return "jest równe zero";
            else if (value < 0) return "jest mniejsze od zera";
            else return "jest wieksze od zera";
        }

    }
}
