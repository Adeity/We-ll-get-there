using System;
using System.IO;

namespace lorem_ipsum
{
    class Program
    {

        private static Random nahoda = new Random();
        static void Main(string[] args)
        {

            int pocet_vet;
            Console.WriteLine("Tohle je generátor Lorem Ipsum.");

            while(1<2)
            {
                Console.WriteLine("Zadej kolik vět chceš vygenerovat, pro ukončení programu zadej 0.");
                try {
                    pocet_vet = Convert.ToInt32(Console.ReadLine()); ;
                } catch (Exception e) {
                    pocet_vet = -1;
                }
                if (pocet_vet <= 0)
                    break;
                Console.WriteLine();
                print_lorem_ipsum(pocet_vet);
                Console.WriteLine();
            }
            Console.WriteLine("Nashledanou!");
        }

        public static void print_lorem_ipsum(int pocet_vet)
        {
            string slovo;
            int pocet_slov_ve_vete;

            string[] slova = nacti_slova("mala.txt");
            int slova_len = slova.Length;

            for (int i=0; i<pocet_vet;i++)
            {
                pocet_slov_ve_vete = nahoda.Next(3, 10);
                if (i>0)
                {
                    // Mezera pred vetou (ktera neni prvni v odstavci)
                    Console.Write(" ");
                }
                for(int j=0; j < pocet_slov_ve_vete; j++)
                {
                    slovo = slova[nahoda.Next(0, slova_len)];
                    if (j > 0)
                    {
                        // Mezera pred slovem (ktere neni prvni ve vete).
                        Console.Write(" ");
                    }
                    else
                    {
                        // Prvni slovo ma velke prvni pismeno.
                        slovo = slovo[0].ToString().ToUpper() + slovo.Substring(1);
                    }

                    Console.Write(slovo);
                }
                // Tecka za vetou
                Console.Write(".");
            }
            Console.WriteLine();
        }

        public static string[] nacti_slova(string soubor)
        {
            return File.ReadAllLines(soubor);
        }
       
        
    }
}