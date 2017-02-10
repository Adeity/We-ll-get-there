using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {


        static void Main(string[] args)
        {
            int vstup;
            int maxChybnaZadani = 3;
            int chybnaZadani = 0;

        zacatek:
            Console.WriteLine("Zadej úhel pro výpočet Cos2x + Sinx, pro ukončení programu zadej -1");
            try
            {
                vstup = Convert.ToInt32(Console.ReadLine()); ;
            }
            catch (Exception e)
            {
                vstup = -1;
            }

            if (vstup < 0)
            {
                // Pricti k chybnym zadanim
                chybnaZadani = chybnaZadani + 1;
                if (chybnaZadani == maxChybnaZadani)
                {
                    // Dosazeno maximalniho poctu chybnych zadani. Skonci.
                    Console.WriteLine("Chybne zadani.");
                    goto konec;
                }
                else
                {
                    // Vypis pocet zbyvajicich moznych chybnych zadani
                    Console.WriteLine("Chybne zadani. Zbyva " + (maxChybnaZadani - chybnaZadani).ToString() + " pokusu.");
                }
                goto zacatek;
            }
            else
                // Vynuluj pocitadlo chybnych zadani
                chybnaZadani = 0;

            Console.WriteLine("Výsledek:");
            Console.WriteLine(Stereo(vstup));
            Console.WriteLine();
            goto zacatek;

        konec:
            Console.WriteLine("Nashledanou!");
            return;
        }

        static double Stereo(int n)
        {
            return Math.Cos(2 * n) + Math.Sin(n);
        }

    }
}
