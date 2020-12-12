using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekérés_consol_gyak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            // Állítson be sötét cián háttér és fehér betűszínt!
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // Az ablak legyen 40 karakter széles és 29 karakter magas!
            Console.WindowWidth = 40;
            Console.WindowHeight = 29;

            // Az ablak címe legyen az aktuális dátum és nap!
            Console.Title= "2019.01.28 Hétfő";

            // 2. feladat:
            // Console.WriteLine("2. feladat:");
            // Kérje be a felhasználótól egy téglalap két oldalát a és b változókba!

            double a, b;

            Console.Write("a =");
            a = double.Parse(Console.ReadLine());

            Console.Write("b =");
            b = double.Parse(Console.ReadLine());


            // Törölje le a képernyőt és kapcsolja ki a kurzor megjelenését!
            Console.Clear();
            Console.CursorVisible = false;

            // Számolja ki és írja ki a téglalap kerületét és területét!
            // Az eredmények a 2. és a 4. sorba kerüljenek, soron belül a 3. karaktertől!

            double t, k;

            k = (a + b) * 2;
            t = a * b;

            Console.SetCursorPosition(3, 2);

            Console.WriteLine("kerület= "+ k);

            Console.SetCursorPosition(3, 4);

            Console.WriteLine("terület= " + t);

            // Várakozzn billentyűleütésre a program, amit az utolsó előtti sorba ki is ír!
            Console.SetCursorPosition(1, 28);
            Console.WriteLine("Nyomj le egy gombot : ");
            Console.ReadKey();

            // 3. feladat:
            //Console.WriteLine("\n3. feladat:");
            // Törölje le a konzolablakot!
            Console.Clear();
            // Kapcsolja vissza a kurzort, majd kérjen be egy egész számot a szám változóba!
            Console.CursorVisible = true;
            int c;
            Console.Write("Írj be egy egész számot: ");

            c = int.Parse(Console.ReadLine());

            // A beírt számnak megfelelő másodperc után fejeződjön be a program futása!
            System.Threading.Thread.Sleep(c * 1000);

            // Kapcsolja ki a kurzor megjelenését!
            Console.CursorVisible = false;
            // Várakoztassa a programot!

            //Console.ReadKey();
        }
    }
}
