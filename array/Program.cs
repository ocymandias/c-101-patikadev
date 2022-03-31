using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi ={23,12,4,86,72,3,11,17};
            foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);

            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);

            Array.Clear(sayidizisi,2,2);
            foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);

            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);
            Console.WriteLine(Array.IndexOf(sayidizisi,23));

            Array.Resize<int>(ref sayidizisi,9);
            sayidizisi[8] = 99;
            foreach (var sayi in sayidizisi)
            Console.WriteLine(sayi);



        }
    }
}
