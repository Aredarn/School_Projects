using System;

namespace osztály_adattag
{
    class diák  //osztály fejrésze
    {
        public string név;  //string típusú adattag
        public double átlag; //double típusú adattag
        public int kor; //int típusú adattag
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Objektumpéldányok deklarálása és létrehozása:
            diák d1 = new diák();
            diák d2 = new diák();

            d1.név = "Sanyi";
            d1.átlag = 1.4;
            d1.kor = 22;


            Console.WriteLine(d1.név + " " + d1.átlag + " " + d1.kor);

            Console.Write("Ki a másik diák: ");
            d2.név = Console.ReadLine();
            Console.Write("Hány éves?: ");
            d2.kor = int.Parse(Console.ReadLine());


            if(d1.kor > d2.kor)
                Console.WriteLine(d1.név +" idősebb, mint " + d2.név);
            else
                Console.WriteLine(d2.név + " idősebb, mint " + d1.név);
            Console.ReadKey();
        }
    }
}
