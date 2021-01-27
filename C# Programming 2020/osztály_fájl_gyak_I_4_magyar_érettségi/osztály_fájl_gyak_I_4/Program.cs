using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Olvassa be az érettségi.txt fájlt egy objektumtömbbe!
// Adattagok: név, írásbeli (pontszám), szóbeli (pontszáma), 
// Készítsen tagfüggvényt ami megadja:
//          hogy mehetett-e szóbelizni a diák! (13 ponttól mehet) A függvényvév: msz (mehet szóbelizni)
//          hogy érvényes volt-e a szóbeli! (7 ponttól érvényes) A függvényvév: ész (érvényes szóbeli)
//          az összpontszámot! A függvénynév: öp (összpont) 
//          az érettségi eredményét, vagyis a jegyet! A jegy 25%-tól 2-es, 40%-tól 3-mas, 60%-tól 4-es, 80%-tól 5-ös) A függvényvév: jegy


namespace osztály_fájl_gyak_I_4
{
    class érettségi
    {
        //Adattagok:
        public string név;
        public int írásbeli;
        public int szóbeli;


        public érettségi(string s)
        {
            string[] st = s.Split(',');
            név = st[0];
            írásbeli = int.Parse(st[1]);
            szóbeli = int.Parse(st[2]);
        }

        public bool msz()
        {
            if (írásbeli > 12)
                return true;
            else
                return false;
        }

        public bool ész()
        {
            if (szóbeli > 6)
                return true;
            else
                return false;
        }

        public int öp()
        {
            return szóbeli + írásbeli;
        }

        public int jegy()
        {
            if (öp() > 150 * 0.25 && öp()  < 150 * 0.4)
                return 2;
            else if (öp() > 150 * 0.4 && öp() < 150 * 0.6)
                return 3;
            else if (öp()  > 150 * 0.6 && öp()  < 150 * 0.8)
                return 4;
            else if (öp()  > 150 * 0.8 && öp()  < 150)
                return 5;
            else
                return 1;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat (beolvasás, obj. tömb elkészítése):\n...\n");
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("érettségi.txt");


            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:
            érettségi[] t = new érettségi[n];


            // A tömb elemeinek (objektumok) felvétele ciklussal:
            int i;

            for (i = 0; i < n; i++)
                t[i] = new érettségi(be[i]);

            // 2. feladat:
            Console.WriteLine("\n2. feladat (Érettségizők száma.):\n");
            // Hány érettségiző van? 
            Console.WriteLine(n + "  érettségiző van");

            // 3. feladat:
            Console.WriteLine("\n3. feladat (Nem szóbelizhetnek.):\n");
            // Hány diák nem mehet szóbelire?
            int darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].msz() == false)
                    darab++;


            Console.WriteLine(darab + "  diák nem mehet szóbelire");

                // 4. feladat:
                Console.WriteLine("\n4. feladat (Sikertelen szóbeli.):\n");
            // Hány diáknak nem lett sikeres a szóbelije?

            darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].szóbeli < 7)
                    darab++;

            Console.WriteLine(darab + "  diáknak nem lett sikeres a szóbeli");

            // 5. feladat:
            Console.WriteLine("\n5. feladat (Akik levizsgáztak.):\n");
            // Írja ki azoknak a nevét és eredményét, akik sikeres vizsgát tettek (legalább kettest értek el)!

            for (i = 0; i < n; i++)
                if (t[i].jegy() > 1)
                    Console.WriteLine(t[i].név + "  Összpontja: " + t[i].öp());


                    // 6. feladat:
                    Console.WriteLine("\n6. feladat (Ötös vizsgák.):\n");
            // Írja ki az ötösre vizsgázók nevét és összpontszámát!

            for (i = 0; i < n; i++)
                if (t[i].jegy() == 5)
                    Console.WriteLine(t[i].név + "  Összpontja: " + t[i].öp());

            // 7. feladat:
            Console.WriteLine("\n7. feladat (\"Okos\" elégtelenek.):\n");
            // Írja ki azoknak a nevét, akiknek a szóbeli és az írásbeli külön-külön nem volt sikertelen, de az összteljesítményük elégtelen lett!

            for (i = 0; i < n; i++)
                if (t[i].jegy() == 1 && t[i].írásbeli > 12 && t[i].írásbeli > 6)
                    Console.WriteLine(t[i].név);
                    
            
            
            // 8. feladat:
            Console.WriteLine("\n8. feladat (Írásbeli átlag.):\n");
            // Mennyi lett az írásbelik átlaga!
            double átlag;
            darab = 0;

            for (i = 0; i < n; i++)
                darab += t[i].jegy();

            átlag = darab / n;

            Console.WriteLine("A jegyek átlaga:" + átlag);


                // 9. feladat:
                Console.WriteLine("\n9. feladat (Szóbeli átlag.):\n");
            // Mennyi lett a szóbelik átlaga!
            darab = 0;
            átlag = 0;


            // 10. feladat:
            Console.WriteLine("\n10. feladat (0 pontos szóbeli.):\n");
            // Lett-e 0 pontos szóbeli? Ha igen mennyi?
            
            darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].szóbeli == 0)
                    darab++;

            Console.WriteLine("0 pontos szóbelik száma: " + darab);

            Console.ReadKey();
        }
    }
}
