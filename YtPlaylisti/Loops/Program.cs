using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Loops
{

    
        class Program
        {
        static void Main (string[] args)
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("Asal sayı.");
            }
            else
            {
                Console.WriteLine("Asal sayı değil.");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        }
    
}

