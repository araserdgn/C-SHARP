using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
   public class ProductDal
    {
                                                    // @ koyduk ki ne yazarsan yaz string görsn diye \ için
        SqlConnection _connection = new SqlConnection(@"Server= (localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        // globalde tanımladık cnk çok kullanıcaz
        public List<Product> GetAll()
        {
            ConnectionControl(); // Metot yaptık, baglantı kontrolu için

            SqlCommand command = new SqlCommand("Select * from Products", _connection); // SQL komutudur içindeki string
                                                                                       // ETrade tabanda -> New Query de oraya yaz direkt tabloyu bastırır
            SqlDataReader reader = command.ExecuteReader(); // Okuyor veri tabandan

            List<Product> products = new List<Product>();

            while (reader.Read()) // SqlData dakileri sırayla oku demek
            {
                Product product = new Product
                { // veri tabanındakileri içine ekledik
                    ID = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]), // string olan şeyi integer'e cevirdk
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                }; // liste oluştu ama kullanmadık

                products.Add(product); // şimdi ekledik


            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public DataTable GetAll2()
        {                                               // @ koyduk ki ne yazarsan yaz string görsn diye \ için                
            SqlConnection connection = new SqlConnection(@"Server= (localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection); // SQL komutudur içindeki string
                                                                                       // ETrade tabanda -> New Query de oraya yaz direkt tabloyu bastırır
            SqlDataReader reader = command.ExecuteReader();

            DataTable DataTable = new DataTable();
            DataTable.Load(reader);
            reader.Close();
            connection.Close();
            return DataTable;
        } // DataTable pahalı bir komuttur, az kullanılır

        public void Add (Product product) //
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name", product.Name); // // yazan yerdeki nameyi alıp ^ nın namesine yazyo
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
           // command.EndExecuteNonQuery();

            _connection.Close();
        }
    }
}
