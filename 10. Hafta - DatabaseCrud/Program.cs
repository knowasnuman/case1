using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hafta___DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud -> Create - Read - Update - Delete
            Console.WriteLine("***** Menu Siparis Islem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");

            #region Kategori Ekleme

            //Console.Write(" Eklemek Istediginiz Kategori Adi: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //Kossuluz Sorguyu Calistir.
            //connection.Close();

            //Console.Write("Kategory Basariyla Eklendi");
            #endregion

            #region Urun Ekleme



            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Urun Adi: ");
            //productName = Console.ReadLine();
            //Console.Write("Urun Fiyati: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();  
            //SqlCommand command = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();  //Degisiklikleri kabul et ve veritabanina ekle.
            //connection.Close();
            //Console.Write("Urun Eklemesi Basarili");



            #endregion

            #region Urun Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();  

            //SqlCommand command = new SqlCommand("Select * From Tbl_Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) // satirin icine girdi Tbl_Product icine girdi
            //{ 
            //    foreach (var item in row.ItemArray) //  bir foreach kullanarak satirin icindeki satira da girmek istiyoruz Tbl_product icindeki id productname gibi satirlari okucak
            //    {
            //        Console.Write(item.ToString() + " 5 "); // boylece tum tablo icerigini sirayla gezip ekrana yazdirmis olduk.

            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();


            #endregion

            #region Urun Silme

            //Console.Write("Silincecek Urun Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command =new SqlCommand ("Delete From Tbl_Product Where ProductId=@productId", connection) ;
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme Islemi Yapildi.");

            #endregion

            #region Urun Guncelleme

            Console.Write("Guncellemek Istediginiz Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Guncellemek Istediginiz Urun Ismi: ");
            string productName = Console.ReadLine();
            Console.Write("Guncellemek Istediginiz Urun Fiyati: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
           
            


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();  

            connection.Close();

            Console.WriteLine("Guncelleme Basarili");
            #endregion



            Console.Read();
        }
    }
}
