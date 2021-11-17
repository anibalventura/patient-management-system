using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class BaseRepository
    {
        private readonly SqlConnection _connection;

        public BaseRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();
                query.ExecuteNonQuery();
                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();
                _connection.Open();
                query.Fill(data);
                _connection.Close();


                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}