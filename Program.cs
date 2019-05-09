/* Proste dodawanie
 W pierwszym wierszu znajduje się liczba t testów (0 < t < 100) 
Każdy test opisany jest w następujący sposób. 
W pierwszym wierszu dana jest liczba n - liczba liczb do zsumowania. 
Następnie podanych jest n liczb pooddzielanych spacją.
Przykład
Input:
2
5
1 2 3 4 5
2
-100 100
Output:
15
0 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++)
            {
                double n = double.Parse(Console.ReadLine());
                

                    string s = Console.ReadLine();
                    string[] tab = s.Split(' ');
                     double w=0;
                    for (int j = 0; j < n; j++) {
                          w += double.Parse(tab[j]) ;
                    }
                    Console.WriteLine(w);
                  // while (true) ;          
            }
            
        }
    }
}
