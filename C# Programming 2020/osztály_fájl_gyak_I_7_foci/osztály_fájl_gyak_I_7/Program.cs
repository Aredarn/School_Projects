using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace osztály_fájl_gyak_I_7
{
    // Olvassa be az foci.txt fájlt egy objektumtömbbe! Az ehhez készített osztály neve csapat legyen!
    // Adattagok: név, gy (győzelem), d (döntetlen), v (vereség), rg (rúgott gól), kg (kapott gól)
    // Készítsen tagfüggvényt ami megadja:
    //          a lejátszott mérkőzések számát (mérk)!
    //          a gólkülönbséget (gólk)!            -> rúgott és a kapott gólok különbsége
    //          a csapat pontszámát (pont)!			-> győzelem 3 pont, döntetlen 1 pont

    // Osztály elkészítése:

    class csapat
    {
        //adattagok:
        public string név;
        public int gy;
        public int d;
        public int v;
        public int rg;
        public int kg;

        public csapat(string s)
        {
            string[] st = s.Split('|');
            név = st[0];
            gy = int.Parse(st[1]);
            d = int.Parse(st[2]);
            v = int.Parse(st[3]);
            rg = int.Parse(st[4]);
            kg = int.Parse(st[5]);
        }

        public int mérk()
        {
            return gy + d + v;
        }

        public int gólk()
        {
            return rg - kg;
        }

        public int pont()
        {
            return gy * 3 + d;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat (beolvasás, obj. tömb elkészítése):\n...\n");
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("foci.txt");

            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:

            csapat[] t = new csapat[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:

            int i;

            for (i = 0; i < n; i++)
                t[i] = new csapat(be[i]);


            // 2. feladat:
            Console.WriteLine("\n2. feladat (Csapatok száma.):\n");
            // Hány csapat van a bajnokságban? 

            Console.WriteLine(n + " darab csapat van a bajnokságban.");


            // 3. feladat:
            Console.WriteLine("\n3. feladat (Gólok száma.):\n");
            // Összesen hány gól született a bajnokságban?

            int gólok_össz = 0;

            for (i = 0; i < n; i++)
                gólok_össz = gólok_össz + t[i].rg;
            Console.WriteLine(gólok_össz+" a rúgott gólok száma");


            // 4. feladat:
            Console.WriteLine("\n4. feladat (Legnagyobb gólkülönbség.):\n");
            // Melyik csapat szerezte a legtöbb pontot?
            string lgpont = "";
            int tbpont = 0;


            for(i=0;i<n;i++)
                if(tbpont < t[i].pont())
                {
                    tbpont = t[i].pont();
                    lgpont = t[i].név;
                }

            Console.WriteLine(lgpont + " szerezte a legtöbb pontot");

            // 5. feladat:
            Console.WriteLine("\n5. feladat (Pozitív gólkülönbség):\n");
            // Hány csapatnak van pozitív gólkülönbsége?
            int poz_golk = 0;

            for (i = 0; i < n; i++)
                if (t[i].gólk() > 0)
                    poz_golk++;

            Console.WriteLine(poz_golk + " csapatnak van pozitív gólkülönbsége");

            // 6. feladat:
            Console.WriteLine("\n6. feladat (Csapatok teljesítménye):\n");
            // Írja ki a csapatok nevét, a lejátszott mérkőzések számát, a pontszámot és a gólkülönbséget!

            for (i = 0; i < n; i++)
                Console.WriteLine(t[i].név + " " + t[i].mérk() + " " + t[i].pont() + " " +t[i].gólk());


            Console.ReadKey();
        }
    }
}
