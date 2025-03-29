using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3___IF_ELSE__Switch_Case.Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lutfen sifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");
            //}

            //string capital, country;
            //Console.Write("Baskenti Giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ulkeyi Giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.Write("Veriler Dogrulandi.");

            //}
            //else
            //{
            //    Console.Write("Hatali Bilgi.");
            //}

            //int number;
            //Console.Write("Sayiyi Giriniz: ");
            //number = int.Parse(Console.ReadLine());  


            //double exam1, exam2, ort;
            //Console.Write("1. Sinav Notunu Giriniz :");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sinav Notunu Giriniz :");
            //exam2 = double.Parse(Console.ReadLine());

            //ort = (exam1 + exam2) / 2;

            //if (ort <= 50)
            //{
            //    Console.WriteLine("Kaldi");
            //}
            //else if (ort <= 70)
            //{
            //    Console.WriteLine("Vasatin Ustu");
            //}
            //else if (ort > 70 & ort <= 100)
            //{
            //    Console.WriteLine("Kral ");
            //}
            //else
            //{
            //    Console.WriteLine("Bir Ogrenci 100 den fazla not alamaz.");
            //}

            //string city;
            //Console.Write("Lutfen Sehir Girisi Yapiniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "erzurum")
            //{
            //    Console.WriteLine("Sehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir Mevcut Degil");
            //}

            //string username;
            //Console.Write("Lutfen kullanici adini giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin" )
            //{
            //    Console.WriteLine("Bu Kullanici Adi Kabul Edilemez ");
            //}
            //else
            //{
            //    Console.WriteLine("Hosgeldiniz");
            //}


            #endregion

            #region Mod Alma Islemleri


            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lutfen 1. Sayiyi Giriniz : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen 2. Sayiyi Giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 %number2;
            //Console.WriteLine("1. Sayinin 2. Sayiya bolumunden kalan : "+ result);

            //Console.Write("Lutfen Sayiyi Giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write(" Sayi Ciftir ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Tektir");
            //}

            //char team;
            //Console.Write("Lutfen Takim Sembolu Giriniz : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write(" Galatasaray ");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine(" Fenerbahce ");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine(" Besiktas ");
            //}




            #endregion

            #region Ornek Proje Uygulamasi

            
            //Console.WriteLine("****** C# Egitim Kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Corbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- Icecekler");
            //Console.WriteLine("5- Tatlilar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayini gormek istediginiz menu secin: ");
            //menuItem = Console.ReadLine();  

            //if (menuItem == "1" )
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kori Soslu Tavuk");
            //    Console.WriteLine("2- Kizartma Tabagi");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Firinda Somon");
            //    Console.WriteLine("5- Patlican Musakka");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Corbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Corbasi");
            //    Console.WriteLine("2- Ezogelin Corbasi");
            //    Console.WriteLine("--------------Corbalar--------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita Pizza");
            //    Console.WriteLine("--------------Pizzalar--------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Icecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("4- Meyve Suyu");
            //    Console.WriteLine("--------------Icecekler--------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlilar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kadayif Dolmasi");
            //    Console.WriteLine("2- Sutlac");
            //    Console.WriteLine("2- Kunefe");
            //    Console.WriteLine("2- Dondurma");
            //    Console.WriteLine("--------------Tatlilar--------------");
            //}

            #endregion

            #region Switch Case
            //int mounthNumber;
            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //mounthNumber = int.Parse(Console.ReadLine());
            
            //switch(mounthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //            break;
            //    case 2:
            //        Console.Write("Subat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayis");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Agustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylul");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasim");
            //        break;
            //    case 12:
            //        Console.Write("Aralik");
            //        break;
            //    default:
            //        Console.Write("Oyle Bir Ay Yok ");
            //        break;

            //}

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayiyi Giriniz:");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayiyi Giriniz:");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Yapmak istediginiz islem sembolunu giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Yanlis islem sembolu " );
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
