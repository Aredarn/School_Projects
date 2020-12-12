using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismétlés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double szám;

            // Szám bekérése:
            Console.Write("Szám: ");
            szám = double.Parse(Console.ReadLine());

            double gyök;

            if (szám >= 0)
                gyök = Math.Sqrt(szám);
            else
                gyök = Math.Sqrt(szám * -1);

            // Kiírás:
            Console.Clear();
            // 1.
            Console.WriteLine("A szám gyöke: " + gyök);
            // 2.
            Console.WriteLine("{0} gyöke: {1:0.00}", szám, gyök);
            // 3.
            Console.WriteLine($"{szám} gyöke: {gyök:0.000}");

            //tömbkezelés:
            int n = 24; 
            int[] t = new int[n];

            //feltötés véletlen számokkal:
            
            Random rnd = new Random();
            int i;
            Console.WriteLine("\nVéletlen számok: ");
            for (i = 0; i < n; i++)
            {
                t[i] = rnd.Next(-10,21);
                //Console.Write(t[i] + " ");
            }
            
            

            Console.WriteLine();
  
            foreach(int x in t)
                Console.Write(x + " ");


            Console.WriteLine();

            //Összegzés
            int összeg = 0;

            foreach (int x in t)
                összeg += x;
            Console.WriteLine("Összeg = " + összeg);

            //Feltételes összegzés

            összeg = 0;

            foreach(int x in t)
            {
                if(x>=0)
                {
                    összeg += x; 
                }
            }

            Console.WriteLine("Pozitív számok összege: " + összeg);


            //Megszámlálás
            int db = 0;

            foreach (int x in t)
                db++;
            Console.WriteLine("Darab = " + db);

            db = 0;

            //Feltételes darabszámlálás
            foreach (int x in t)
            {
                if (x >= 0)
                {
                    db++;
                }
            }
            
            Console.WriteLine("Pozitívból van " + db + " darab");


            //Keresés:

            for (i = 0; i < n && t[i] != 5; i++);

            if(i == n)
                    Console.WriteLine("Nincs találat!");
            else
                    Console.WriteLine("A keresett elem a(z) " + i + ". indexen van");

            //Kiválogatás csak kiírás:
            foreach (int x in t)
                if (x > 3)
                    Console.WriteLine(x);

            //Kiválogatás tömbbe:
            int[] t2 = new int[n];

            int j;

            for (i = 0, j = 0; i < n; ++i)
                if (t[i] % 2 == 0) 
                {
                    t2[j] = t[i];
                    j++;
                }

            int n_t2 = j; //t2 tömb hasznos elemszáma

            //kiírás állományb
            StreamWriter ki = new StreamWriter("páros.txt");

            for (i = 0; i < n_t2; i++)
                ki.WriteLine(t2[i]);
            ki.Close();


            //stringkezelés
            string st;

            Console.Write("Szöveg: ");
            st = Console.ReadLine();

            st = st.Trim();

            Console.WriteLine(st);

            Console.WriteLine(st.Substring(2,6));


            Console.ReadKey();
       } 
    } 
}