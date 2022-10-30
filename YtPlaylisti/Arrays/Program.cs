using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //students[1] = "Ahmet";
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();
            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir" },
                {"Ankara", "Konya", "Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"Ízmir", "Muğla", "Manisa" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("-----------");
            }
            Console.ReadLine();
        
        }   
    }
}
