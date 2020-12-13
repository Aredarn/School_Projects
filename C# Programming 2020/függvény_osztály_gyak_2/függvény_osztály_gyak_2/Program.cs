using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvény_osztály_gyak_2
{
    // Készítsen Százlábú osztályt, amelynek adattagjai: név, lábszám (int), energia (int).
    // Legyen két konstruktor, az egyik üres paraméterlistával, a másikkal pedig nevet lehet adni.  
    // Az első esetben a név legyen üres string, valamint mindkét konstruktor állítsa be a lábak szmát 100-ra, az energiaszintet 500-ra.
    //
    // Metódusok: kiíró fgv, az állatka adatait írja ki.
    //            lábvesztés fgv, a paraméterben megadott számú lábát elveszti az állat. (Veszályes világban élümk, sok a baleset.)
    //            Természetesen a lábak száma nem mehet 0 alá, paraméterként pedig nem fogadunk el negatív számot!
    //            eszik fgv., minden adaggal nől az energiája, de a maximum 1000 lehet!
    //            dolgozik fgv, minden munkaegységgel csökken az energiája.
    //
    //            + feladat: Ha az étkezés végén 975-nél magasabb az energiaszintje, akkor vissza tud növeszteni egy lábát.
    //            Ez viszont 350 egységnyi energiaveszteséggel jár.

    class Százlábú
    {
        //adattagok:
        public string név;
        public int lábszám, energiaszint;
        
        //Konstruktorok:
        public Százlábú()
        {
            név = "";
            lábszám = 100;
            energiaszint = 500;
        }
        public Százlábú(string p_név)
        {
            név = p_név;
            lábszám = 100;
            energiaszint = 500;
        }
        //Metódusok:
        public void kiír()
        {
            Console.WriteLine("\nNév: " + név);
            Console.WriteLine("Lábak száma: " + lábszám);
            Console.WriteLine("Energiaszint: " + energiaszint);
        }

        public void lábvesztés(int p)
        {
            if (p < 0) return;
            lábszám = lábszám - p;
            if (lábszám < 0)
                lábszám = 0;



        }

        public void eszik(int p)
        {
            energiaszint = energiaszint + p;
            if (energiaszint > 1000)
                energiaszint = 1000;

            if (lábszám < 100 && energiaszint >= 975)
                lábszám += 1;
        }

        public void dolgozik(int p)
        {
            energiaszint -= p;
            if (energiaszint < 0)
                energiaszint = 0;
        }
    }



    class Program
    {
        // Írjon függvényt atlo néven, amely kiszámítja egy téglalap átlójának hosszát!
        static double atlo(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }


        // Írjon függvényt, ami egy évszámról megállapítja, hogy szökőév-e! (szokoev)
        static bool szokoev(int év)
        {
            if ((év % 4 == 0 && év%100 != 0) || év%400==0)
                return true;
            else
                return false;
        }


        // Írjon függvényt, ami megadja, hogy egy stringben egy adott karakterből hány darab van! (betu_db)
        static int betu_db(string st, char ch)
        {
            int db = 0;
            for (int i = 0; i < st.Length; i++) 
               if(st[i] == ch) 
                    ++db;
            return db;
            
        }


        // Írjon függvényt, amely egy double tömbben összegzi a pozitív számokat! (poz_ossz)
        static double poz_ossz(double[] t)
        {
            double összeg = 0;
            int i;
            for (i = 0; i < t.Length - 1 ; i++)
                if (t[i] > 0)
                    összeg = összeg + t[i];

            return összeg;
        }

        static void Main(string[] args)
        {
            // A Százlábú osztály tesztelése:
            Console.WriteLine("A Százlábú osztály tesztelése:\n");
            Százlábú pisti = new Százlábú("Pistike");  //objektum létrehozása
            pisti.kiír();
            pisti.eszik(50);
            pisti.lábvesztés(21);
            pisti.kiír();
            pisti.dolgozik(250);
            pisti.kiír();

            // A Program osztály függvényeinek tesztelése:
            

            // Az atlo fgv. tesztelése:
            Console.WriteLine("\nAz atlo fgv. tesztelése:\n");

            Console.WriteLine(atlo(4,6));

            // A szokoev fgv. tesztelése:
            Console.WriteLine("\nA szokoev fgv. tesztelése:\n");
            int ev = 2016;

            Console.WriteLine(szokoev(ev));

            // A char_db fgv. tesztelése:
            Console.WriteLine("\nA char_db fgv. tesztelése:\n");
            string szoveg = "Programozási tételek";


            Console.WriteLine(betu_db(szoveg));

            // A poz_ossz fgv. tesztelése:
            Console.WriteLine("\nA poz_ossz fgv. tesztelése:\n");
            double[] szamok = { 1, -5, 2.6, -7.1, 9, 2, -6, 4.6, 7, -6, 8 };

            Console.WriteLine(poz_ossz(szamok));

            Console.ReadKey();
        }
    }
}
