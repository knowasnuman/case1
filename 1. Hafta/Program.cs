using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.Write("Maraba Dunya"); Write yazdirir
            //Console.WriteLine("selam");  WriteLine Yazdirip Alt Satira Indirir.

            //Console.WriteLine(" ***** Yemek Kategori Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("- Corbalar");
            //Console.WriteLine("- Ana Yemekler");
            //Console.WriteLine("- Soguk Baslangiclar");
            //Console.WriteLine("- Salatalar");
            //Console.WriteLine("- Icecekler");
            //Console.WriteLine("- Tatlilar");
            //Console.WriteLine();
            //Console.WriteLine(" ***** Yemek Kategori Kategorileri *****");
            #endregion

            #region stringDegiskenler

            //string name;
            //name = "Numan";
            //Console.WriteLine(name);

            //string customerName, customerSurname ,customerPhone, customerEmail, district, city;
            //customerName = "Numan Taha";
            //customerSurname = "Kotan";
            //customerPhone = "+90 543 533 23 23";
            //customerEmail = "deneme@gmail.com";
            //district = "Palandoken";
            //city = "Erzurum";
            //Console.WriteLine("*** Rezervasyon Karti ***");
            //Console.WriteLine();
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: "+customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres : "+ district + "/" + city);
            //Console.WriteLine("-----------------------------------------");


            //customerName = "Ali ";
            //customerSurname = "Gomleksiz";
            //customerPhone = "+90 543 253 53 23";
            //customerEmail = "deneme11@gmail.com";
            //district = "Senkaya";
            //city = "Erzurum";
            
            //Console.WriteLine();
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");
            #endregion

            #region intDegiskenler

            //int customerAge = 22;
            //Console.WriteLine(customerAge);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("\t **** Restoran Menu Fiyati ****");
            Console.WriteLine();
            Console.WriteLine(" ------ Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine(" ------ Cola: " + cokePrice + " TL");
            Console.WriteLine(" ------ Su: " + waterPrice + " TL");
            Console.WriteLine(" ------ Patates Kizartmasi: " + fricePrice + " TL");
            Console.WriteLine(" ------ Pizza: " + pizzaPrice + " TL");
            Console.WriteLine(" ------ Limonata: " + lemonadePrice + " TL");

            Console.WriteLine();
            Console.WriteLine("*******************************************");


            int totalhamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfricePrice;
            int totalpizzaPrice;
            int totallemonadePrice;

            int hamburgerCount =3;
            int cokeCount =3;   
            int waterCount =3;
            int friceCount =1;
            int pizzaCount =0;
            int lemonCount =0;
            
            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfricePrice = friceCount * fricePrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonCount * lemonadePrice;

            int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfricePrice + totalpizzaPrice + totallemonadePrice;

            Console.WriteLine("--- Hamburger Tutar: " + totalhamburgerPrice);
            Console.WriteLine("--- Kola Tutar: " + totalcokePrice);
            Console.WriteLine("--- Su Tutar: " + totalwaterPrice);
            Console.WriteLine("--- Patates Kizartmasi Tutar: " + totalfricePrice);
            Console.WriteLine("--- Pizza Tutar: " + totalpizzaPrice);
            Console.WriteLine("--- Limonata Tutar: " + totallemonadePrice);
            Console.WriteLine("*******************************************");
            Console.WriteLine("--- Toplam Tutar: " + totalPrice);

            #endregion

            Console.Read();
        }
    }
}
