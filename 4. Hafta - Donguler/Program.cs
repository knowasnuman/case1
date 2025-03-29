using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hafta___Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Dongusu

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i+1+". " + "C# Egitim Kampi");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 60; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lutfen Ekrana yazilmasini istediginiz adedi giriniz: ");
            //int finisValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisValue; i++)
            //{
            //    Console.WriteLine("Yasasin Cumhuriyet");
            //}
            #endregion

            #region for donugusu ile karar yapilari

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;

            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }


            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }


            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        bacterium *= 2;
            //        Console.WriteLine(i + " Saat Sonunda: " + bacterium);
            //    }


            //}



            #endregion

            #region While Dongusu

            //int i  =1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("MARABA DONGULER");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 3== 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;

            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion

            #region Ornek Sinav Sorusu

            ////Klavyeden girilen 3 basamakli sayinin basamaklari toplamini hesaplayan kodu yaziniz.

            //Console.Write("Sayiyi Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hunderds;
            //int sum;

            //hunderds = number / 100;
            //tens = (number % 100) /10;
            //ones = number % 10;
            //sum = hunderds + tens + ones;

            //Console.WriteLine(hunderds + " - " + tens + " - " + ones);
            //Console.Write(sum);
            #endregion



            Console.Read();
        }
    }
}
