using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayi giriniz:");
             int sayi = int.Parse(Console.ReadLine());
             int sayac = 1;
             int toplam = 0;
            while (sayac<=sayi)
            {
                 toplam += sayac;
                 sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            char character = 'a';
            while (character < 'z')
             {
                Console.Write(character);
                character ++;
             }
             
             string[] arabalar = {"bmw","ford","toyota","nissan"};
             foreach (var araba in arabalar)
             {
                 Console.WriteLine(araba);
             }
        }
    }
}
