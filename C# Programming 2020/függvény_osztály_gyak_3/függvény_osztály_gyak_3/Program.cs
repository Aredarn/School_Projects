using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Készítsen egy RandNeg osztályt, ami a Random osztály leszármazottja!
// A next függvénynek egy paramétere legyen! 
// Ha ez negatív, akkor 0 és a negatív szám közti véletlen számot írjon ki! (mindkettő kijöhet)

// Készítsen egy Számítógép osztályt, amelynek adattagjai: összes memória (int, MB-ban), szabad memória, bevan-e kapcsolva (boolean).
// Konstruktorok:
//                Általános konstruktor: minden adattagot a paraméterlistából állít be. Ha nem adunk meg szabad memóriát, akkor legyen egyenlő a teljes memóriával.
//                Alapértelmezett konstruktor: 4096 MB memóriával, kikapcsolva hozza létre a gépet.
// Metódusok: 
// A működik metódus adja vissza, hogy be van-e kapcsolva a gép! 
//
// Legyen egy bekapcs és egy kikapcs metódus. Mindkettő privát. A bekapcs bekapcsolja a gépet, és lefoglal 1 GB memóriát.
// A kikapcs metódus kikapcsolja a gépet és felszabadítja a memóriát.
//
// A kapcsol metódus (publikus) kapcsolja ki a gépet, ha be van kapcsolva és fordítva! Használja az előző három metódust!
//
// Legyen egy bool programMásol metódus, ami egy program méretét várja paraméternek MB-ban. Ha a program ráfér még a gépre, és a gép be vankapcsolva, úgy csökkenjen a szabad memória a program méretével. A metódus térjen vissza bool változóval, hogy sikeres volt-e a másolás.
//
// Készíts toString metódust az osztályhoz, ami kiírja a gép állapotát és a memória méretét. Bekapcsolt gép esetén a szabad memóriát is!



namespace függvény_osztály_gyak_3
{
    // Számítógép osztály:
    class Számítógép
    {
        //adattagok:
        public bool bekapcsolva;
        public int mem; //Összes memóra
        public int freemem; //szabad memóra 

        // Konstruktorok
        public Számítógép()
        {
            bekapcsolva = false;
            mem = freemem = 4096;


        }
        public Számítógép(bool p1, int p2, int p3)
        {
            bekapcsolva = p1;
            mem = p2;
            freemem = p3;

        }

        //Metódusok
        public bool müködik()
        {
            return bekapcsolva;
        }

        private void bekapcs()
        {
            bekapcsolva = true;
            freemem = freemem - 1024;
        }

        private void kikapcs()
        {
            bekapcsolva = false;
            freemem = mem;
        }

        public 
    }

    class RandNeg : Random
    {
        public int next(int p)
        {
            if (p > 0)
                return Next(p);
            else
                return Next(p, 1);
        }


    }

    class Program
    {
        // Írjon függvényt, ami kiír a paraméterben megadott számú csillagot, de maximim 70-et egy sorba, 
        // majd tesz két soremelést! (csillagok)



        // Írjon függvényt, ami kiszámolja egy gömb térfogatát! (V_gömb)



        // Írjon függvényt, ami megszámolja, hogy egy int tömbben hány szám osztható egy megadott számmal! (oszthatók)



        // Írjon függvényt, ami megadja, hogy egy stringben hány darab számjegy van! (számjegyek)
        static void Main(string[] args)
        {
            // RandNeg osztály tesztelése:
            Console.WriteLine("A RandNeg osztály tesztelése\n");
            Random rnd = new Random();
            RandNeg rn = new RandNeg();
            //Console.WriteLine(rnd.Next(-5));    // Hibás!
            Console.WriteLine(rn.next(-5));

            // Számítógép osztály tesztelése:
            Console.WriteLine("\nA Számítógép osztály tesztelése\n");
            Számítógép sz1 = new Számítógép();
            Console.WriteLine(sz1.müködik());

            // A csillagok függvény tesztelése:
            Console.WriteLine("\nA csillagok függvény tesztelése\n");


            // A V_gömb függvény tesztelése:
            Console.WriteLine("\nA V_gömb függvény tesztelése\n");
            double r = 5.4;

            // Az oszthatók függvény tesztelése:
            Console.WriteLine("\nAz oszthatók függvény tesztelése\n");
            int[] intek = { 25, 36, 74, 5, 98, 34, 62, 77, 92, 13, 64, 85, 6, 30, 71, 96 };


            // A számjegyek függvény tesztelése:
            Console.WriteLine("\nA számjegyek függvény tesztelése\n");
            string sz = "xxtg-34k5-6jfi-A6R9-0Fre";


            Console.ReadKey();
        }
    }
}
