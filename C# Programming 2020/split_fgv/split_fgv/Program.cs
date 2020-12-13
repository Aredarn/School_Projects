using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split_fgv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adatok egy-egy stringben elválasztó karakterrel:
            string st1 = "Duna;Tisza;Dráva;Mura;Maros;Szamos;Bodrog;Sajó;Sió;Hernád;Rába;Sebes-Körös;Zagyva;Bódva;Túr;Zala;Lajta;Pinka;Rábca;Berettyó;Kapos;Kraszna;Tarna;Kerka;Lapincs;Ronyva;Galga";
            string st2 = "kecsege#kövi csík#réti csík#dévérkeszeg#sujtásos küsz#balin#márna#amur#ponty#homoki küllő#fehér busa#garda#fürge cselle#szivárványos ökle#vörösszárnyú keszeg#compó#sebes pisztráng#csuka#lápi póc#tüskés pikó#folyami géb#süllő#botos kölönte";
            string st3 = "Alfa Bravo Charlie Delta Echo Foxtrot Golf Hotel India Juliett Kilo Lima Mike November Oscar Papa Quebec Romeo Sierra Tango Uniform Victor Whiskey X-ray Yankee Zulu";

            // String tömb deklarálása:
            string[] folyó = st1.Split(';');
            string[] hal;
            string[] hívójel;

            // String tömb létrehozása egy stringből, adott karakter segítségével feldarabolva.
            hal = st2.Split('#');
            hívójel = st3.Split(' ');


            // Az új string tömb elemszáma:
            int dbf = folyó.Length;
            Console.WriteLine(dbf + "db folyó");

            int dbh = hal.Length;
            Console.WriteLine(dbh + "hal van");

            int dbj = hívójel.Length;
            Console.WriteLine(dbj + " hívójel");

            // Elemek kiírása:
            foreach(string x in folyó)
                Console.WriteLine(x);

            foreach (string x in hal)
                Console.WriteLine(x);

            foreach (string x in hívójel)
                Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
