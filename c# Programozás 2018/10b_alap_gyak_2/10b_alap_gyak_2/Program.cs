using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10b_alap_gyak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat:\n");
            // Hozzon létre g és h néven változókat a megadott értékekkel!
            // Deklarálja és számolja ki j értékét!

            double g, h, j;
            g = 4.5;
            h = -2;

            j=(6*g-9*h+2) / (3 * (g + h) + 2.5);

            Console.WriteLine("J= " + j);

            // 2. feladat:
            Console.WriteLine("\n2. feladat:\n");
            // Számolja ki k értékét!
            double k;

            k = (Math.Sqrt(2 * g) + 2 * h) / (h * (h - g));
            Console.WriteLine("k = " + k);

            // 3. feladat:
            Console.WriteLine("\n3. feladat:\n");
            // Számolja ki l értékét!
            double l;

            l = Math.Pow(g / h, 4) + Math.Pow(h, 7);
            Console.WriteLine("l = " + l);



            // 4. feladat:
            Console.WriteLine("\n4. feladat:\n");
            // Hozzon létre egy 11 és 19 közti véletlen számot v változóba, majd írja ki az ötszörösét!
            int v;
            Random rnd = new Random();

            v = rnd.Next(11, 20);
            Console.WriteLine("v * 5= " + v *5);


            // 5. feladat:
            Console.WriteLine("\n5. feladat:\n");
            // Hozzon létre egy véletlen számot egy neg nevű változóba!
            // Éréke legyen -100 és -1000 köztött!
            // Írja ki az abszolút értékét!
            int neg;

            neg = rnd.Next(-1000, -99);
            Console.WriteLine("|neg| = " + Math.Abs(neg));



            // 6. feladat:
            Console.WriteLine("\n6. feladat:\n");
            // A szám változó értéke legyen 13000 és 26000 közti véletlen egész!
            // Mennyi lesz 127-tel osztva az osztási maradék?
            int szám;
            szám = rnd.Next(13000, 26001);
                    
            Console.WriteLine("szám = " + szám + " maradék =" + szám%127);


            // Várakozzon billentyűleütésig:

            Console.ReadLine();
        }
    }
}
