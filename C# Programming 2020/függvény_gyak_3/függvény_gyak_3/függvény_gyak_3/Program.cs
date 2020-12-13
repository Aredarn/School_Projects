using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvény_gyak_3
{
    class Program
    {
        // Írjon függvényt, ami két szám mértani átlagát számolja ki! (m_atlag)

        static double m_atlag(double a, double b)
        {
            return Math.Sqrt(a * b);
        }

        // Írjon függvényt, ami egy pozitív egész számról megállapítja, hogy prímszám-e! (prim_e)

        static bool prim_e(int a)
        {
            int i;
            for (i = 2; i < a; i++)
                if (a % i == 0)
                    return false;
            return true;


        }

        // Írjon függvényt, ami megszámolja, hogy egy tömbben két megadott érték között hány szám van! (db_kozott)

        /* static int db_kozott(double[] t, int a, int b)
         {
             try
             {
                 int i, között = 0;
                 for (i = a; i < b; i++)
                     között++;
                 return között;
             }
                
         }
        */


        // Írjon függvényt, ami egy sztinget kiír visszafelé! (vissza)

        static void vissza(string a)
        {
            int i;
            for (i = a.Length - 1; i > 0; i--)
                Console.Write(a[i]);              
        }


        static void Main(string[] args)
        {
            // m_atlag fgv. tesztelése:
            double sz1 = 12.8;
            double sz2 = 73.3;

            Console.WriteLine(m_atlag(sz1, sz2));           

            // prim_e fgv. tesztelése:
            int szam = 49;

            if(prim_e(szam))
                Console.WriteLine("A szám prím");
            else
                Console.WriteLine("A szám nem prím");


            // db_kozott fgv. tesztelése:
            double[] szamok = { 4, 3, 4, 7.2, 69, 25, 40, 37, 9.5, 16, 99, 43, 44, 8.7, 62 };

           // Console.WriteLine(db_kozott(szamok, 2, 5));


            // vissza fgv. tesztelése:
            string vsz = "A programozás jó! :)";

            vissza(vsz);


            Console.ReadKey();
        }
    }
}
