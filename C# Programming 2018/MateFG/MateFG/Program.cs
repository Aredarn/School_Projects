using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateFG
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, ker, szám1, szám2;

            //kör kerület kiszámolása  

            r = 12;

            ker = r * r * Math.PI;

            Console.WriteLine("Kerület : " + ker);
            Console.WriteLine("PI: " + Math.PI);



            //Gyökvonás
            szám1 = Math.Sqrt(103041);
            Console.WriteLine("gyök: " + szám1);



            //hatvány
            szám2 = Math.Pow(3, 7);
            Console.WriteLine("Hatvány: " + szám2);


            //Kerekítés
            szám1 = Math.Round(179.54564989867);
            Console.WriteLine("Kerekítés: " + szám1);


            szám1 = Math.Round(179.5456 , 1);
            Console.WriteLine("Kerekítés: " + szám1);


            Console.ReadLine();
        }
    }
}
