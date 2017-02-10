using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApplication3
{
    static class Constants
    {
        public const int ASCII_A = 65;
        public const int ASCII_Z = 90;
        public const int ASCII_a = 97;
        public const int ASCII_z = 122;
        public const int RANGE = 26;
    }
    class Program
    {
        static void Main(string[] args)
        {
            String sifra = sifruj("Pavelka", 2);
            Console.WriteLine(sifra);
            Console.ReadKey();
        }

        public static string sifruj(string text, int klic=1)
        {
            bool xJeVelke = false;
            string sifra = "";
            foreach (int x in text)
            {
                if (x >= Constants.ASCII_A && x <= Constants.ASCII_Z)
                    xJeVelke = true;
                else if (x >= Constants.ASCII_a && x <= Constants.ASCII_z)
                    xJeVelke = false;
                else
                    throw new Exception("V textu jsou jiné znaky nez pisemna.");

                int pismeno = x + klic;
                if (xJeVelke && pismeno > Constants.ASCII_Z)
                    pismeno = pismeno - Constants.RANGE;
                else if (!xJeVelke && pismeno > Constants.ASCII_z)
                    pismeno = pismeno - Constants.RANGE;
                sifra = sifra + (char)pismeno;
                
            }
            
            return sifra;
        }

    }
}
