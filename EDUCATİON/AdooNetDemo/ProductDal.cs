using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdooNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true"); // baglantı bilgileri , HANGİ VERİ TABANI
                                                                                                                                          // basına @ koymak komple string düşün demek
                                                                                                                                          // Uzaktaki veritabana baglanmak için
        public List<Product> GetAll()
        {
          
            ConnectionControl();                                                                                                               // integrated security=false;uid=ismail;password=1234

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader(); // tablo sonucu donduruyoz ondan

            List<Product> products = new List<Product>();
            while (reader.Read()) // okuyor veritabanını
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) // baglantı kapalı m ıaçık mı kontrol
            {
                _connection.Open(); // bağlantı aç
            }
        }

        public DataTable GetAll2 ()
        {                                                                                                                       
                                                                                                                                            
            if (_connection.State == ConnectionState.Closed) // baglantı kapalı m ıaçık mı kontrol
            {
                _connection.Open(); // bağlantı aç
            }                                                                                                               // integrated security=false;uid=ismail;password=1234

            SqlCommand command = new SqlCommand("Select * from Products",_connection);

            SqlDataReader reader = command.ExecuteReader(); // tablo sonucu donduruyoz ondan

            DataTable dataTable = new DataTable();

            dataTable.Load(reader); // tabloyu tabandan aldı yükledi

            reader.Close();
            _connection.Close();

            return dataTable;
        }
       
        public void  Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand (
                "Update products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id",_connection);

            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);

            
            command.Parameters.AddWithValue("@id",id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
