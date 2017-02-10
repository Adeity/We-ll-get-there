using System;
using System.IO;

namespace nahodne_jmeno
{
    class Program
    {
        private static Random nahoda = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Pro vygenerovani nahodneho jmena zmackni Enter");

            string znak = Console.ReadLine();
            if (znak == "")
                goto zacatek;
            else
                goto konec;
            zacatek:
            string jmeno = nahodnyRadek("jmeno.txt");
            string prijmeni = nahodnyRadek("prijmeni.txt");
            string titul = nahodnyRadek("titul.txt");
            Console.WriteLine(titul + " " + jmeno + " " + prijmeni);
            string znak2 = Console.ReadLine();
            if (znak2 == "")
                goto zacatek;
            else goto konec;
            konec:
            Console.WriteLine("Konec");
        }
        public static string nahodnyRadek(string jmeno)
        {
            var radek = File.ReadAllLines(jmeno);
            var cisloRadku = nahoda.Next(0, radek.Length);
            return radek[cisloRadku];
        }
    }
}