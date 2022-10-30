using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            if (number >= 0 && number <= 100)
                Console.WriteLine("Sayı 100le 0 arasında.");
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Sayı 100le 200 arasında.");
            }
            else if (number < 0 || number > 200)
                Console.WriteLine("Sayı ya 200den büyük ya da negatif");
            Console.ReadLine();

        }
    }
}
