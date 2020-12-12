using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekérés_consol_gyak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            // Állítson be piros hátteret és fehér betűszínt!

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            // Az ablak legyen 65 karakter széles és 20 karakter magas!

            Console.WindowWidth= 65;
            Console.WindowHeight = 20;

            // Az ablak címe legyen: Programozás gyakorló feladat!
            Console.Title = "Programozás gyakorló feladat";

            // 2. feladat:
            // Kérjen be a felhasználótól két egész számot x és y változókba!

            int x, y;

            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());

            // Törölje a kurzort!
            Console.CursorVisible = false;
            // Írja ki a két szám hányadosait egy-egy sor kihagyással!
            Console.WriteLine("x / y = " + (double)x / y);
            Console.WriteLine("y / x = " + (double)y / x);

            // 3. feladat:
            // Várakozzon billentyűleütésig, majd törölje a konzolablakot! Az üzenetet a 15. sor alá írja ki!
            // Állítsa vissza a kurzor!
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("Nyomj le egy billenytűt");

            Console.ReadKey();
            Console.Clear();
            Console.CursorVisible = true;
           
           


            // Kérjen be egy tetszőleges számot, 0 és 50 között!
            Random rnd = new Random();
            double szám;

            Console.Write("Írj be egy tetszőleges számot");


            szám = double.Parse(Console.ReadLine());


            // Törölje e kurzort majd írja ki a szám hatodik hatványát!
            Console.CursorVisible = false;

            Console.WriteLine("\nSzám 6. hatvány = " +Math.Pow(szám, 6));


            // Várjon a program 4,5 másodpercig (system -> threading -> thread ...)
            System.Threading.Thread.Sleep(4500);
            Console.Clear();


            // 4. feladat: 
            // Állítsa vissza a kurzor!
            // Kérjen be egy egész számot 32 és 200 között, 
            // majd írja ki hogy ez milyen karakternek felel meg! 
            // A karaktert az ötödik sornak kb a közepére írja ki!
            // Törölje e kurzort!
            // Várakozzon a program bill. leütésig!

            Console.CursorVisible = true;
            int szám2;
            Console.WriteLine("Írj be egy számot 32 és 200 között");
            szám2 = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(32, 4);

            Console.WriteLine((char)szám2);



            Console.CursorVisible = false;
            
            Console.ReadKey();
        }
    }
}
