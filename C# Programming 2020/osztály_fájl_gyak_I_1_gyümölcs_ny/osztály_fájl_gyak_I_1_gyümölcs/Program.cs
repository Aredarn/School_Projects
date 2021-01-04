using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// Adattagok: név, me (mennyiség egység), mennyiség, déli

namespace osztály_fájl_gyak_I_1_gyümölcs
{
    // gyümölcs osztály definíciója:
    
    class gyümölcs
    {
        //adattagok:
        public string név;
        public string me;
        public int m; //mennyiség
        public char deli; 

        //konstruktor:
        public gyümölcs(string s)
        {
            string[] st = s.Split(',');
            név = st[0];
            me = st[1];
            m = int.Parse(st[2]);
            deli = char.Parse(st[3]);
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {

            string[] be = File.ReadAllLines("gyümölcs.txt");

            //darabszám:
            int n = be.Length;

            //objektumtömb
            gyümölcs[] t = new gyümölcs[n];

            //tömb elemeinek felvétele ciklussal:

            int i;
            for(i=0; i<n; ++i)
            {
                t[i] = new gyümölcs(be[i]);
            }

            //gyümölcsök darabszáma:
            Console.WriteLine("Gyümölcsök darabszáma: " + n + "\n");

            //objektumtömb kezelése:
            //db-ben mért gyümölcsök neve és mennyisége:

            for(i = 0; i < n; ++i)
            {
                if(t[i].me == "db")
                    Console.WriteLine(t[i].név + " " + t[i].m + "db");
            }

            // db olyan gyümölcs van amit kg-ban mérünk?
            int db = 0;

            for (i = 0; i < n; ++i)
            {
                if (t[i].me == "kg")
                    ++db;
            }

            Console.WriteLine("\nkg-ban mért gyümölcs darab: " + db);

            //Melyik gyümölcsök fogytak el?:
            Console.WriteLine("\n0 mennyiségű gyümölcsök: ");

            for (i = 0; i < n; i++)
                if (t[i].m == 0)
                    Console.WriteLine(t[i].név);

            //kg-ben mért gyümölcsök kötül azok amelyekből több mint 10 van

            Console.WriteLine("\n");

            for (i = 0; i < n; ++i)
            {
                if (t[i].me == "kg" && t[i].m > 10) 
                    Console.WriteLine(t[i].név + " " + t[i].m + "kg");
            }



            Console.ReadKey();
        }
    }
}
