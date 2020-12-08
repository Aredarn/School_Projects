using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch ;

            Console.Write("Karakter: ");

            ch = char.Parse(Console.ReadLine());

            //kis betű-e a beírt karakter
            if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("Angol kisbetű.");
            else
                Console.WriteLine("nem angol kisbetű");



            //s betűt írunk-e be:

            if (ch == 's' || ch =='S')
                Console.WriteLine("s betűt írt be");
            else
                Console.WriteLine("Nem s betűt írt be");


            Console.WriteLine("A továbblépéshez nyomd le a \"t\" betűt");
            ch = char.Parse(Console.ReadLine());

            if (ch == 't' || ch == 'T')
                Console.WriteLine("OK, megyünk tovább");
            else
            {
                Console.WriteLine("Nem talált");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            Console.Write("Évszám: ");


            //év szökőév e 

            int év;

            év = int.Parse(Console.ReadLine());
             
            if((év % 4 == 0 && év%100!=0  || év % 400 ==0))


            Console.ReadKey();
        }
    }
}
