using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hafta___DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net Sql Sorgularini C# ile kullanmamizi saglayan cerceve

            Console.WriteLine("***** C# Veri Tabanli Urun-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;


            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urunler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Cikis Yap");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Lutfen getirmek istediginiz tablo numarasini giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RPNH06L\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command); // C# tarafinda olusturulan sorguyla veritabani arasinda bir kopru gorevi gorur.

            DataTable dataTable = new DataTable(); // verileri ram'a almamizi saglayacak.
            adapter.Fill(dataTable); 

            connection.Close();
            // var tum degisken turlerini uzerine alan bir degisken. Bunu kullandik cunku databasemizde birden fazla cesitte degisken var
            foreach (DataRow row in dataTable.Rows) // dataTable icerisinden satirlari itema ata.
            {
                foreach (var item in row.ItemArray) // row dan gelen satirlari iteme ata.
                {
                    Console.Write( $" - {item.ToString()}" );
                }
                Console.WriteLine();
            } 

            Console.Read();
        }
    }
}
