using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_gallery
{
    class PurchaseManager 
    {
        string connectionString = ConfigurationManager.ConnectionStrings["picture_gallery"].ConnectionString;
        public  void Add(DateTime date, int employee, int buyer, int picture) 
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "addPurchase";
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@employee", employee);
                    command.Parameters.AddWithValue("@buyer", buyer);
                    command.Parameters.AddWithValue("@picture", picture);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешно", "Информация", MessageBoxButtons.OK);
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK);
                    }
                }
                dbConnection.Close();
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "delPurchase";
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешно", "Информация", MessageBoxButtons.OK);
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK);
                    }
                }
                dbConnection.Close();
            }
        }
        public void Update(int id, DateTime date, int employee, int buyer, int pic) 
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "updatePurchase";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@employee", employee);
                    command.Parameters.AddWithValue("@buyer", buyer);
                    command.Parameters.AddWithValue("@picture", pic);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешно", "Информация", MessageBoxButtons.OK);
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK);
                    }
                }
                dbConnection.Close();
            }
        }
        public List<String[]> getNonPurchasePictures() 
        {
            List<String[]> local = new List<string[]>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT [Код картины],Название, Автор FROM nonPurchasePictures";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String[] row = new string[2];
                                row[0] = reader.GetInt32(0).ToString();
                                row[1] = "Название: "+reader.GetString(1)+" от автора: " + reader.GetString(2);
                                local.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данных нет", "Информация", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
                return local;
            }
        }
        public List<String[]> getPurchases()
        {
            List<String[]> local = new List<string[]>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT [Код покупки],Дата, Картина,[Общая цена] FROM purchased_paintings";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String[] row = new string[2];
                                row[0] = reader.GetInt32(0).ToString();
                                var date = reader.GetDateTime(1);
                                row[1] = "Дата: " + date.Year+"."+date.Month+"."+date.Day + " Название: " + reader.GetString(2)+" Цена: "+reader.GetDecimal(3);
                                local.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данных нет", "Информация", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
                return local;
            }
        }
        public object[] getById(int id)
        {
            object[] row = new object[4];
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = $"SELECT Дата, Сотрудник, Покупатель, Картина FROM Покупки where [Код покупки] ={id}";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            row[0] = reader.GetDateTime(0);
                            row[1] = reader.GetInt32(1);
                            row[2] = reader.GetInt32(2);
                            row[3] = reader.GetInt32(3);
                        }
                        else
                        {
                            MessageBox.Show("Данные не получены", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
            }
            return row;
        }
    }
}
