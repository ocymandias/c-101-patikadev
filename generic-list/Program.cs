using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilistesi = new List<int>();
            sayilistesi.Add(23);
            sayilistesi.Add(10);
            sayilistesi.Add(4);
            sayilistesi.Add(5);
            sayilistesi.Add(92);
            sayilistesi.Add(34);


            List<string> renklistesi = new List<string>();
            renklistesi.Add("kırmızı");
            renklistesi.Add("mavi");
            renklistesi.Add("turuncu");
            renklistesi.Add("sarı");
            renklistesi.Add("yeşil");


            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayilistesi.Count);

            foreach (var sayi in sayilistesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renklistesi)
            {
                Console.WriteLine(renk);
            }
            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            sayilistesi.Remove(4);
            renklistesi.Remove("yeşil");
            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));
            sayilistesi.RemoveAt(0);
            renklistesi.RemoveAt(1);
            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            if(sayilistesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu");
            }  
            Console.WriteLine(renklistesi.BinarySearch("sarı"));
            string[] hayvanlar = {"kedi","köpek","kuş"};

            List<string> hayvanlistesi = new List<string>(hayvanlar);
            hayvanlistesi.Clear();
            List<kullanıcılar> kullaniciListesi = new List<kullanıcılar>();
            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.Isim = "ayşe";
            kullanıcı1.Soyisim = "yılmaz";
            kullanıcı1.Yas = 26;
            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı2.Isim = "oğulcan";
            kullanıcı2.Soyisim = "kuyumcuoğlu";
            kullanıcı2.Yas = 23;

            kullaniciListesi.Add(kullanıcı1);
            kullaniciListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniliste = new List<kullanıcılar>();
            yeniliste.Add(new kullanıcılar(){
                Isim = "ahmet",
                Soyisim = "mehmet",
                Yas = 3
            });
            
            foreach (kullanıcılar kullanıcı in kullaniciListesi)
            {
                Console.WriteLine("kullanıcı adı:"+ kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyadı:"+ kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı yas:"+ kullanıcı.Yas);
            }

            yeniliste.Clear();
        }
    }
    public class kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

        
    }
}
