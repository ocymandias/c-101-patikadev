using System;

namespace static_sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalisanSayisi);

            Calısan calısan = new Calısan("ahmet", "mehmet", "İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalisanSayisi);
            Calısan calısan1 = new Calısan("can", "cem", "İK"); 
            Calısan calısan2 = new Calısan("ayşe", "fatma", "İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calısan.CalisanSayisi);

            
            Console.WriteLine("Toplama işlemi sonucu: {0}" ,Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}" ,Islemler.Cıkar(400, 50));

            
        }
    }
    class Calısan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calısan()
        {
            calisanSayisi = 0;
        }

        public Calısan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }
        public static long Cıkar(int sayı1, int sayı2)
        {
            return sayı1 - sayı2;
        }
    }
}
