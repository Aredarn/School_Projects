using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// Készítsen tagfüggvényt a népsűrűség kiszámítására!
// Készítsen tagfüggvényt ami megadja, hogy a legnagyobb város lakossága 
//           az ország népességének hány százaléka? A visszaadott érték két tizedesjegy legyen!

namespace osztály_fájl_gyak_I_3
{
    class Afrika
    {
        //Adattagok
        public string ország;
        public int ter;
        public int lakosság;
        public string lnv;
        public int lnv_lak;
        public bool főv_e;


        public Afrika(string s)
        {
            string[] st = s.Split('@');
            ország = st[0];
            ter = int.Parse(st[1]);
            lakosság = int.Parse(st[2]);
            lnv = st[3];
            lnv_lak = int.Parse(st[4]);

            if (st[5] == "fv")
                főv_e = true;
            else
                főv_e = false;
        }      

        public int népsűr(int a, int b)
        {
            return a / b;
        }




    }




    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat (beolvasás, obj. tömb elkészítése):\n...\n");
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("afrika.txt");

            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:
            Afrika[] t = new Afrika[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:

            int i;
            for (i = 0; i < n; ++i)
            {
                t[i] = new Afrika(be[i]);
            }


            // 2. feladat:
            Console.WriteLine("\n2. feladat (Afrikai országok száma):\n");
            // Hány  van? 

            Console.WriteLine(n+" darab Afrikai ország van.");

            // 3. feladat:
            Console.WriteLine("\n3. feladat (Afrika területe!):\n");
            // Mekkora Afrika területe?
            int afr_ter = 0;

            for (i = 0; i < n; i++)
                afr_ter = t[i].ter;

            Console.WriteLine("Afrika területe: " + afr_ter);


            // 4. feladat:
            Console.WriteLine("\n4. feladat (10 fő/km^2 alatti népsűrűség.):\n");
            // Írja ki azokat az országokat, ahol a népsűrűség 10 fő/km^2 alatt van!

            for (i = 0; i < n; i++)
                if(t[i].népsűr(t[i].lakosság, t[i].ter ) <= 10)
                    Console.WriteLine(t[i].ország);



            // 5. feladat:
            Console.WriteLine("\n5. feladat (Legnagyobb város, de nem főváros.):\n");
            // Írja ki azokat az országokat, legnagyobb városokat és 
            // népességük arányát, ahol a város nem a főváros!

            for (i = 0; i < n; i++)
                if(t[i].főv_e == false)
                    Console.WriteLine(t[i].ország + "  " + t[i].lnv + " " +  t[i].népsűr(t[i].lakosság, t[i].ter ));




            // 6. feladat:
            Console.WriteLine("\n6. feladat (Nem főváros legnagyobb városok száma.):\n");
            // Hány olyan ország van, ahol a legnagyobb város nem a főváros?
            int darab = 0;

            for (i = 0; i < n; i++)
                if (!t[i].főv_e)
                    darab++;

            Console.WriteLine(darab + " olyan ország van ahol a legnagyobb város nem a főváros");
            Console.ReadKey();
        }
    }
}
