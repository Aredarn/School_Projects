using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace többszörös_aláhúzás_elágazás
{
    class Program
    {
        static void Main(string[] args)
        {
            int szám;
            Console.WriteLine("Adj + 1 poz számot: ");
            szám = int.Parse(Console.ReadLine());

            //hány számjegyű 1, 2, 3, 4 vagy több?


            if (szám < 10) 
                 Console.WriteLine("Szám egyjegyű");
            else if (szám < 100)
                Console.WriteLine("A szám kétjegyű");
            else if (szám < 1000)
                Console.WriteLine("A szám háromjegyű");
            else if (szám < 10000)
                Console.WriteLine("A szám 4 jegyű");
            else
                Console.WriteLine("A szám több mint négyjegyű");

                
            




            Console.ReadKey();
        }
    }
}
