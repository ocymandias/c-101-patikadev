using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
           kullanıcılar.Add(10,"ayşe yılmaz");
           kullanıcılar.Add(12,"ahmet yılmaz");
           kullanıcılar.Add(18,"deniz arda");
           kullanıcılar.Add(20,"özcan coşar");

           Console.WriteLine("**** elemanlara erişim*****");
           Console.WriteLine(kullanıcılar[12]);
           foreach (var item in kullanıcılar)
              Console.WriteLine(item);


            Console.WriteLine(kullanıcılar.Count);

            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("aaaa"));


            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
              Console.WriteLine(item.Value);


            foreach (var item in kullanıcılar.Keys)
                 Console.WriteLine(item);

             foreach (var item in kullanıcılar.Values)
                 Console.WriteLine(item);


        }
    }
}
