using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb_fgv
{
    class Program
    {
        // egy tömb bösszegét kiszámító függvény
        static int t_összeg(int[] t)
        {
            int összeg = 0, i;
            for (i = 0; i < t.Length; ++i)
                összeg += t[i];
            return összeg;
        }

        // Egy adott szám egy tömbben hányszor szerepel:
        static int T_db(int[] t, int ker_szám)
        {
            int db = 0, i;

            for (i = 0; i < t.Length; ++db)
                if (t[i] == ker_szám)
                    ++db;
            return db;
        }


        static void Main(string[] args)
        {
            int[] szamok = { 10, 17, 24, 5, 8, 4, 5, 9, 22, 14, 15, 16 };

            int össz = t_összeg(szamok);

            Console.WriteLine("Összeg: " + össz);


            int db = T_db(szamok, 5);

            Console.WriteLine("db: " + db);

            Console.ReadKey();
        }
    }
}
