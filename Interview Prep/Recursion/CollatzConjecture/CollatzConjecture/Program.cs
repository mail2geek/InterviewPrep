using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =27;
            int steps = Collatz(n);
            Console.WriteLine($"Total steps to reach 1 for {n} is {steps}");
            Console.ReadKey();
        }

        static int Collatz(int n)
        {            
            if (n > 1)
            {
                if (n % 2 == 0)
                    return 1 + Collatz(n / 2);

                return 1 + Collatz(3 * n + 1);
            }

            return 0;
        }
    }
}
