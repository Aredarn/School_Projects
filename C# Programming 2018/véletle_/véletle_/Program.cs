using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace véletle_
{
    class Program
    {
        static void Main(string[] args)
        {
            //véletlen számok visszahozása
            //Véletlen objektum létrehozása:
            Random rnd = new Random();

            int vél;

            //véletlen egész szám:
            vél = rnd.Next();
            Console.WriteLine("1. véletlen szám : " + vél);

            //véletlen szám 0 és egy szám között
            vél = rnd.Next(101);
            Console.WriteLine("2. véletlen szám : " + vél);

            //véletlen 2 tetszőleges szám között

            vél = rnd.Next(-10,11);
            Console.WriteLine("3. véletlen szám : " + vél);

            //véletlen valós szám
           /* while (true)
            {
                double vél2;
                vél2 = rnd.NextDouble();
                Console.WriteLine("4. véletlen szám : " + vél2);
            }
            */

            Console.ReadLine();
        }
    }
}
