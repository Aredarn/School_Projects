using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekérés_consol_gyak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            // Állítson be fehér háttér és piros betűszínt!

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Clear();

            // Az ablak legyen 60 karakter széles és 18 karakter magas!
            Console.WindowHeight = 18;
            Console.WindowWidth = 60;
            // Az ablak címe legyen "Gyakorlófeladat"!
            Console.Title = "GyakorlóFealdat";

            // 2. feladat:
            // Console.WriteLine("2. feladat:");
            // Kérje be a felhasználótól egy kör sugarát az r változóba!
            double r;
            Console.Write("kör sugara: ");
            r = double.Parse(Console.ReadLine());


            // Számolja ki és írja ki a kör kerületét és területét!

            double k, t;

            t = r * r * Math.PI;

            k = 2 * r * Math.PI;

            Console.WriteLine("\nKerület:" + k);
            Console.WriteLine("\nTerület:" + t);
            // Kapcsolja ki a kurzor megjelenését!

            Console.CursorVisible = false;

            // Billentyűleütésre menjen tovább a program!
            Console.WriteLine("\nÜss le egy billentyűt! ");
            Console.ReadKey();


            // 3. feladat:
            //Console.WriteLine("\n3. feladat:");
            // Törölje le a konzolablakot!

            Console.Clear();


            // Kapcsolja vissza a kurzort, majd kérjen be egy karaktert a ch változóba!
            Console.CursorVisible = true;
            Console.Write("Karakter: ");
            char ch;
            ch = char.Parse(Console.ReadLine());
            // Törölje a konzolablakot, majd írja ki a karaktert az 5. sor 15. karakterpozíciójára!

            Console.Clear();

            Console.SetCursorPosition(15,5);
            Console.WriteLine(ch);


            // Kapcsolja ki a kurzor megjelenését!
            Console.CursorVisible = false;
            // 5 másodperc várakozás után álljon le a program



            Console.ReadKey();
        }
    }
}
