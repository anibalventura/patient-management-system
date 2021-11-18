using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database.Model;

namespace Database.Repository
{
    public class UserTypeRepository : Database.BaseRepository
    {
        public UserTypeRepository(SqlConnection connection) : base(connection) { }

        public List<UserType> GetList()
        {
            try
            {
                GetConnection().Open();

                string sqlQuery = "select Id,Name from UserType";
                SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

                SqlDataReader reader = command.ExecuteReader();

                List<UserType> list = new List<UserType>();
                while (reader.Read())
                {
                    list.Add(new UserType
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? "" : reader.GetString(1)
                    });
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                return list;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
