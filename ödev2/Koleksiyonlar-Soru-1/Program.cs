using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program{
    
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 adet pzoitif tam sayı giriniz.");
            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            for (int i = 1; i < 21; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i);
                int sayi = int.Parse(Console.ReadLine());
                if(sayi < 0)
                  Console.WriteLine("Pozitif sayı giriniz");

                else if(sayi == 0)
                  Console.WriteLine("Pozitif sayı giriniz");
                
                else if(sayi % 2 !=0 && sayi % 3 !=0 && sayi % 5 !=0 && sayi % 7 !=0)
                asallar.Add(sayi);
                
                else if(sayi == 2)
                asallar.Add(2);
                
                else if(sayi == 3)
                asallar.Add(3);

                else if(sayi == 5)
                asallar.Add(5);

                else if(sayi == 7)
                asallar.Add(7);

                else
                asalOlmayanlar.Add(sayi);
            }
            asallar.Sort();
            asallar.Reverse();
            Console.WriteLine("Asal sayılar:");
            foreach (var item in asallar)
            Console.WriteLine(item);

            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();
            Console.WriteLine("Asal olmayan sayılar:");
            foreach (var item in asalOlmayanlar)
            Console.WriteLine(item);

            Console.WriteLine("Asal olanların eleman sayısı : " + asallar.Count);
            Console.WriteLine("Asal olmayanların eleman sayısı : " + asalOlmayanlar.Count);

            int sayac = 1;
            int toplam = 0;
            for (int i = 0; i < asallar.Count ; i++)
            {
               toplam = toplam + Convert.ToInt32(asallar[i]);
                 sayac ++;
            }
            {
                 
            }
            Console.WriteLine("asalların ortalaması:" +toplam/asallar.Count);
            int sayac2 = 1;
            int toplam2 = 0;
            for(int i=0; i<asalOlmayanlar.Count ; i++)
            {
                 toplam2 = toplam2 + Convert.ToInt32(asalOlmayanlar[i]);
                 sayac2 ++;
            }
            Console.WriteLine("asal olmayanların ortalaması:" + toplam2/asalOlmayanlar.Count);


        }
    }
}