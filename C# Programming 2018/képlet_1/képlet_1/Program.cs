using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace képlet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;

            a = 12.5;
            b = 4;
            c = (2*a+5*b )/( 2*a*b-3*a);
            d = 5 / 3 + (7 * a - 3 * b) / (a * b - c) + Math.Sqrt(b);
            e = Math.Sqrt((a+b)/(c+d) );
            f = a / (5 * b) * Math.Pow(b, 7);




            Console.WriteLine("c= "+ c);
            Console.WriteLine("d= " + d);
            Console.WriteLine("e= " + e);
            Console.WriteLine("f= " + f);









            Console.ReadKey();
        }
    }
}
