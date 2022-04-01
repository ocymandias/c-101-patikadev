using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi ="999";
            
           bool sonuc = int.TryParse(sayi, out int outsayi);
          if(sonuc)
          {
              Console.WriteLine("başarılı");
              Console.WriteLine(outsayi);
          }
          else{
              Console.WriteLine("başarısız");
          }
          metotlar instance =new metotlar();
          instance.topla(2,3, out int toplamsonucu);
          Console.WriteLine(toplamsonucu);

          int ifade = 999;
          instance.ekranayazdir(Convert.ToString(ifade));
          instance.ekranayazdir(ifade);
          instance.ekranayazdir("oğulcan","kuyumcuoğlu");
        }
    }
    class metotlar
    {
        public void topla(int a,int b, out int toplam)
        {
            toplam = a+b;
        }

        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}