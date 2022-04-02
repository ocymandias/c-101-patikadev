using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. soru:lütfen pozitif bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("lütfen {0}. sayıyı gir:", i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }
        for (int i = 0; i < n; i++)
            {
            if(sayidizisi[i]%2 ==0)
              {
               Console.WriteLine(sayidizisi[i] + ":çift sayıdır");
              } 
            }
        
        Console.WriteLine("2. soru:lütfen pozitif iki sayı giriniz");
        int k = int.Parse(Console.ReadLine());
        int j = int.Parse(Console.ReadLine());
        int[] sayidizisi2 = new int[k];
        for (int i = 0; i < k; i++)
            {
                Console.Write("lütfen {0}. sayıyı gir:", i+1);
                sayidizisi2[i] = int.Parse(Console.ReadLine());
            }
        for(int i=0; i<k;i++)
           {
               if(sayidizisi2[i]%j==0)
               Console.WriteLine(sayidizisi2[i] +" sayısı " + j+ " sayısına tam bölünür");
           }
        Console.WriteLine("3. soru:lütfen pozitif bir sayı giriniz");
            int z = int.Parse(Console.ReadLine());
            string[] kelimedizisi = new string[z];
            for (int i = 0; i < z; i++)
            {
                Console.Write("lütfen {0}. kelimeyi gir:", i+1);
                kelimedizisi[i] = Console.ReadLine();
            }
                Array.Reverse(kelimedizisi);
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(kelimedizisi[i]);
            }
        Console.WriteLine("4. soru:lütfen bir cümle yazınız");
            string kelimedizisi2 = Convert.ToString(Console.ReadLine());
            string[] kelime = kelimedizisi2.Split(" ");
            Console.WriteLine("cümlede {0} kadar kelime vardır" , kelime.Length);
            Console.WriteLine("cümlede {0} kadar harf vardır" , kelimedizisi2.Length);
        } 
    }
}