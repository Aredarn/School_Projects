using System;

namespace osztály_kör
{
    class Kör
    {


        //adattagok:
        public double r;  //sugár

        // Metódusok vagy tagfüggvények
        // Konstruktor

        public Kör()  // Konstruktor paraméter nélkül
        {
            r = 1;
        }

        public Kör(double p) //Konstruktor paraméterrel
        {
            r = p;
        }

        //függvény definíciója
        //elérhetőség, visszatérési érték típusa, függvény neve(a szükséges paraméterek listája)
        public double Kerület()
        {
            return 2 * r * Math.PI;
        }
        public double Terület()
        {
            double T = r * r * Math.PI;         
            //visszatérési érték
            return T;
        }   
        public void Kiír()
        {
            Console.WriteLine("\nSugár: " + r);
            Console.WriteLine("Kerület: " + Kerület());
            Console.WriteLine("Terület: " + Terület());
        }
        public void szor(double p)
        {
            r = r * p;
        }



    }
    class Program
    { 
        static void Main(string[] _)
        {
            Kör k1 = new Kör(4.6);
            Kör k2;
            k2 = new Kör(6.8);

            //k1.r = 5;
            Console.WriteLine("Kerület: " + k1.Kerület());
            Console.WriteLine("Terület: " + k1.Terület());
            


            //k2.r = 2.2;
            k2.Kiír();



            Kör Máté = new Kör();
            Máté = k2;   
            Máté.Kiír();
            Máté.szor(45.678);

            Máté.Kiír();




            Console.ReadKey();
        }
    } 
}
