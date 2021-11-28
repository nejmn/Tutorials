using System;
public class Exercise58
{
    /*65. Write a C# Sharp program to display alphabet pattern like H with an asterisk.

Display the pattern like 'H' with an asterisk:                                      
---------------------------------------------                                    
                                                                                 
 *   *                                                                           
 *   *                                                                           
 *   *                                                                           
 *****                                                                           
 *   *                                                                           
 *   *                                                                           
 *   * */
    public static void Main()
    {
        int rzad,kolumna;

    

        for (rzad = 0; rzad <= 7; rzad++)
        {
            for (kolumna = 0; kolumna <= 7; kolumna++)
            {
                if (((kolumna == 1 || kolumna == 5)) ||
                     ((rzad == 4) && (kolumna > 1 && kolumna < 5)))
              Console.Write("*");
                else
                   Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
        Console.Read();
    }
}