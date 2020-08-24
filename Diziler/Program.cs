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

            //            Klavyeden bir kelimenin ,girilen cümlede kaç kez tekrar ettiğini bulalım
            //-- ali ata bak.aman da aman ali. ali de ali


            Console.WriteLine("Cümle gir");
            string cumle = Console.ReadLine();

            Console.WriteLine("Kelime gir");
            string kelime = Console.ReadLine();


            string parca = "";
            int adet = 0;
            //Emel süt iç
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] == ' ')
                {
                    if (kelime == parca)
                    {
                        adet++;
                        parca = "";
                    }
                    else
                    {
                        parca = "";
                    }
                }
                else
                {
                    parca = parca + cumle[i];
                    if(i == cumle.Length - 1)
                    {
                        if (kelime == parca)
                        {
                            adet++;
                            parca = "";
                        }
                        else
                        {
                            parca = "";
                        }
                    }
                }
            }

            Console.WriteLine(adet);
            Console.ReadLine();



            //Console.ForegroundColor = ConsoleColor.Red;
            ////adam asmaca
            ////5 yanlış gider

            //string[] sehirler = new string[7];
            //sehirler[0] = "Aydın";
            //sehirler[1] = "İstanbul";
            //sehirler[2] = "İzmir";
            //sehirler[3] = "Ankara";
            //sehirler[4] = "Diyarbakır";
            //sehirler[5] = "Trabzon";
            //sehirler[6] = "Edirne";

            //int sonucc = Array.IndexOf(sehirler, "EdirneEEE");

            //Random rnd = new Random();
            //int rastgelesehir = rnd.Next(0, 7);

            //string bulunacak = sehirler[rastgelesehir];

            //char[] bulunan = new char[bulunacak.Length];
            //for (int i = 0; i < bulunacak.Length; i++)
            //{
            //    bulunan[i] = '_';
            //}
            //int yanlis = 0;
            //int dogru = 0;
            //bool oyundurum = true;
            //while (oyundurum)
            //{
            //    char harf = Convert.ToChar(Console.ReadLine());
            //    bool harfvarMi = false;
            //    for (int i = 0; i < bulunacak.Length; i++)
            //    {
            //        if (bulunacak[i] == harf)
            //        {
            //            bulunan[i] = harf;
            //            harfvarMi = true;
            //            dogru++;
            //        }

            //    }


            //    if (harfvarMi == false)
            //    {
            //        yanlis++;
            //    }
            //    if (yanlis > 5)
            //    {
            //        Console.WriteLine("GAME OVER!!!");
            //        oyundurum = false;
            //    }
            //    else
            //    {
            //        string sonuc = "";

            //        for (int i = 0; i < bulunan.Length; i++)
            //        {
            //            sonuc = sonuc + bulunan[i];
            //        }

            //        Console.WriteLine(sonuc);

            //        if (dogru == bulunan.Length)
            //        {
            //            Console.WriteLine("KAZANDIN!!!! BRAVO ÇİÇEK BÖCEK!!");
            //            oyundurum = false;

            //        }
            //    }

            //}

            //Console.ReadLine();



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
            //int[] sayilar = { 2, 5, 6, 3, -2 };

            //int toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 != 0)
            //    {
            //        toplam = toplam + sayilar[i];
            //    }
            //}

            //Console.WriteLine(toplam);
            //Console.ReadLine();


            //int[] sayilar = { 2, 5, 6, 3, -2 };

            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);

            //int index = Array.IndexOf(sayilar, 5);

            //N elemanlı bir dizideki en küçük elemanı ve bu elemanın adresini (index no) bulan program. 

            //int[] sayilar = { 2, 5, 6, 3, -2 };
            //int min = sayilar[3];
            //int index = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < min)
            //    {
            //        min = sayilar[i];
            //        index = i;
            //    }
            //}

            //Console.WriteLine("Min sayı " + min + " Index " + index);
            //Console.ReadLine();

            // Dışarıdan girilen N elemanlı bir diziyi yedek dizi kullanmadan tersine çeviren program
            //int[] sayilar = { 2, 5, 6, 3, -2,22 };
            //int temp = 0;
            //for (int i = 0; i < sayilar.Length / 2; i++)
            //{
            //    temp = sayilar[i];
            //    sayilar[i] = sayilar[sayilar.Length -1 - i];
            //    sayilar[sayilar.Length - 1 - i] = temp;
            //}

            //Random rnd = new Random();
            //int rastgele = rnd.Next(1, 40);

            //bana 5 elemanlı bir sayı dizisi oluştur. Sayılar 1-100 arasında rastgele sayılar olsun
            //int[] sayilar = new int[5];

            //Random rnd = new Random();

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 100);
            //}


            //Mini sayısal loto
            //1-20 arasında 6 tane sayı

            //int[] sayidizi = new int[6];
            //Random rnd = new Random();


            //for (int i = 0; i < sayidizi.Length; i++)
            //{
            //    int sayac = 0;
            //    int rastgele = rnd.Next(1, 20);
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (sayidizi[j] == rastgele)
            //        {
            //            sayac++;
            //        }
            //    }

            //    if (sayac == 0)
            //    {
            //        sayidizi[i] = rastgele;
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}


            //for (int i = 0; i < sayidizi.Length; i++)
            //{
            //    int rastgele = rnd.Next(1, 20);
            //    //ürettiğim rastgele sayı dizide var mı?

            //    bool sayivarMi = false;
            //    for (int j = 0; j < sayidizi.Length; j++)
            //    {
            //        if (rastgele == sayidizi[j])
            //        {
            //            sayivarMi = true;
            //        }
            //    }

            //    if (sayivarMi)
            //    {
            //        i--;
            //    }
            //    else
            //    {
            //        sayidizi[i] = rastgele;
            //    }

            //}


            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //int sayi5 = Convert.ToInt32(Console.ReadLine());
            //int sayi6 = Convert.ToInt32(Console.ReadLine());

            //int kazanc = 0;
            //for (int i = 0; i < sayidizi.Length; i++)
            //{
            //    if(sayidizi[i] == sayi1 || sayidizi[i] == sayi2 || sayidizi[i] == sayi3 || sayidizi[i] == sayi4 || sayidizi[i] == sayi5 || sayidizi[i] == sayi6 )
            //    {
            //        kazanc++;
            //    }
            //}

            //if(kazanc != 0)
            //{
            //    Console.WriteLine(kazanc + " bildiniz");
            //}
            //else
            //{
            //    Console.WriteLine("tırt");
            //}

            //Console.ReadLine();









        }
    }
}
