using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ADONetSample
{
    class ProductDAL
    {
        // Connection
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ProductDB;integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            else
            {
                Console.WriteLine("Connected!");
            }
        }

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader(); // Tablo Döndürür

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Brand = reader["Brand"].ToString(),
                    Species = reader["Species"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }



        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@Brand,@Species,@Price,@Stock)", _connection);
            command.Parameters.AddWithValue("@Brand", product.Brand);
            command.Parameters.AddWithValue("@Species", product.Species);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Products set Brand=@Brand, Species=@Species, Price=@Price, Stock=@Stock where Id= @Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.Parameters.AddWithValue("@Brand", product.Brand);
            command.Parameters.AddWithValue("@Species", product.Species);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();

            _connection.Close();
        }


        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id= @Id", _connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
