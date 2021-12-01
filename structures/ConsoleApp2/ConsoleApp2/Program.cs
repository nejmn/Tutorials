using System;

namespace ConsoleApp2
{
        struct ksiązka
        {
            public string tytul;
            public string autor;
            public int rokwydania;
        }
    //Write a program in C# Sharp to insert the information of two books.
    class Program
    {
       

        static void Main()
        {
            int numerksiazek = 1000;
            ksiązka[] ksiazki = new ksiązka[numerksiazek];
            int x, y, z = 1, a = 1;

            for(x=0;x<=z;x++)
            {
                Console.WriteLine("Ksiazka numer {0} :", a);
                Console.WriteLine("Wprowadz tytuł ksiazki:");
                ksiazki[x].tytul =Console.ReadLine();

                Console.WriteLine("Wprowadz autora ksiazki:");
                ksiazki[x].autor = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Wprowadz rok wydania ksiazki:");
                ksiazki[x].rokwydania = Console.Read();
                a++;
                Console.WriteLine();
            }

            for(y=0;y<=z;y++)
            {
                Console.WriteLine("{0}. Tytuł={1}, Autor={2},Rok wydania={3}\n", x + 1, ksiazki[x].tytul, ksiazki[x].autor, ksiazki[x].rokwydania);
                Console.WriteLine();
                Console.Read();
            }
           
        }
    }
}
