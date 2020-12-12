using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFGB
{
    class Program
    {
        static void Main(string[] args)
        {
            //színek
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear(); //ablak törlése
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("MakiMak");
            Console.Title = "Ez itt a felső sor :)";
            Console.WindowWidth = 50;
            Console.WindowHeight = 15;


            Console.WriteLine("Nyomj le egy billentyűt");
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(5, 2);
            Console.Write("Írj be egy egész számot");

            int szám;

            //beolvasás
            szám = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.SetCursorPosition(15, 5);
            Console.WriteLine(szám);

            Console.CursorVisible = false;

            Console.Beep(7000, 1000);







            Console.ReadKey();
        }
    }
}
