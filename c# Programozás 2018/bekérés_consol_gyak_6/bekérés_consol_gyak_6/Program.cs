using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekérés_consol_gyak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat:
            // Állítson be világos hátteret és sötétpirosra, a betűszín pedig legyen tetszőleges, jól olvasható szín!
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // Az ablak legyen 58 karakter széles és 28 karakter magas!
            Console.WindowWidth = 58;
            Console.WindowHeight = 28;



            // Az ablak címe legyen: Programozás felmérő!
            Console.Title = "Programozás felmérő";

            // 2. feladat:
            // Kérje be egy kocka élét az oldal változóba! Az érték tetszőleges szám lehet!
            double kock;

            
            kock = double.Parse(Console.ReadLine());
            Console.WriteLine("Kocka éle = " + kock);


            // Kapcsolja ki a kurzor megjelenését!

            Console.CursorVisible = false;

            // Számolja ki, majd írja ki a felszínt és a térfogatot! (A és V változókat használjon!)
            // Az eredmények előtt egy-egy üres sor legyen!

            double A, V;

            A =  6*kock*kock;
            Console.WriteLine("térfogat = " + A);
            V = kock * kock * kock;
            Console.WriteLine("felszín = " + V);



            // A továbblépéshez kérjen be egy billentyűt, ehhez az üzenetet írja ki a 20 sor alá!
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Nyomj le egy billentyűt");
            Console.ReadKey();

            // 3. feladat:
            // Törölje a konzolablakot
            Console.Clear();
            // Állítsa vissza a kurzor megjelenését!
            Console.CursorVisible = true;
            // Kérje be egy kijelző méretét egész számként cm-ben!

            Console.WriteLine("Kijelző mérete cm: ");
            int cm;
            cm = int.Parse(Console.ReadLine());
            Console.WriteLine("Kijelző mérete cm: " + cm);

            // Kapcsolja ki a kurzor megjelenését!
            Console.CursorVisible = false;


            //  Írja ki a méret értékét hüvelykben (inch) a 7. sor 4. pozíciójától!
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Kijelző mérete inchben = " + cm / 2, 54);


            // Várjon a program 3,5 másodpercig (system -> threading -> thread ...)
            System.Threading.Thread.Sleep(3500);

            // 4. feladat:
            // Törölje a konzolablakot és állíts;a be a kurzor megjelenését!
            Console.Clear();
            // Kérjen be egy ékezetes betűt egy betű nevű változóba! 
            Console.Write("Adj meg egy ékezetes betűt");

            char ekezet;
            ekezet = char.Parse(Console.ReadLine());
            Console.WriteLine(ekezet);


            // Kapcsolja ki a kurzor megjelenését!
            Console.CursorVisible = false;

            // Írja ki a betű kódját a 10. sornak kb. a közepére!
            Console.SetCursorPosition(24, 11);
            Console.Write("betű kódja = " + (double)ekezet);


         // Billentyűleütésre fejeződjön be a program futása!
         Console.ReadKey();
        }
    }
}
