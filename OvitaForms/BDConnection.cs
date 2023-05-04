using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OvitaForms
{
    public class BDConnection
    {
        //private string server;
        //private string database;
        //private string username;
        //private string password;
        //private bool trusted;
        //SqlConnection connection;

        //public BDConnection(string server, string database, string username, string password,  bool trusted)
        //{
        //    string connectionString = (trusted) ? $"Server={server};Database={database};Trusted_Connection={trusted};" :
        //        $"Server={server};Database={database};User Id={username};Password={password};";
        //    this.connection = new SqlConnection(connectionString);
        //}

        public void Delete(string table, int id)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE id={id}", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int FindTableCount(string tableName)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {tableName}", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader.GetValue(0);
                }
                else { return 0; }
                connection.Close();
            }
        }
        public Product? GetProductById(int stringId)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE id = '{stringId}'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    Bitmap image = ImageToBitmap((byte[])reader.GetValue(1));
                    string type = (string)reader.GetValue(2);
                    string maker = (string)reader.GetValue(3);
                    string model = (string)reader.GetValue(4);
                    string description = (string)reader.GetValue(5);
                    int saler_id = (int)reader.GetValue(6);
                    int category_id = (int)reader.GetValue(7);
                    decimal price = (decimal)reader.GetValue(8);
                    int location_id = (int)reader.GetValue(9);
                    int discontinued = (int)reader.GetValue(10);
                    return new Product(id, image, type, maker, model, description, saler_id, category_id, price, location_id, discontinued);
                }
                else
                {
                    return null;
                }
                connection.Close();
            }
        }
        public List<Product> SelectAllProducts()
        {
            List<Product> products = new List<Product>();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Products;", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    Bitmap image = ImageToBitmap((byte[])reader.GetValue(1));
                    string type = (string)reader.GetValue(2);
                    string maker = (string)reader.GetValue(3);
                    string model = (string)reader.GetValue(4);
                    string description = (string)reader.GetValue(5);
                    int saler_id = (int)reader.GetValue(6);
                    int category_id = (int)reader.GetValue(7);
                    decimal price = (decimal)reader.GetValue(8);
                    int location_id = (int)reader.GetValue(9);
                    int discontinued = (int)reader.GetValue(10);
                    products.Add( new Product(id, image, type, maker, model, description, saler_id, category_id, price, location_id, discontinued));
                }
            }
            return products;
        }
        //public List<Product> GetSimilarProducts(string column, string atribute)
        //{
        //    List<Product> products = new List<Product>();
        //    string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE {column} = {atribute}", connection);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = (int)reader.GetValue(0);
        //            Bitmap image = ImageToBitmap((byte[])reader.GetValue(1));
        //            string type = (string)reader.GetValue(2);
        //            string maker = (string)reader.GetValue(3);
        //            string model = (string)reader.GetValue(4);
        //            string description = (string)reader.GetValue(5);
        //            int saler_id = (int)reader.GetValue(6);
        //            int category_id = (int)reader.GetValue(7);
        //            decimal price = (decimal)reader.GetValue(8);
        //            int location_id = (int)reader.GetValue(9);
        //            int discontinued = (int)reader.GetValue(10);
        //            products.Add(new Product(id, image, type, maker, model, description, saler_id, category_id, price, location_id, discontinued));
        //        }
        //        connection.Close();
        //    }
        //    return products;
        //}
        public bool DoesExistItem(string collumn, string item)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE {collumn} = \'{item}\'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    return true;
                connection.Close();
            }
            return false;
        }

        public bool IsPasswordCorrect(string email, string password)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT pswrd FROM Users WHERE email = \'{email}\'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    if ((string)reader.GetValue(0) == password)
                        return true;
                connection.Close();
            }
            return false;
        }
        //
        public Account InsertUser(string lastName, string firstName, string phone, string email, string password)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Users (last_name, first_name, phone, email, pswrd) VALUES (N\'{lastName}\', N\'{firstName}\', \'{phone}\', \'{email}\', \'{password}\')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return new Account(GetUserId("email", email), GetImage(GetUserId("email", email)), lastName, firstName, phone, email, password);
        }
        
        public Account GetUser(int Id)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE id = \'{Id}\'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string lastName = (string)reader.GetValue(2);
                    string firstName = (string)reader.GetValue(3);
                    string phone = (string)reader.GetValue(4);
                    string email = (string)reader.GetValue(5);
                    string password = (string)reader.GetValue(6);
                    return new Account(id, GetImage(id), lastName, firstName, phone, email, password);
                }
            }
            return null;
        }
        public int GetUserId(string collumn, string key)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmdCountResult = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE {collumn} = \'{key}\'", connection);
                SqlDataReader readerCountResults = cmdCountResult.ExecuteReader();
                if (readerCountResults.Read())
                {
                    if ((int)readerCountResults.GetValue(0) != 1)
                    {
                        return 0;
                    }
                    else
                    {
                        readerCountResults.Close();
                        SqlCommand cmd = new SqlCommand($"SELECT id FROM Users WHERE {collumn} = \'{key}\'", connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return (int)reader.GetValue(0);
                        }
                    }
                }
                connection.Close();
            }
            return 0;
        }
        public string GetUserStringItem(string collumn, int userId)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT {collumn} FROM Users WHERE id = \'{userId}\'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (string)reader.GetValue(0);
                }
            }
            return "";
        }
        public int GetUserIntItem(string collumn, int userId)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT {collumn} FROM Users WHERE id = \'{userId}\'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader.GetValue(0);
                }
            }
            return 0;
        }

        public Bitmap ImageToBitmap(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return new Bitmap(ms);
            }
        }

        public static byte[] ImageToByte(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        // Работа с image
        public Bitmap GetImage(int Id)
        {
            Bitmap bitmap;
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT image FROM Users WHERE id = \'{Id}\' AND [image] IS NOT NULL;", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        byte[] image = (byte[])reader.GetValue(0);
                        using (var ms = new MemoryStream(image))
                        {
                            bitmap = new Bitmap(ms);
                            return bitmap;
                        }
                    }
                }
                connection.Close();
            }
            return new Bitmap("C:\\Users\\domit\\source\\repos\\OvitaForms\\OvitaForms\\DefaultImages\\no_account_photo.jpg");
        }

        //public void UpdateImage(Bitmap image, int Id)
        //{
        //    string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("UPDATE Users SET [image]=@image WHERE id=@Id AND [image] IS NOT NULL", connection);
        //        cmd.Parameters.AddWithValue("@image", ImageToByte(image));
        //        cmd.Parameters.AddWithValue("@Id", Id);
        //        //cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //}
        public void UpdateUserImage(string fileName, int Id)
        {
            //SqlConnection.ClearAllPools();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Users SET [image]=(SELECT * FROM OPENROWSET(BULK N\'{fileName}\', Single_Blob) AS img{Id}) WHERE id={Id}", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int SelectMaxInt(string table, string column)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT MAX({column}) FROM {table};", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return (int)reader.GetValue(0);
                connection.Close();
            }
            return 0;
        }
        public void InsertImage(string table, string fileName, int Id)
        {
            SqlConnection.ClearAllPools();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO {table} (image) VALUES ((SELECT * FROM OPENROWSET(BULK N\'{fileName}\', Single_Blob) AS img{FindTableCount("Products")}))", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdateAtribute(string table, int id,  string column, string atribute)
        {
            List<Product> products = new List<Product>();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE {table} SET {column}=N\'{atribute}\' WHERE id={id}", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public string GetAtribute(string table, int id, string column)
        {
            string output = "";
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT {column} FROM  {table} WHERE id={id}", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    output = reader.GetString(0);
                }
                connection.Close();
            }
            return output;
        }
        public List<Product> SelectSimilarProducts(string column, string atribute)
        {
            List<Product> products = new List<Product>();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE {column} = {atribute}", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    Bitmap image = ImageToBitmap((byte[])reader.GetValue(1));
                    string type = (string)reader.GetValue(2);
                    string maker = (string)reader.GetValue(3);
                    string model = (string)reader.GetValue(4);
                    string description = (string)reader.GetValue(5);
                    int saler_id = (int)reader.GetValue(6);
                    int category_id = (int)reader.GetValue(7);
                    decimal price = (decimal)reader.GetValue(8);
                    int location_id = (int)reader.GetValue(9);
                    int discontinued = (int)reader.GetValue(10);
                    products.Add(new Product(id, image, type, maker, model, description, saler_id, category_id, price, location_id, discontinued));
                }
                connection.Close();
            }
            return products;
        }

        public bool CheckSimilarLocations(string city, string region, string country)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Location WHERE city=\'{city}\' AND region=\'{region}\' AND country=\'{country}\';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                connection.Close();
            }
            return false;
        }

        public int InsertLocation(string city, string region, string country)
        {
            if (!CheckSimilarLocations(city, region, country))
            {
                string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Location (city, region, country) VALUES (N\'{city}\', N\'{region}\', N\'{country}\');", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return GetLocationId(city, region, country);
            }
            else
            {
                return GetLocationId(city, region, country);
            }
        }

        public int GetLocationId(string city, string region, string country)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT id FROM Location WHERE city=\'{city}\' AND region=\'{region}\' AND country=\'{country}\';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                        return (int)reader.GetValue(0);
                }
                connection.Close();
            }
            return 0;
        }

        public void InsertProduct(string fileName, string type, string maker, string model, string description, int account_id, int category_id, decimal price, int location_id, int discontinued)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ovita;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"INSERT Products VALUES ((SELECT * FROM OPENROWSET(BULK N\'{fileName}\', Single_Blob) AS img{FindTableCount("Products") + 1}), N\'{type}\', N\'{maker}\', N\'{model}\', N\'{description}\', {account_id}, {category_id}, {price}, {location_id}, {discontinued});", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}