/*Sprawdź, które spośród danych liczb są liczbami pierwszymi
Input
n - liczba testów n<100000, w kolejnych liniach n liczb z przedziału [1..10000]
Output
Dla każdej liczby słowo TAK, jeśli liczba ta jest pierwsza, słowo: NIE, w przeciwnym wypadku.
Example
Input:
3
11
1
4
Output:
TAK
NIE
NIE*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine());
            string[] tab = new string [n];
            if (n < 10000 || n > -1)
            {
                for (int i = 0; i < n; i++)
                {
                    int w = 0;
                    int x = int.Parse(Console.ReadLine());
                    for (int j = 1; j < x; j++)
                    {

                        if (x % j == 0)
                        {
                            w=5;
                            break;
                        }
 
                    }

                    if (x == 1)
                    {
                        w = 5;
                    }


                    if (w > 1)
                       tab [i]="NIE";

                    else
                        tab[i] = "TAK";





                }
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine(tab[k]);
                    
                }
                //Console.WriteLine("ok");
                //while (true) ;
            }
            
        }
    }
}
