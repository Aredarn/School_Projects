using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Első_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiírás a konzolra
            
            Console.Write("Hello world! \n");
            Console.WriteLine("Idézőjel(\") írása"); 
            Console.WriteLine("\n Nyomj egy Enter billentyűt");
            Console.ReadLine();

            //Képernyőtörlés

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();



            //Hang generálása
            Console.Beep(5000, 1000);
            Console.WriteLine("Makimak");
            Console.Title = "10.b Informatika";

            Console.ReadKey();


            /*több
             soros
             komment
             */
        }
    }
}
