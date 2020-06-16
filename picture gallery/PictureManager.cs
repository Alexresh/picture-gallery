using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace picture_gallery
{
    class PictureManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["picture_gallery"].ConnectionString;
        public void Add(string title, decimal price, int autor, int direct, int genre, int expos, int employee)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "addPicture";
                    command.Parameters.AddWithValue("@name", title);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@autor", autor);
                    if (direct == 0)
                    {
                        command.Parameters.AddWithValue( "@direct", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@direct", direct);
                    }
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@expos", expos);
                    command.Parameters.AddWithValue("@employee", employee);
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
                    command.CommandText = "delPicture";
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
        public void Update(int id, string name, decimal price, int autor, int direct, int genre, int expos, int employee)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "updatePicture";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@autor", autor);
                    if (direct == 0)
                    {
                        command.Parameters.AddWithValue("@direct", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@direct", direct);
                    }
                    command.Parameters.AddWithValue("@genre", genre);
                    if (expos == 0)
                    {
                        command.Parameters.AddWithValue("@expos", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@expos", expos);
                    }
                    command.Parameters.AddWithValue("@employee", employee);
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
        public List<String> getDirections()
        {
            List<String> local = new List<string>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT Название FROM Направление";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                local.Add(reader.GetString(0));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данные по направлениям не получены", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
                return local;
            }
        }
        public object[] getById(int id)
        {
            object[] row = new object[7];
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = $"SELECT Название, Цена, Автор, Направление, Жанр, Выставка, Сотрудник FROM Картина where [Код картины] ={id}";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            for (int i = 0; i < 7; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
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
        public List<String[]> getExpos()
        {
            List<String[]> local = new List<string[]>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT [Код выставки],Дата,[Максимальное количество картин] FROM Выставка";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String[] row = new string[2];
                                var date = reader.GetDateTime(1);
                                row[0] = reader.GetInt32(0).ToString();
                                row[1] = "От: " + date.Day + "."+ date.Month + "."+ date.Year + " Макс. кол. картин:" + reader.GetInt32(2);
                                local.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данные не получены", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
                return local;
            }
        }
        public List<String[]> getAll() 
        {
            List<String[]> local = new List<String[]>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT [Код картины], Название, Автор FROM Pictures";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String[] row = new String[2];
                                row[0] = reader.GetInt32(0).ToString();
                                row[1] = "Название: "+reader.GetString(1) + " Автор: " + reader.GetString(2);
                                local.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данные не получены", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                }
                dbConnection.Close();
                return local;
            }
        }
    }
}
