using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutKeyword
{
    class MethodsAndKeywords
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b ;
            var result = Add(ref a,out b);
            Console.WriteLine(result);
            //Ref keyi fonksiyon içinde güncellenen değeri bütün proje için değiştiriyor.
            Console.WriteLine(a);
            //Out keyinin farkı ref keyi gibi önceden değer atanmasına gerek yoktur.
            Console.WriteLine(b);
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(ParamsAdd(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static int Add(ref int a,out int b)
        {
            a = 20;
            b = 30;
            return a + b;
        }



        //Bir fonksiyona daha fazla parametre girmeye "Overloading" denir.
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        //Params keyi ile parametre yığını yapmak yerine toplu bir şekilde yazabiliriz
        static int ParamsAdd(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
