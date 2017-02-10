using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int vstup;

        zacatek:
            Console.WriteLine("Zadej počet kroků Fibonacciho posloupnosti (f(0)=15, f(1) = 60), nebo zadej -1 pro ukončení programu:");
            vstup = Convert.ToInt32(Console.ReadLine());

            if (vstup < 0)
                goto konec;

            Console.WriteLine("Vysledek:");
            Console.WriteLine(Fibonacci(vstup, 60, 15));
            Console.WriteLine("");
            goto zacatek;

        konec:
            Console.WriteLine("Nashledanou!");
            return;
        }

        static int Fibonacci(int n, int ted, int pred)
        {

            if (n == 0)
                return pred;
            else if (n == 1)
                return ted;
            return Fibonacci(n - 1, ted + pred, ted);
        }

    }
}
