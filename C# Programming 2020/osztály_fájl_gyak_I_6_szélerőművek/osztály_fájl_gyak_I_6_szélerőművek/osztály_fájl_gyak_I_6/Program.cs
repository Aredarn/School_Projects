using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Olvassa be a szélerőmű.txt fájlt egy objektumtömbbe! Az osztály neve szélerőmű legyen!
// Adattagok: tel (település neve), db (szélerőművek száma), kw (egy torony teljesítménye kw-ban), ühév (üzembe helyezés éve)
// Készítsen tagfüggvényt ami megadja:
//          a tornyok együttes teljesítményét (össz_kw)!
//          Hány éve helyezték üzembe a tornyokat (műk_éve)!

namespace osztály_fájl_gyak_I_6
{
    public class szélerőmű
    {
        //Adattagok:
        public string tel;
        public int db;
        public int kw;
        public int ühév;

        public szélerőmű(string s)
        {
            string[] st = s.Split('*');
            tel = st[0];
            db = int.Parse(st[1]);
            kw = int.Parse(st[2]);
            ühév = int.Parse(st[3]);
        }

        public int össz_Kw()
        {

            return kw * db;
        }

        public int műk_éve()
        {
            return 2021 - ühév;
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat (beolvasás, obj. tömb elkészítése):\n...\n");
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("szélerőmű.txt");

            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:
            szélerőmű[] t = new szélerőmű[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:
            int i;
            for (i = 0; i < n; i++)
                t[i] = new szélerőmű(be[i]);

            // 2. feladat:
            Console.WriteLine("\n2. feladat (Adatok száma.):\n");
            // Hány átadott szélerőmű csoport van? 
            Console.WriteLine($"{n} darab átadott szélerőmű csoport van.");

            // 3. feladat:
            Console.WriteLine("\n3. feladat (Összesített teljesítmény.):\n");
            // Mekkora szélerőművek összesített teljesítménye MW-ban?
            int darab = 0;

            for(i = 0; i < n; i++)
            {
                darab = darab + t[i].össz_Kw();
            }

            darab = darab / 1000;
            Console.WriteLine("Szélerőművek összesített teljesítménye:  " + darab + "Mw");

            // 4. feladat:
            Console.WriteLine("\n4. feladat (Utóbbi 10 év.):\n");
            // Az utóbbi tíz évben hány tornyot helyeztek üzembe? A megoldás során használja a műk_éve metódust!
            darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].műk_éve() <= 10)
                    darab = darab + t[i].db;

            Console.WriteLine(darab);

            // 5. feladat:
            Console.WriteLine("\n5. feladat (Több erőmű átadasa.):\n");
            // Hányszor adtak át egynél több erőművet!
            darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].db > 1)
                    darab++;

            Console.WriteLine(darab);

            // 6. feladat:
            Console.WriteLine("\n6. feladat (2008-as legalább 2 MW-os erőművek.):\n");
            // 2008-ban hány darab legalább 2 MW teljesítményű torony épült?
            darab = 0;

            for (i = 0; i < n; i++)
                if (t[i].kw >= 2000 && t[i].ühév == 2008)
                    darab++;

            Console.WriteLine(darab);



            Console.ReadKey();
        }
    }
}
