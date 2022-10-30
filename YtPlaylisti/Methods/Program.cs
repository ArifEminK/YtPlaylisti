using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add2()); 
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2( int sayi1 = 10, int sayi2 = 11)
        {
            var a = sayi1 + sayi2;
            return a;
        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;  
        }
    }
}
