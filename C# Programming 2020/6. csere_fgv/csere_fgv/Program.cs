using System;

namespace csere_fgv
{
    class Program
    {   // két int változó értékét felcserélő függvény:
        static void Csere(ref int a, ref int b)
        {
            int sv = a;
            a = b;
            b = sv;
        }

        static void Csere(ref double a, ref double b)
        {
            double sv = a;
            a = b;
            b = sv;
        }

        // két double változó értékét felcserélő függvény:


        static void Main(string[] args)
        {
            int szam1 = 4, szam2 = 12;

            Console.WriteLine("szam1 = {0} szam2 = {1}", szam1, szam2);

            if (szam1 < szam2)
                Csere(ref szam1, ref szam2);

            Console.WriteLine("szam1 = {0} szam2 = {1}", szam1, szam2);

            double szam3 = 4.6578, szam4 = 0.4098;

            Console.WriteLine("szam1 = {0} szam2 = {1}", szam3, szam4);

            Csere(ref szam3, ref szam4);

            Console.WriteLine("szam1 = {0} szam2 = {1}", szam3, szam4);

            Console.ReadKey();
        }
    }
}
