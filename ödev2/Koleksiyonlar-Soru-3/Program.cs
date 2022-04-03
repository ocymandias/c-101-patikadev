using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir cümle giriniz");
            string cumle=Console.ReadLine();
            char[] sesliler ={'a','e','ı','i','u','ü','o','ö'};
            string harfler = "";

            foreach (var item in cumle)
             if(item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                harfler += item;

            foreach (var item in harfler)
            {
                Console.WriteLine(item);
            }    
        }
    }
}