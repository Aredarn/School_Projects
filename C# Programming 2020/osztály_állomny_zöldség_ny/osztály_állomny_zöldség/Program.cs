using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace osztály_állomny_zöldség
{
    // A zoldsegmag osztály definíciója:
    
    class Zöldségmag
    {
        //Adattagok:
        public string név;
        public int ár;

        public Zöldségmag(string sz)
        {
            string[] t = sz.Split(';');
            név = t[0];
            ár = int.Parse(t[1]);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorából lesz egy tömbelem:

            string[] be = File.ReadAllLines("zöldség.txt");

            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:
            Zöldségmag[] t = new Zöldségmag[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:
            int i;
            for (i = 0; i < n; ++i)
                t[i] = new Zöldségmag(be[i]);

            // A tömb elemszáma:
            Console.WriteLine(n);

            //Azobjektumtömb 3. elemének kiírása:
            Console.WriteLine(t[2].név + " ára: " + t[2].ár +"Ft");

            // Az objektum tömb elemeinek kiírása:
            Console.WriteLine("\nA kaható zöldségmagok: \n");

            // 1. lehetőség:
            for(i=0; i<n; ++i)
                Console.WriteLine(t[i].név + "  ára: " + t[i].ár + "Ft");

            // 2. Lehetőség
            foreach(Zöldségmag x in t)
                Console.WriteLine(x.név + "  ára: " + x.ár + "Ft");


            // 300 Ft-nál drágább magok kiírása:
            Console.WriteLine("\n300ft nál drágább magok");
            for(i = 0; i<n;i++)
                if(t[i].ár >300)
                    Console.WriteLine(t[i].név + "  ára: " + t[i].ár + "Ft");

            // A k betűvel kezdődő növények kiírása:
            Console.WriteLine("\nA k betűvel kezdődő növények kiírása:\n");
            
            for (i = 0; i < n; i++)
                if (t[i].név[0] =='K')
                    Console.WriteLine(t[i].név + "  ára: " + t[i].ár + "Ft");


            Console.ReadKey();
        }
    }
}
