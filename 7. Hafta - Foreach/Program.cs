using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Hafta___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu


            // Foreach( Degisken Turu ; Degisken Adi ; In ; Liste, Koleksiyon, Dizi)
            // seklinde 4 parametre alir for gibi calisir

            //string[] cities = { "ankara", "istanbul", "erzurum", "adana" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 13, 21, 3, 443, 52, 62, 23 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 13, 21, 3, 443, 52, 62, 23 };

            //int total = 0;

            //foreach (int number in numbers) { 
            //    total += number;

            //}
            //Console.WriteLine(total);




            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 6, 7
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Numan Baba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Son Cyntax Ornegi (Sinav Sistemi)


            Console.Write("***** C# Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Siniftaki Ogrenci Sayi Girdisi Burada Aliniyor
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Sinifinizda Kac Ogrenci Var: ");

            int studenCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");


            //Ogrenci isim ve not ortalamalarini saklayacak diziler
            string[] studentNames = new string[studenCount];
            double[] studentExamAvg = new double[studenCount];

            for (int i = 0; i < studenCount; i++)
            {
                Console.Write($"{i + 1}. Ogrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExamResault = 0;

                //Her ogrenci icin 3 sinav notu girisi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adli ogrencinin {j + 1}. sinav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResault += value; //notlari topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResault / 3;

            }

            //Sinav Ortalamalari

            for (int i = 0; i < studenCount; i++)
            {



                //Ogrencilerin Ortalamasi ve Gecip Kalma Durumlari 

                if( studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i] } Adli Ogrenci Dersi Gecti");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adli Ogrencini Kaldi ");
                }
                Console.WriteLine() ;
                Console.WriteLine($"{studentNames[i]} adli ogrencinin ortalamasi: {studentExamAvg[i]}");
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine();

            }







            #endregion


            Console.Read();
        }
    }
}
