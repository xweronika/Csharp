/*Napisać program do dodawania dwóch liczb całkowitych. 
 * Na wejściu podane są w oddzielnych liniach dwie liczby 
 * naturalne A oraz B mniejsze od 200. Na wyjściu należy 
 * wypisać wartość ich sumy, A + B.
Przykład
Wejście
2
3
Wyjście
5*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > -1 && a < 201 && b > -1 && b < 201)
                Console.WriteLine((a + b));
               
        }
    }
}
