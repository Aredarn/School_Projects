using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            Console.WriteLine("1. feladat\n");
            // Deklaráljon két lebegõpontos változót a és b néven:
            double a, b;

            // Kérje be az értéküket a felhasználótól:
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
       

            // Írja ki az a/b hányados értékét, de ügyeljen arra, hogy 0-val nem lehet osztani:
            if (b == 0)
                Console.WriteLine("Nem oszthatsz 0-val");
            else
                Console.WriteLine("a/b = " + (a / b));


            // 2. feladat:
            Console.WriteLine("\n2. feladat\n");
            Random v_obj = new Random();
            int v;

            // v változó legyen egy 400 és 500 közti véletlen szám:
            

            v = v_obj.Next(400, 501);
            // Ha v páros, akkor ossza el 2-vel:
            if (v % 2 == 0)
                v = v / 2;

            // Írja ki v értékét
            Console.WriteLine("v= " + v);

            // 3. feladat:
            Console.WriteLine("\n3. feladat\n");



            // hozzon létre egy karakteres változót ch néven:
            char ch;

            // Írja ki a felhasználónak, hogy nyomja le az i betűt a billentyűzeten:
            Console.WriteLine("nyomja le az i billentyűt");
            // Olvassa be a lenyomott billentyűt a ch változóba:
            ch = char.Parse(Console.ReadLine());

            // Írja ki, hogy jó billentyűt nyomott-e le a felhasználó vagy nem (jó kicsi és a nagy I is):
            if (ch == 'i' || ch == 'I')
                Console.WriteLine("Jó billentyűt nyomott le");
            else
                Console.WriteLine("rossz billentyűt nyomottl le");


            // 4. feladat:
            Console.WriteLine("\n4. feladat\n");
            //Írassa ki, hogy v változó értéke osztható-e 7-tel!
            if (v % 7 == 0)
                Console.WriteLine("osztható 7-el");
            else
                Console.WriteLine("Nem osztható 7-el");


            //Írassa ki, hogy v változó értéke kisebb-e 450-nél!
            if (v < 450)
                Console.WriteLine("Kisebb ,mint 450");
            else
                Console.WriteLine("nem kisebb mint 450");


            Console.ReadKey();
        }
    }
}


