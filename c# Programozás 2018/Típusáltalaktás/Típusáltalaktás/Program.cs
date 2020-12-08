using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Típusáltalaktás
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 47 , b = 10;
            //számolás
            double hányados;

            hányados = 35 / 14;
            Console.WriteLine("Hányados = " + hányados);


            hányados = a / b;
            Console.WriteLine(a + " / " + b + " = " + hányados);


            //pontos  osztási  eredmény double= x.0 érték megadása
            hányados = 35.0 / 14;
            Console.WriteLine("35.0/14 = " + hányados);

            //pontos  osztási  eredmény  érték megadása változó pontos megadása segítségével
            hányados = (double) 35 / 14;
            Console.WriteLine("35/14 = " + hányados);

            //Beolvasás
            Console.WriteLine("\n Írj be egy karaktert: ");

            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("\nA karakter kódja: " + (int) ch);


            Console.ReadKey();           
        }
    }
}
