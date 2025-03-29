using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _201___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar


            //() metot olmasi icin bir parantez ile acilip kapanmasi gerekiyor main,Console.WriteLine vb.
            //() mor kup
            //       Geriye Deger Dondurmeyen Metotlar
            //Customer ---> Listele, ekle, sisl ,guncelle
            //Void

            //void CustomerList()
            //{

            //    Console.WriteLine("Ali Yildiz");
            //    Console.WriteLine("Numan Yildiz");
            //    Console.WriteLine("Mehmet Yildiz");
            //    Console.WriteLine("Davut Yildiz");


            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Metotlar

            //void Print(string customerName,string customerSurname)
            //{
            //    Console.WriteLine(customerName);
            //    Console.WriteLine(customerSurname);
            //}

            //string name = "mehmet";
            //string surname = "icyar";

            //Print(name, surname);



            #endregion

            #region Geriye Deger Dondurmeyen Int Parametreli Metotlar

            //void Sum(int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine(result);
            //}

            //Sum(3,4);


            #endregion

            #region Geriye Deger Donduren Metotlar


            //string CustomerName()
            //{

            //    return "Buse Yildiz";
            //}

            //string Name = CustomerName();

            //Console.WriteLine(Name);


            //string CustomerName()
            //{
            //    string name = "Numan";
            //    string surname = "Kotan";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(CustomerName());
            #endregion

            #region Geriye Deger Donduren String Parametreli Metotlar
            //string x, y, z;
            //string CountryCard( string countryName, string capital , string flagColor )
            //{
            //    string cardInfo = " Ulke Adi: " + countryName + " Ulke Baskenti: " + capital + " Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //Console.Write("Ulke Adini Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Baskenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

           

            int ExamResault(string student, int exam1, int exam2)
            {
                int resault = (exam1 + exam2) / 2;
                if (resault <= 50)
                {
                    Console.WriteLine($"{student} isimli ogrenci Sinavdan Kalmistir.");

                }
                else
                {
                    Console.WriteLine($"{student} isimli ogrenci Sinavdan Gecmistir.");

                }
                return resault;
            }

            string studentName;
            int x, y;
            Console.Write("Ogrencinin Adini Giriniz: ");
            studentName = Console.ReadLine();

            Console.Write("Ogrencinin 1. Sinav Notunu Giriniz: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ogrencinin 2. Sinav Notunu Giriniz: ");
            y = int.Parse(Console.ReadLine());

            ExamResault(studentName, x, y);

            Console.Read();
        }
    }
}
