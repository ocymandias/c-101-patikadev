using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, hosgeldiniz";
            string degisken2 = "CSharp";

            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(String.Concat(degisken," merhaba"));
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("merhaba"));
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("aaaaa"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            Console.WriteLine(degisken.Insert(0,"merhaba "));
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2); 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));
            Console.WriteLine(degisken.Split(' ')[1]);
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            

        }
    }
}