using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 adet tam sayı giriniz.");
            int[] sayilar = new int[20];
            int[] kucukler = new int[3];
            int[] buyukler = new int[3];
            for (int i = 1; i < 21; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i);
                sayilar[i-1] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            kucukler[0] = sayilar [0];
            kucukler[1] = sayilar [1];
            kucukler[2] = sayilar [2];
            foreach (var item in kucukler)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(sayilar);
            buyukler[0] = sayilar [0];
            buyukler[1] = sayilar [1];
            buyukler[2] = sayilar [2];
            foreach (var item in buyukler)
            {
                Console.Write(item);
            }
            

            int sayac = 1;
            int toplam = 0;
            for(int i=0; i<kucukler.Length ; i++)
            {
                 toplam = toplam + kucukler[i];
                 sayac ++;
            }
            Console.WriteLine("en küçük 3 sayının ortalaması:" + toplam/kucukler.Length);
            int sayac2 = 1;
            int toplam2 = 0;
            for(int i=0; i<buyukler.Length ; i++)
            {
                 toplam2 = toplam2 + buyukler[i];
                 sayac2 ++;
            }
            Console.WriteLine("en büyük 3 sayının ortalaması:" + toplam2/buyukler.Length);
            Console.WriteLine("ortalamaları toplamı:" + (toplam/kucukler.Length)+(toplam2/buyukler.Length));


        }

    }
}