using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Hafta___Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri
            // DegiskenTuru [] DiziAdi = new DegiskenTuru [ElemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "kirmizi";
            //colors[1] = "sari";
            //colors[2] = "mavi";
            //colors[3] = "turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Uskup";

            //Console.WriteLine(cities[4]);

            // TANIMLI BIR DIZI ELEMANINA ATAMA YAPMAYIP YAZDIRIRSAK O ELEMANIN DEFAULT DEGERI 0'DIR.

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 37;
            //numbers[2] = 786;
            //numbers[3] = 12;
            //numbers[7] = 74;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "atina", };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tum Elemanlari Listeleme

            //string[] colors = { "Sari", "kirmizi", "beyaz", "mavi", "turuncu", "mor" };

            //for(int i = 0; i < colors.Length ; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 45, 20, 12, 233, 902, 631, 32 ,433 ,786 ,324 ,7852};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', '/', '*' };

            //for (int i = 0; i < symbols.Length; i++)
            //{

            //        Console.WriteLine(symbols[i]);

            //}

            //int[] myArray = { 1, 23, 3, 42, 5, 62, 75, 8, 91, 120, 131, 12, 132, 14 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber); 

            //string[] persons = { "ali", "numan", "sena", "buse", "emin", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 20, 12, 233, 902, 631 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 20, 12, 233, 902, 631 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlari

            //dizi.Lenght dizinin uzunlugunu dondurur.

            //dizi.Sort diziyi siralar (kucukten buyuge)

            //Array.Sort(dizi);
            //Array.Reverse diziyi tersten siralar 

            //Array.IndexOf(persons, "sena");
            //string[] persons = { "ali", "numan", "sena", "zehra" };
            //int index = Array.IndexOf(persons, "sena");
            //Console.WriteLine(index);

            //Array.Max();
            //Array.Min();
            //int[] numbers = { 45, 20, 12, 233, 902, 631, 32, 433, 786, 324, 7852 };
            //Console.WriteLine("Dizinin en buyuk elemani: " + numbers.Max() + " Dizinin en kucuk elemani: " + numbers.Min());
            

            //
            #endregion

            #region Kullanicidan Deger Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lutfen {i + 1}. Sehri Giriniz: ");
            //    cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lutfen Toplanacak {i+1}. elemani giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //    sum += numbers[i];

            //}
            //Console.Write($"Girdiginiz Degerlerin Toplami: {sum}");


            //int[] numbers = { 12, 23, 20, 239, 10, 3, 5 };

            //int[] tek = new int[numbers.Length];
            //int[] cift = new int[numbers.Length];

            //int tekIndex = 0, ciftIndex = 0;  // **Dizilere doğru şekilde ekleme yapmak için sayaç**

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        cift[ciftIndex] = numbers[i]; // **Çift sayıları cift dizisine ekle**
            //        ciftIndex++;
            //    }
            //    else
            //    {
            //        tek[tekIndex] = numbers[i]; // **Tek sayıları tek dizisine ekle**
            //        tekIndex++;
            //    }
            //}

            //Console.Write("Tek sayılar: ");
            //for (int k = 0; k < tekIndex; k++)
            //{
            //    Console.Write($"{tek[k]} ");
            //}

            //Console.WriteLine(); // Yeni satıra geç

            //Console.Write("Çift sayılar: ");
            //for (int j = 0; j < ciftIndex; j++)
            //{
            //    Console.Write($"{cift[j]} ");
            //}

            #endregion

            Console.Read();
        } 

    } 

} 
