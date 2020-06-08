using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace picture_gallery
{
    class ExposManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["picture_gallery"].ConnectionString;
        public void Add(DateTime date, int direction, int maxPic)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "addExpos";
                    command.Parameters.Add(NewParameter(command, "@date", date, DbType.Date));
                    if (direction == 0)
                    {
                        command.Parameters.Add(NewParameter(command, "@direction", null, DbType.Int32));
                    }
                    else
                    {
                        command.Parameters.Add(NewParameter(command, "@direction", direction, DbType.Int32));
                    }
                    command.Parameters.Add(NewParameter(command, "@maxPic", maxPic, DbType.Int32));
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
        private SqlParameter NewParameter(SqlCommand com, string paramName, object value, DbType type)
        {
            var inputParam = com.CreateParameter();
            inputParam.ParameterName = paramName;
            if (value == null)
            {
                inputParam.Value = DBNull.Value;
            }
            else
            {
                inputParam.Value = value;
            }
            inputParam.Direction = ParameterDirection.Input;
            inputParam.DbType = type;
            return inputParam;
        }
        public void Delete(int id)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "delExpos";
                    command.Parameters.Add(NewParameter(command, "@id", id, DbType.Int32));
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
        public void Update(int id, DateTime date,int dir,int maxPic)
        {
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "updateExpos";
                    command.Parameters.Add(NewParameter(command, "@id", id, DbType.Int32));
                    command.Parameters.Add(NewParameter(command, "@date", date, DbType.Date));
                    if (dir == 0)
                    {
                        command.Parameters.Add(NewParameter(command, "@direction", null, DbType.Int32));
                    }
                    else 
                    {
                        command.Parameters.Add(NewParameter(command, "@direction", dir, DbType.Int32));
                    }
                    command.Parameters.Add(NewParameter(command, "@maxPic", maxPic, DbType.Int32));
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
        public object[] getById(int id)
        {
            object[] row = new object[3];
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = $"SELECT Дата, Направление, [Максимальное количество картин] FROM Выставка where [Код выставки] ={id}";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            row[0] = reader.GetDateTime(0);
                            if (!reader.IsDBNull(1)) 
                            { 
                                row[1] = reader.GetInt32(1); 
                            }
                            row[2] = reader.GetInt32(2);
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
        public List<String> GetDir()
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
        public List<String[]> GetAll()
        {
            List<String[]> local = new List<String[]>();
            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using (var command = dbConnection.CreateCommand())
                {
                    command.CommandText = "SELECT [Код выставки], Дата, Направление, [Максимальное количество картин] FROM exposView";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                String[] row = new String[2];
                                row[0] = reader.GetInt32(0).ToString();
                                DateTime dateTime = reader.GetDateTime(1);
                                row[1] = "Дата: " + dateTime.Day + "." + dateTime.Month + "." + dateTime.Year.ToString();
                                row[1] += ", Макс. кол. картин: " + reader.GetInt32(3);
                                row[1] += ", Направление: ";
                                if (!reader.IsDBNull(2))
                                {
                                    row[1] += reader.GetString(2) + " ";
                                }
                                else
                                {
                                    row[1] += "Без направления ";
                                }
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
