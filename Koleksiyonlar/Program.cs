using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Sena", "Engin", "Murat", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //isimler = new string[2];
            //isimler[2] = "Berkay";
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> {"Sena","Engin","Murat","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
        
    }
}
