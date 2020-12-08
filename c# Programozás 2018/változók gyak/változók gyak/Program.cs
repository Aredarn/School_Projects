using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace változók_gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            //egész típusú változók
            int e1, e2, e3;

            e1 = 98;
            e2 = 7;

            e3 = e2 * e1;

            Console.WriteLine("e2*e3 =" + e3);
            Console.WriteLine("e2-e1 =" + (e2 - e1));

            Console.WriteLine(e2 +"*" + e3 + "=" + e3);

            //Maradékképzés
            int osztó, szám, maradék;

            szám = 1000;
            osztó = 17;

            maradék = szám % osztó;

            Console.WriteLine(szám + "/" + osztó + " " + maradék + " maradékot ad");

            //növelés 1-gyel
            ++szám;

            Console.WriteLine(szám);
            szám = szám + 15;
            Console.WriteLine(szám);
            szám += 12;                     //szám = szám + 12
            Console.WriteLine(szám);


            //karater változó
            char betű;

            betű = 'b';
            Console.WriteLine(betű);
            --betű;
            Console.WriteLine(betű);



            Console.ReadLine();
        }
    }
}
