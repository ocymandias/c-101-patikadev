using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.Isim = "ahmet";
            ogrenci.Soyisim="mehmet";
            ogrenci.Ogrencino = 1030;
            ogrenci.Sinif=2;
            ogrenci.ogrencibilgilerinigetir();
            ogrenci.sinifatlat();
            ogrenci.ogrencibilgilerinigetir();
            ogrenci ogrenci2 = new ogrenci("mustafa","aydın",1,1);
            ogrenci2.sinidusur();
            ogrenci2.ogrencibilgilerinigetir();
        }
    }
    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrencino;
        private int sinif;

        public string Isim 
        { 
            get{ return isim;} 
            set{ isim= value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        
        public int Sinif 
        {
            get => sinif;
            set
            { 
                if(value<=1){
                Console.WriteLine("sınıf en az 1 olabilir");
                sinif = 1;
                }
                else 
                sinif = value;

            }
            

        }
        public int Ogrencino { get => ogrencino; set => ogrencino = value; }

        public ogrenci(string ısim, string soyisim, int sinif, int ogrencino)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Sinif = sinif;
            Ogrencino = ogrencino;
        }
        public ogrenci(){}

        public void ogrencibilgilerinigetir()
        {
            Console.WriteLine("***** öğrenci bilgileri*******");
            Console.WriteLine("öğrenci adı   :{0}",this.isim);
            Console.WriteLine("öğrenci soyadı   :{0}",this.soyisim);
            Console.WriteLine("öğrenci no   :{0}",this.ogrencino);
            Console.WriteLine("öğrenci sınıf   :{0}",this.sinif);


        }

        public void sinifatlat()
        {
            this.sinif = this.sinif +1;

        }
         public void sinidusur()
        {
            this.sinif = this.sinif -1; 
            
        }
        
    }
}