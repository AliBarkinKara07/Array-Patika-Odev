using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 10, 11, 15, 90, 100 };
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //////////////////////////////////
            Console.WriteLine("Sıralı Diziler");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            ///////////////////////////////
            Console.WriteLine("Clear Metodu");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);

            }
            //////////////////////////////
            Console.WriteLine("Reverse Metodu");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);

            }
            Console.WriteLine("Index of ");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 100));

            ////////////////////////////////
            ///
            Console.WriteLine("Resize");
            Array.Resize<int>(ref sayiDizisi, 6);
            sayiDizisi[5] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);

            }
           

        }
    }
}
