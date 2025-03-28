using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Hafta_Veriablees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 1.4;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Litesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberyPrice, potato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberyPrice = 45;
            //potato = 9.74;
            //Console.WriteLine("Elma Birim Fiyati: " + applePrice);
            //Console.WriteLine("Portakal Birim Fiyati: " + orangePrice);
            //Console.WriteLine("Cilek Birim Fiyati: " + strawberyPrice);
            //Console.WriteLine("Patates Birim Fiyati: " + potato);

            //double appleGram, orangeGram, strawberyGram, potatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberyGram = 0.750;
            //potatoGram = 4.859;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberyTotalPrice = strawberyPrice * strawberyGram;
            //double potatoTotalPrice = potato * potatoGram;


            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Alinan Urun: Elma " + " - Birim Fiyati: "+ applePrice + " - Gramaj: " + appleGram +   " - Elma tutari: " +  appleTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Portakal " + " - Birim Fiyati: " + orangePrice + " - Gramaj: " + orangeGram + " - Elma tutari: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Elma " + " - Birim Fiyati: " + strawberyPrice + " - Gramaj: " + strawberyGram + " - Elma tutari: " + strawberyTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Elma " + " - Birim Fiyati: " + potato + " - Gramaj: " + potatoGram + " - Elma tutari: " + potatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberyTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alisveris Toplam Tutar: " + shoppingTotalPrice+ " TL");
            #endregion

            #region Char Degiskenler

            //ABCDEFGH
            //DEFGHJKL
            //SEZAR SIFRELEMESI KENDINDEN 3 SONRAKI HARFLE DEGIS

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("**** CSharp Hava Yollari Hava Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentifyNumber;
            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Gidilecek Sehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Gidilecek Ilce: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yasi: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarasi: ");
            //passengerIdentifyNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Yolcu Adi: " + passengerName + " " + "Gidilecek Sehir: " + passengerCity + " " + "Gidilecek Ilce: " + passengerDistrict + " " + "Yolcu Yasi: " +
            //    passengerAge+" " + "Yolcu Kimlik Numarasi: " + passengerIdentifyNumber);
            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler


            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen Aldiginiz Ayakkabi Sayisini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen Aldiginiz Bilgisayar Sayisini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen Aldiginiz Sandalye Sayisini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen Aldiginiz Televizyon Sayisini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine("Alisveris Toplam Tutari : " + totalPrice);
            #endregion
            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lutfen 1. Sinav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lutfen 2. Sinav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lutfen 3. Sinav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+ exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamaniz: " + result);
            #endregion
            #region Klavyeden Karakter Girisleri

            char gender;

            Console.Write("Lutfen Cinsiyet Seciniz: ");
            gender = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Sectiginiz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
