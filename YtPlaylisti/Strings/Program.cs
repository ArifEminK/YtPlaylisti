using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "Benim adım Arif.";
            //B ile mi başlıyor
            bool result = kelime.StartsWith("B");
            //B ile mi bitiyor
            bool result2 = kelime.EndsWith("B");
            //String'in uzunluğu
            var result3 = kelime.Length;
            //String'i result4'e klonla
            var result4 = kelime.Clone();
            //m harfi baştan kaçıncı harfte
            var result5 = kelime.IndexOf("m");
            //m harfi sondan kaçıncı harfte
            var result6 = kelime.LastIndexOf("m");
            //String'e başka bir metin ekleme
            var result7 = kelime.Insert(0, "Merhaba, ");
            //String'i okumaya verilen sayıdan başla ve verilen sayıya kadar oku
            var result8 = kelime.Substring(6,4);
            //String'in hepsini küçük oku
            var result9 = kelime.ToLower();
            //String'in hepsini büyük oku
            var result10 = kelime.ToUpper();
            //String'in içinde belirtilen karakterin yerine belirtilen karakteri koy
            var result11 = kelime.Replace(" ", "-");
            //String'den 5ten itibaren 5 karakteri sil
            var result12 = kelime.Remove(5, 5);
            Console.WriteLine(result + "\n" + result2 + "\n" + result3 + "\n"
                + result4 + "\n" + result5 + "\n" + result6 + "\n" + result7
                + "\n" + result8 + "\n" + result9 + "\n" + result10 +
                "\n" + result11 + "\n" + result12);
            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
                Console.WriteLine(String.Format("-{0}", city));
            }
        }
    }
}
