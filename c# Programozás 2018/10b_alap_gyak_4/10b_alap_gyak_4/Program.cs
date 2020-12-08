using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10b_alap_gyak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat:\n");
            // Hozzon létre x és y néven változókat a megadott értékekkel!
            // Deklarálja és számolja ki z1 értékét!
            double p, q, z1;
            p = 6.8;
            q = 4.4;

            z1 = (3 * (p - q) + 15) / (p * q - 2 * (p + 3));
            Console.WriteLine("z1 = " + z1);


            // 2. feladat:
            Console.WriteLine("\n2. feladat:\n");
            // Számolja ki z2 értékét!
            double z2;

            z2 = 2 * q * p + Math.Sqrt((6 * p - q) / (3 * q - p));
            Console.WriteLine("z2 = " + z2);


            // 3. feladat:
            Console.WriteLine("\n3. feladat:\n");
            // Számolja ki z3 értékét!
            double z3;

            z3 = Math.Pow((p - q + 2) / (p - 3), 5);
            Console.WriteLine("z3 = " + z3);


            // 4. feladat:
            Console.WriteLine("\n4. feladat:\n");
            // Hozzon létre egy -60 és 120 közti véletlen számot a vél_szám változóba és írja ki az értékét!
            Random rnd = new Random();
            int v;

            v = rnd.Next(-60, 121);
            Console.WriteLine("v = " + v);


            // 5. feladat:
            Console.WriteLine("\n5. feladat:\n");
            // Hozzon létre két véletlen számot szám_1 és szám2 változóbka!
            // szám_1 legyen 17 és 27 közti szám, szám_2 pedig 39 és 69 közötti!
            // Írja ki a számokat, a szorzatukat és az összegüket!
            int szám1, szám2;

            szám1 = rnd.Next(17, 28);
            szám2 = rnd.Next(39, 70);
            Console.WriteLine(" Szám1 = " + szám1 + " Szám2 = " + szám2 + " Összegük =  " + (szám1 + szám2) + " Szorzatuk = "+szám1 * szám2);


            Console.ReadLine();
            // Várakozzon billentyűleütésig:        }
        }
    }
}
