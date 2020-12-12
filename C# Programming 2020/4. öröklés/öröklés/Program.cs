using System; 

namespace ConsoleApplication1 
{   
    // Négyzet osztály:
    class négyzet
    {
        public double a;  // oldal

        public négyzet()
        {
            a = 0;
        }

        public négyzet(double oldal)
        {
            a = oldal;
        }

        public double kerület()
        {
            return 4 * a;
        }

        public double terület()
        {
            return a * a;
        }
    }
    // téglalap osztály örökléssel:
    class Téglalap : négyzet
    {
        //adattag:
        public double b;

        //konstruktorok:
        public Téglalap() : base()
        {
            b = 0;
        }

        public Téglalap(double a_oldal, double b_oldal) : base(a_oldal)
        {
            b = b_oldal;
        }

        //metódusok
        public new double kerület()
        {
            return 2 * (a + b);
        } 

        public new double terület()
        {
            return a * b;
        }




    }
    // kocka osztály örökléssel:
    class Kocka : négyzet
    {
        //adattag: csak az örökölt 'a' oldal

        public Kocka() : base()
        { }

        public Kocka(double oldal) : base(oldal)
        { }

        public double Felszín()
        {
            return 6 * terület();
        }

        public double térfogat()
        {
            return a * terület();
        }

    }







    class Program
    {
        static void Main(string[] _)
        {
            négyzet n1 = new négyzet(4);
            Console.WriteLine(n1.terület());
            

            Téglalap t1 = new Téglalap(10,5);
            Console.WriteLine(t1.terület());

            Kocka k1 = new Kocka(4.5);
            Console.WriteLine(k1.térfogat());


            Console.ReadKey();
        }
    }
}
