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

            //string customerName, customerSurname;
            //customerName = "Numan Taha";
            //customerSurname = "Kotan";
            //Console.WriteLine(customerName + " " + customerSurname);
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
            
            int hamburgerCount =3;
            int cokeCount =3;   
            int waterCount =3;
            int friceCount =1;
            int pizzaCount =0;
            int lemonCount =0;

            int totalPrice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friceCount * fricePrice + pizzaCount * pizzaPrice + lemonCount * lemonadePrice;

            Console.WriteLine("--- Toplam Tutar: " + totalPrice);

            #endregion

            Console.Read();
        }
    }
}
