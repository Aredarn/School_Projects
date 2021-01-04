using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// Hozzon létre egy osztályt, amelyben részvények nevét, nyitó és záróárát, valamint az árváltozást tudjuk tárolni.
// Olvassa be az adatokat a tozsde.txt állományból egy objektumtömbbe és oldja meg a feladatokat!

class részvény
{
    //Adattagok:
    public string név;
    public int nyitó;
    public int záró;

    // konstruktor:
    public részvény (string s)
    {
        string[] st = s.Split('#');
        //értékeadás az adattagoknak:
        név = st[0];
        nyitó = int.Parse(st[1]);
        záró = int.Parse(st[2]);
    }

    //árváltozás tagfüggvény:
    public int árvált()
    {
        return záró - nyitó;
    }

    public void kiír()
    {
        Console.WriteLine($"{név} nyitó ár: {nyitó}, záró ára: {záró} és az árváltozás: {árvált()}");
    }
}



namespace osztály_tömb_gyak_1_részvény
{

    class Program
    {
        static void Main(string[] args)
        {
            // Az adatok beolvasása egy string tömbbe úgy, hogy az állomány egy-egy sorból lesz egy tömbelem:
            string[] be = File.ReadAllLines("tozsde.txt");


            // A tömb hosszának megállapítása és eltárolása:
            int n = be.Length;

            // Az objektum tömb létrehozása:
            részvény[] t = new részvény[n];

            // A tömb elemeinek (objektumok) felvétele ciklussal:
            int i;
            for (i = 0; i < n; i++)
            {
                t[i] = new részvény(be[i]);
            }

            // Az objektum tömb elemeinek kiírása tagfüggvénnyel:
            for (i = 0; i < n; ++i)
                t[i].kiír();


            // Írja ki az adatokat a eredmeny.txt állományba úgy,
            // hogy az első adat a változás értéke legyen, az elválasztójel pedig egy szóköz!
            // A objektum tömb elemeinek kiírása állományba:
            StreamWriter ki = new StreamWriter("eredmény.txt");
            for (i = 0; i < n; i++)
            {
                ki.Write(t[i].árvált() + " ");
                ki.Write(t[i].név + " ");
                ki.Write(t[i].nyitó + " ");
                ki.WriteLine(t[i].záró + " ");

            }
            ki.Close();


            Console.ReadKey();

        }
    }
}
