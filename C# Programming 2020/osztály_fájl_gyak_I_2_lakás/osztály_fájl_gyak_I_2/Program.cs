using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Olvassa be a lakások.txt fájlt egy objektumtömbbe!
// Adattagok: eladó, ker (kerület), típus, szsz (szobaszám), ter (alapterület), ár
// Készítsen tagfüggvényt a négyzetméterár kiszámítására!
// Készítsen tagfüggvényt ami megállapítja, hogy Pesten vagy Budán van-e a lakás! (Budai kerületek: 1, 2, 3,11, 12, 22.)

namespace osztály_fájl_gyak_I_2
{
    // lakás osztály definíciója (adattagok, metódusok):
    public class Lakás
    {
        //adattagok:
        public string eladó;
        public int ker;
        public string típus;
        public double szsz;
        public int ter;
        public int ár;
        
        //konstruktor:
        public Lakás(string s)
        {
            string[] st = s.Split('&');
            eladó = st[0];
            ker = int.Parse(st[1]);
            típus = st[2];
            szsz = double.Parse(st[3]);
            ter = int.Parse(st[4]);
            ár = int.Parse(st[5]);
        }
    


        public double Nm ()
        {
            return ár / ter;
        }

        public string PestvBuda()
        {
            if (ker == 1 || ker == 2 || ker == 3 || ker == 11 || ker == 12 || ker == 22)
                return "Buda";
            else
                return "Pest";
        }

    
    
    }

    class Program
    {
        static void Main(string[] _)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat (beolvasás, obj. tömb elkészítése):\n...\n");
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("lakások.txt");

            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:

            Lakás[] t = new Lakás[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:
            int i;
            for (i = 0; i < n; ++i)
            {
                t[i] = new Lakás(be[i]);
            }

            // 2. feladat:
            Console.WriteLine("\n2. feladat (eladó lakások száma):\n");
            // Hány eladó lakás van az állományban? 

            Console.WriteLine(n + " darab eladó lakás van");
            // 3. feladat:
            Console.WriteLine("\n3. feladat (átlagos négyzetméterár):\n");
            // Mekkora az átlagos négyzetméterár?
            double összeg = 0;

            foreach (Lakás x in t)
                összeg = összeg + x.Nm();

            Console.WriteLine("Átlagár: " + összeg/n);

            // 4. feladat:
            Console.WriteLine("\n4. feladat (budai lakások száma):\n");
            // Hány budai lakás van?
            összeg = 0;

            foreach (Lakás x in t)
                if (x.PestvBuda() == "Buda")
                    összeg++;

            Console.WriteLine(összeg + " darab budai lakás van.");

            // 5. feladat:
            Console.WriteLine("\n5. feladat (100 nm-nél nagyobb lakások száma):\n");
            // Hány darab 100 nm-nél nagyobb lakás van?
            összeg = 0;

            foreach (Lakás x in t)
                if (x.ter > 100)
                    összeg++;

            Console.WriteLine(összeg+ " darab 100 nm-nél nagyobb lakás van");

            Console.ReadKey();
        }
    }
}
