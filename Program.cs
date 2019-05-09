/*CALC - Kalkulator
Napisz program, który działa jak prosty kalkulator obsługujący pięć operacji: dodawanie, 
odejmowanie, mnożenie, dzielenie i obliczanie reszty z dzielenia liczb całkowitych.

Wejście
Na wejście programu podana zostanie pewna nieokreślona liczba zestawów danych. 
Zestawy składają się z jednoznakowego symbolu operacji do wykonania (+ dodawanie, 
- odejmowanie, * mnożenie, / dzielenie całkowitoliczbowe, % reszta z dzielenia) 
oraz następujących po nim dwóch liczb całkowitych. Poszczególne składowe zestawu 
zostaną rozdzielone spacjami, a same zestawy znakiem nowej linii. Liczba testów 
nie przekracza 100, wynik zawiera się w typie int32.

Wyjście
Na wyjściu programu ma się pojawić ciąg liczb będących rezultatem wykonania 
pojawiających się na wejściu poleceń. Poszczególne liczby należy rozdzielić 
znakami nowej linii. Uwaga! Można założyć, że dane wejściowe nie zawierają 
polecenia dzielenia przez 0.

Przykład
Wejście:
+ 7 9
- 0 4
* 5 6
/ 8 3
% 5 2

Wyjście:
16
-4
30
2
1*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            do
            {
                
                string s = Console.ReadLine();
                if (s == null || s.Length < 1) break;
                string[] tab = s.Split(' ');
                Int32 x = 0;


                if(tab.Length == 3)
                {
                    if (tab[0] == "+")
                        x = (int.Parse(tab[1]) + int.Parse(tab[2]));

                    else if (tab[0] == "-")
                        x = (int.Parse(tab[1]) - int.Parse(tab[2]));

                    else if (tab[0] == "*")
                        x = (int.Parse(tab[1]) * int.Parse(tab[2]));

                    else if (tab[0] == "/")
                        x = (int.Parse(tab[1]) / int.Parse(tab[2]));

                    else if (tab[0] == "%")
                        x = (int.Parse(tab[1]) % int.Parse(tab[2]));
                    else
                        continue;

                    Console.WriteLine(x);
                }


                // while (true) ;

                k++;
            } while (k<100);
            


        }
    }
}
