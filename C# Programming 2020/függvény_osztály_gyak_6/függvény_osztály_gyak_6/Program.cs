using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvény_osztály_gyak_6
{
    // Készítsen egy Doboz osztályt, amelynek adattagjai: szélesség, hosszúság, magasság, tartalom, tele.
    // A méretek cm-ben megadott egész számok, a tartalom szöveges adat.
    // A dobozba több dolgot is rakhatunk. Az üres doboz esetén a tartalom üres string (""). 
    // A tartalom adattagban több dologot is fel lehet sorolni (pl.: "toll, ceruza, füzet, dobókocka").
    // A tele változó akkor lesz igaz, ha már több dolgot nem tudunk a dobozba rakni.
    //
    // Konstruktorok:
    //     Üres dobozt létrehozó konstruktor: a méreteket kell megadni, tartalma nincs.
    //     Tartalommal rendelkető doboz konstruktora: a méreteken kívül a tartalmat is meg kell adni, valamint, hogy tele van-e a doboz.    
    //     
    // Metódusok: 
    // A méret metódus megadja a doboz űrtartalmát dm^3-ben (v. literben)! 
    //
    // Az ürít metódussal kiveszünk mindent a dobozból: tartalom üres lesz, a tele pedig hamis.    
    //
    // Az új_tartalom metódussal megadjuk a doboz új tartalmát, valamint, hogy tele van-e (fér e még bele valami).
    // 
    // Készítsen toString metódust, ami által visszaadott string tartalmazza a doboz méretét dm^3-ben, és a tartalmát!
    // Ha a doboz üres, akkor az "A doboz üres" szöveg jelenjen meg a tartalom helyett.
    class Doboz
    {
        //Adattagok:
        public int szélesség, hosszúság, magasság;
        public string tartalom;
        public bool tele;

        //Konstruktorok
        public Doboz(int sz, int h, int m)
        {
            szélesség = sz;
            hosszúság = h;
            magasság = m;
            tartalom = "";
            tele = false;
        }

        public Doboz(int sz, int h, int m, string tm, bool t)
        {
            szélesség = sz;
            hosszúság = h;
            magasság = m;
            tartalom = tm;
            tele = t;
        }

        //Metódusok
        public double Méret()
        {
            return (szélesség * hosszúság * magasság) / 1000;
        }

        public void Ürít()
        {
            tartalom = "";

            if (tele == true)
                tele = false;
        }

        public void Új_tartalom(string tárgy, bool fér_még)
        {
            tartalom = tartalom + tárgy;
            tele = fér_még;
        }

        public string TOString()
        {
            if (tartalom == "")
                return "a doboz üres";
            else
                return $"A doboz térfogata {Méret()}dm^3 és ezek vannak benne: {tartalom}";
        }
    }

    class Program
    {
        // Írjon függvényt, ami egy km adatot átvált mérföldbe (1 mérföld ~ 1,609 km)! (kmTomf)

        static double kmTomf(double km)
        {
            return km / 1.609;
        }

        // Írjon függvényt, ami feltölti egy int tömb elemeit két érték közti véletlen egész számokkal! (vél_tölt)

        static void vél_tölt(int[] t, int x, int y)
        {
            Random rnd = new Random();
            for(int i =0; i<t.Length; i++)
            {
                t[i] = rnd.Next(x, y);
                Console.WriteLine(t[i]);
            }
        }

        // Írjon függvényt, ami egy szövegben megszámolja, hogy hány darab vmilyen vessző van. (, és ; is)! (db_vessző)

        static int db_vessző(string sz)
        {
            int db=0;

            for(int i=0; i < sz.Length;i++)
            {
                if (sz[i] == ',' || sz[i] == ';')
                    db++;
            }
            return db;
        }

        static void Main(string[] args)
        {
            // A Doboz osztály tesztelése:
            Console.WriteLine("A Doboz osztály tesztelése:\n");
            // Hozzon létre két Doboz objektumot!
            // Tesztelje a metódusokat különböző esetekben! Futás közben kellő információ is jelenjen meg!

            Doboz KartonDoboz = new Doboz(30, 40, 20);
            Doboz MűAnyagDoboz = new Doboz(50, 50, 50, "filctoll, kisautó, távirányító", false);


            Console.WriteLine($"A kartondoboz térfogata: {KartonDoboz.Méret()}L");
            Console.WriteLine($"A műanyag doboz térfogata: {MűAnyagDoboz.Méret()}L");
            
            Console.WriteLine("\n");

            Console.WriteLine($"A műanyag doboz tartalma: {MűAnyagDoboz.tartalom}");
            MűAnyagDoboz.Ürít();
            Console.WriteLine($"A műanyag doboz tartalma ürítés után: {MűAnyagDoboz.tartalom}");

            Console.WriteLine("\n");

            Console.WriteLine($"A karton doboz tartalma: {KartonDoboz.tartalom}");
            KartonDoboz.Új_tartalom("párna, takaró", false);
            Console.WriteLine($"A karton doboz tartalma pakolás után : {KartonDoboz.tartalom}");

            Console.WriteLine(KartonDoboz.TOString());
            Console.WriteLine(MűAnyagDoboz.TOString());

            /************* Függvények tesztelése *************/
            // A kmTomf függvény tesztelése:
            Console.WriteLine("\nA kmTomf függvény tesztelése:\n");
            double km = 402.25;

            Console.WriteLine(kmTomf(km));

            // A vél_tölt függvény tesztelése:
            Console.WriteLine("\nA vél_tölt függvény tesztelése:\n");
            int[] tömb = new int[100];

            vél_tölt(tömb, 2, 100);


            // A db_vessző függvény tesztelése:
            Console.WriteLine("\nA db_vessző függvény tesztelése:\n");
            string szöveg = "Ebben; a, szövegben, összesen, 12 vessző, és; pontosvezző,; van. (,,;;)";

            Console.WriteLine(db_vessző(szöveg));

            Console.ReadKey();
        }
    }
}
