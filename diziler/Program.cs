using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
            int[] dizi;
            dizi = new int[5];
            
            renkler[0] = "mavi";
            
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("lütfen eleman sayısı gir:");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("lütfen {0}. sayıyı gir:", i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam= 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("ortalama:" + toplam/diziuzunlugu);
        }
    }
}