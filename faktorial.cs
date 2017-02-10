using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Zadej číslo pro výpočet faktoriálu------------------------");
        tucnak:
            int vstup = Convert.ToInt32(Console.ReadLine());
            long tisk = (Factorial(vstup));
            Console.WriteLine(tisk);
            Console.WriteLine("");
            goto tucnak;
                    
        }
        static long Factorial(long n)
        {
            if (n <= 1)
            return 1;
                else
            return n * Factorial(n - 1);
        }
    }
}
