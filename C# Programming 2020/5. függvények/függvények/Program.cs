using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvények
{
    class Program
    {
        // függvény paraméter és visszatérési érték nélkül

        static void Névjegy()
        {
            Console.WriteLine("************************");
            Console.WriteLine("************************");
            Console.WriteLine("***** Név: Nitram  *****");
            Console.WriteLine("**Tel: +36 20 694 2020**");
            Console.WriteLine("************************");
            Console.WriteLine("************************");
        }


        // függvény egy paraméterrel és visszatérési értékkel
        static double Körkerület(double r)
        {
            return 2 * r * Math.PI;
        }

        // függvény két paraméterrel és visszatérési értékkel


        static double Téglalap(double a, double b)
        {
            return (a + b) * 2;
        }




        static void Main(string[] _)
        {
            // A névjegy függvény meghívása:
            Névjegy();

            // A korkerulet függvény meghívása:
            
            
            double ker = Körkerület(5.5);

            Console.WriteLine("A kör kerülete: {0:0.000}", ker);

            // A tlapkerulet függvény meghívása:
            double tlker = Téglalap(3.67, 7.54);

            Console.WriteLine("A téglalap kerülete: {0}", tlker);


            Console.ReadKey();
        }
    }
}
