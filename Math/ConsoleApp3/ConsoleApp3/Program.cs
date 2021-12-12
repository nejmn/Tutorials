using System;

namespace ConsoleApp3
{
    //Given two dates - first from the past and second as present date, write a method that returns numbers of days between these two dates.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check(new DateTime(1998,10,26),DateTime.Now));
            Console.Read();
        }

        public static int Check(DateTime date1,DateTime date2)
        {
            return (date1 - date2).Days;
        }
    }
}
