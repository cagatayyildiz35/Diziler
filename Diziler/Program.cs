using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { -25, 33, -1 };

            //string[] meyveler = { "armut", "incir", "karpuz" };
            //meyveler[1] = "kavun";


            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.WriteLine(meyveler[i]);
            //}

            //Console.ReadLine();

            ////Console.WriteLine(meyveler[1]);
            ////Console.ReadLine();

            int[] sayi = new int[3];

            sayi[0] = -2;
            sayi[1] = 33;
            sayi[2] = 55;
            //sayi[3] = 22;

            //5 elemanlı bir int dizi tanımla. Dizideki sayıların toplamını ekrana yazdır
            //int[] sayilar = new int[5];
            //int[] sayilar = { 4, 3, 7, -2, 5 };

            //int toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam = toplam + sayilar[i];
            //}

            //Console.WriteLine(toplam);
            //Console.ReadLine();



            //5 elemanlı bir dizi tanımla tek sayıların toplamını ekrana yazdır.
            int[] sayilar = { 2, 5, 6, 3, -2 };

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 != 0)
                {
                    toplam = toplam + sayilar[i];
                }
            }

            Console.WriteLine(toplam);
            Console.ReadLine();








        }
    }
}
