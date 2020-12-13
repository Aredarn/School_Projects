using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Készítsen egy Szoba osztályt, amelynek adattagjai: szám (szoba száma), ágy (ágyak száma), ár (egy éjszaka ára), foglalt.
// Konstruktorok:
//     Általános konstruktor: az első három adattagot a paraméterlistából állítja be. Létrehozáskor a szoba még nem lesz foglalt.
//     Alapértelmezett konstruktor: nincs paraméter, a szám, ágy és ár 0, a foglalt pedig false lesz.
// Metódusok: 
// A foglalt_e metódus adja vissza, hogy foglalt-e a szoba! 
//
// Legyen egy szabad metódus, ami a szoba státuszát szabadra állítja!
//
// A kiad metódusnak legyen egy int paramétere, hogy hány napra adtuk ki aszobát.
// A függvény állítsa be a szobát foglaltra, és adja vissza a fizetendő összeget!
// Ha a szoba foglalt, akkor nem lehet kiadni. Ekkor a visszatérési érték -1 legyen!
//
// Készíts toString metódust, ami kiírja a szoba számát, foglalt-e, hány ágyas és mennyi az ára!

namespace függvény_osztály_gyak_4
{
    class Szoba
    {
        //Adattagok:
        public int szám, ágy, ár;
        public bool foglalt;

        Szoba()
        {
            szám = ágy = ár = 0;
            foglalt = false;
        }

        public Szoba(int a, int b, int c)
        {
            szám = a;
            ágy = b;
            ár = c;
            foglalt = false;
        }

        public bool foglal_e()
        {
            return foglalt;
        }

        public void szabad()
        {
            foglalt = false;
        }

        public int kiad(int nap)
        {
            if (foglalt)
                return -1;
            else
            {
                foglalt = true;
                return nap * ár;
            }
        }

        public string toString()
        {
            return "Szoba száma: " + ", " + ágy + " ágyas, ár: " + ár + "ft/éj";
        }


    }



    class Program
    {
        // Írjon függvényt, ami kiszámolja az út hosszából és 
        // a 100 km-enkénti fogyasztásból a teljes út alatti fogyasztásat! (fogyasztás)
        static double Fogyasztás(double út, double f)
        {
            return (út * f) / 100;
        }


        // Írjon függvényt, eldönti egy karakterről, hogy magyar ékezetes betű-e (á, é, í, ó, ö, ő, ú, ü, ű)! (ékezetes)

        static bool ékezetes(char betű)
        {
            if (betű == 'á' || betű == 'é' || betű == 'ó')
            {
                return true;
            }
            else 
                return false;
        }


        // Írjon függvényt, ami egy int tömb minden eleméhez hozzáad egy számot! (t_növel)
        static void t_növel(int[] tömb, int k)
        {
            for (int i = 0; i < tömb.Length; i++)
                tömb [i] = tömb[i] + k;
        }



        // Írjon függvényt, ami megfordít egy stringet! (fordít)

        static void fordít(string st)
        {
            for (int i = st.Length; i >= 0; --i)
                Console.Write(st[i]);

        }



        static void Main(string[] args)
        {
            // A Szoba osztály tesztelése:
            Console.WriteLine("A Szoba osztály tesztelése:\n");
            // Hozzon létre két szobát tetszőleges szobaszámmal. Az egyik legyen 2 szobás az ára 25000 Ft, a másik legyen 1 ágyas, az ára pedig 18500 Ft.
            // Tesztelje a metódusokat különböző esetekben!
            Szoba sz1 = new Szoba(224 ,5,1500);
            Szoba sz2 = new Szoba(321, 1, 18500);

            Console.WriteLine(sz1.foglal_e());

            Console.WriteLine(sz1.kiad(3));


            // A fogyasztás függvény tesztelése:
            Console.WriteLine("\nA fogyasztás függvény tesztelése:\n");
            int út = 249;
            double f_100 = 8.2;

            Console.WriteLine(Fogyasztás(út, f_100));


            // Az ékezetes függvény tesztelése:
            Console.WriteLine("\nAz ékezetes függvény tesztelése:\n");
            char ch = 'á';
            Console.WriteLine(ékezetes(ch));

            // Az t_növel függvény tesztelése:
            Console.WriteLine("\nAz t_növel függvény tesztelése:\n");
            int[] tömb = { 25, 36, 74, 5, 98, 34, 62, 77, 92, 13, 64, 85, 6, 30, 71, 96 };


            // A fordít függvény tesztelése:
            Console.WriteLine("\nA fordít függvény tesztelése:\n");
            string szöv = "Valamilyen szöveg.";

            fordít(szöv);

            Console.ReadKey();
        }
    }
}
