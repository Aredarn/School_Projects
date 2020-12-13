using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvény_osztály_gyak_5
{
    // Készítsen egy Fröccs osztályt, amelynek adattagjai: név, bor (dl-ben), szóda (dl-ben), ár.
    // Konstruktorok:
    //     Egy darab általános konstruktor van: 
    //     minden adattagot paraméterlistán keresztül adunk át.
    //     
    // Metódusok: 
    // Az mennyiség metódus adja vissza, hogy hány dl az egész fröccs! 
    //
    // Legyen árváltozás metódus, amiben adott százalékkal emeljük vagy csökkentjük az árat! 
    // (pl. a 12 12%-os e,elést jelent, a -5 pedig 5%-os csökkentést.)
    //
    // Készíts toString metódust, ami által visszaadott string tartalmazza a fröccs nevét, összetételét és árát!
    class Fröccs
    {
        //Adattagok:
        public string név;
        public int bor, szóda, ár;

        //általános konstruktor
        public Fröccs(string a, int b, int sz, int á)
        {
            név = a;
            bor = b;
            szóda = sz;
            ár = á;
        }

        //metódusok
        public int Mennyiség()
        {
            return szóda + bor;
        }

        public void Árváltozás(int a)
        {
            ár = (int)((1 + a / 100.0 )* ár);
        }

        public void toString()
        {
            Console.WriteLine($"A {név} fröccsben {bor}dl bor és {szóda}dl szóda van, ami {ár}ft ba kerül");
        }

    }


    class Program
    {
        // Írjon függvényt, ami egy szám valahányadik gyökével tér vissza! (n_gyök)
        static double n_gyök(double szám, double n)
        {
            return Math.Pow(szám, 1 / n);
        }

        // Írjon függvényt, ami egy double tömb azon elemeit összegzi, amik egy paraméterben megadott számnál nagyobbak! (n_összeg)
        static double n_összeg(int[] t, double szám)
        {
            double összeg = 0;

           /* for(int i=0; i<t.Length; i++)
            {
                if (t[i] < szám)
                    összeg += t[i];
            }
           */
            foreach (double x in t)
                if (x > szám)
                    összeg += x;


            return összeg;
        }       

        // Írjon függvényt, ami egy szöveg elejéről visszaad valahány karaktert! Ha a megadott szám nagyobb a szöveg hosszánál, akkor a teljes szöveget adja vissza. (start_st)

        static string start_st(string st, int n)
        {
            if (st.Length > n)
                return st.Substring(0, n);
            else
                return st;
        }


        static void Main(string[] args)
        {
            // A Fröccs osztály tesztelése:
            Console.WriteLine("A Fröccs osztály tesztelése:\n");
            // Hozzon létre két Fröccs objektumot!
            // Tesztelje a metódusokat különböző esetekben! Futás közben kellő információ is jelenjen meg!
            Fröccs fröccs1 = new Fröccs("kisfröccs", 2, 2, 600);
            Fröccs fröccs2 = new Fröccs("nagyfröccs", 4, 2, 800);

            Console.WriteLine(fröccs1.név + ": " + fröccs1.Mennyiség() + "dl");
            fröccs1.toString();
            fröccs1.Árváltozás(17);
            fröccs1.toString();

            /************* Függvények tesztelése *************/
            // Az n_gyök függvény tesztelése:
            Console.WriteLine("\nAz n_gyök függvény tesztelése:\n");
            double alap = 371293;
            double gyöke = 5;

            double eredmény = n_gyök(alap, gyöke);
            Console.WriteLine(eredmény);

            // Az n_összeg függvény tesztelése:
            Console.WriteLine("\nAz n_összeg függvény tesztelése:\n");
            int[] tömb = { 25, 36, 145, 74, 5, 98, 34, 262, 77, 92, 213, 164, 85, 6, 330, 71, 96 };

            double összeg = n_összeg(tömb, 34);

            // Az start_st függvény tesztelése:
            Console.WriteLine("\nA start_st függvény tesztelése:\n");
            string szöveg = "Valamilyen szöveg.";

            Console.WriteLine(start_st(szöveg, 4));

            Console.ReadKey();
        }
    }
}
