using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace függvény_osztály_gyak_1
{
    // Készítsen Idő osztályt, amely óra perc másodperc adatokkal tárol egy időpontot!
    // Konstruktorok: üres 
    //                óra, perc
    //                óra, perc, másodperc
    //                A paraméterben át nem adott adatok értéke 0.
    // Metódusok: Idő kiírása ó:pp vagy ó:pp:mm alakban.
    //            Időpont beállítása ó:pp:mm alakú stringgel.
    //            Idő kiírása másodpercben.
    //            Idő kiírása percben.
    //            Idő kiírása órában.
    //            Idő kiírása 12 órás alakban, de/du jelzéssel.


    class Idő
    {
        //adattagok:
        public int óra;
        public int perc;
        public int mp;

        //konstruktorok:
        public Idő()
        {
            óra = perc = mp = 0;
        }

        public Idő(int ó, int p)
        {
            óra = ó;
            perc = p;
            mp = 0;
        }

        public Idő(int ó, int p, int m)
        {
            óra = ó;
            perc = p;
            mp = m;
        }

        public void kiír(char formátum = 'h')
        {
            if(formátum =='r')
                Console.WriteLine($"{óra}:{perc:00}");
            else if(formátum == 'h')
                Console.WriteLine($"{óra}:{perc:00}:{mp:00}");

        }

        public void beállít(string st)
        {
            string[] t_st = st.Split(':');
            óra = int.Parse(t_st[0]);
            perc = int.Parse(t_st[1]);

            if (t_st.Length < 3)
                mp = 0;
            else
                mp = int.Parse(t_st[2]);
        }

        public int ki_mp()
        {
            return óra * 3600 + perc * 60 + mp;
        }

        public double ki_perc()
        {
            return óra * 60 + perc + (double)mp / 60;
        }

        public double ki_óra()
        {
            return óra + perc / 60.0 + mp / 3600.0;
        }

        public void kiír_12()
        {
            if (óra <= 12)
                Console.WriteLine($"am{óra}:{perc:00}");
            else if (12 < óra)
                Console.WriteLine($"pm {óra-12}:{perc:00}:{mp:00}");
            
            
        }

    }

    class Program
    {
        // Írjon függvényt nagyobb néven, amely két szám közül a nagyobbat adja eredményül!
        static double nagyobb(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        // Írjon függvényt, ami három számból megállapítja, hogy szerkeszthető-e belőlük háromszög! (szerk_e_hsz)
        static bool szerk_e_hsz(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        // Írjon függvényt, ami bekér a felhasználótól egy kisbetűt (az angol abc-ből)! (kisbetube)
        static char kisbetube()
        {
            Console.WriteLine("Írj be egy kisbetűt: ");
            char ch;
            do
                ch = char.Parse(Console.ReadLine());
            while (ch < 'a' || ch > 'z');
            return ch;

        }

        // Írjon függvényt, amely megadja egy int tömb legkisebb elemét! (t_min)
        static int t_min(int[] t)
        {
            int n = t.Length;
            int min = t[0], i;

            for(i=0; i<n; ++i)
            {
                if (t[i] < min)
                    min = t[i];
            }
            return min;
        }

        static void Main(string[] _)
        {
            // Az Idő osztály tesztelése:
            Console.WriteLine("Az Idő osztály tesztelése:\n");
            Idő dél = new Idő(12, 0);
            Idő vacsi = new Idő(18,9,45);

            Console.Write("Vacsora: ");
            vacsi.kiír();

            vacsi.beállít("19:05");
            Console.Write("Vacsora 2.0: ");
            vacsi.kiír();
            Console.WriteLine(vacsi.ki_mp());
            Console.WriteLine(vacsi.ki_perc());
            Console.WriteLine(vacsi.ki_óra());

            vacsi.kiír_12();


            // Tesztadatok a függvényekhez:
            int[] t_egesz = { 6, 9, 55, 7, 3, 66, 4, 24, 61, 7, 6, 8 };

            double szam1 = 14.6;
            double szam2 = 9.7;
            double szam3 = 6;

            char ch;

            // A nagyobb fgv. tesztelése:
            Console.WriteLine("\nA nagyobb fgv. tesztelése:\n");
            Console.WriteLine(nagyobb(szam2, szam3));


            // A szerk_e_hsz fgv. tesztelése:
            Console.WriteLine("\nA szerk_e_hsz fgv. tesztelése:\n");
            if(szerk_e_hsz(szam1, szam2, szam3))
                Console.WriteLine("Szerkeszthető");
            else
                Console.WriteLine("Nem szerkeszthető");           

            // A kisbetube fgv. tesztelése:
            Console.WriteLine("\nA kisbetube fgv. tesztelése:\n");
            ch = kisbetube();
            Console.WriteLine("A kisbetű a: " + ch);

            // A t_min fgv. tesztelése:
            Console.WriteLine("\nA t_min fgv. tesztelése:\n");

            int legkisebb = t_min(t_egesz);

            Console.WriteLine(legkisebb);



            Console.ReadKey(true);
        }
    }
}
