﻿using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList liste = new ArrayList();
        //    liste.Add("ayşe");
        //    liste.Add(2);
        //    liste.Add(true);
        //    liste.Add('a');
        //    Console.WriteLine(liste[1]);
        //    foreach (var item in liste)
        //      Console.WriteLine(item);
           
        //    string[] renkler = {"kırmızı","sarı","yeşil"};
           List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
        //    liste.AddRange(renkler);
           liste.AddRange(sayılar);
           foreach (var item in liste)
             Console.WriteLine(item);


           liste.Sort();
            foreach (var item in liste)
             Console.WriteLine(item);


           Console.WriteLine(liste.BinarySearch(9));


           liste.Reverse();
           foreach (var item in liste)
              Console.WriteLine(item);


           liste.Clear();

            foreach (var item in liste)
             Console.WriteLine(item);

        }
    }
}