using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 10;
            number1 = '$';

            Console.WriteLine(number1);
            Console.WriteLine((int)Gunler.Pazar);
            Console.ReadLine();
        }
        enum Gunler
        {
            Pazartesi=10, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar        
        }
    }
}
