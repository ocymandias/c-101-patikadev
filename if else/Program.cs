using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time <11)
              Console.WriteLine("gunaydin");
            else if(time<= 18)
              Console.WriteLine("iyi günler");
            else
              Console.WriteLine("iyi geceler");

            string sonuc = time<=18 ? "iyi günler" : "iyi geceler";
            sonuc = time>=6 && time<11 ? "günaydın" : time<=18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);


        }
    }
}