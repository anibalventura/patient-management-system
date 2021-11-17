using System;
using System.Data;
using System.Data.SqlClient;
using Database.Model;

namespace Database.Repository
{
    public class UserRepository : Database.BaseRepository, IRepository<User>
    {
        public UserRepository(SqlConnection connection) : base(connection) { }

        public bool Add(User user)
        {
            SqlCommand command = new SqlCommand("insert into Users(Name,LastName,Email,Username,Password,IdUserType) values(@name,@lastname,@email,@username,@password,@idusertype)", GetConnection());

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@idusertype", user.IdUserType);

            return ExecuteDml(command);
        }

        public bool Edit(User user)
        {
            SqlCommand command = new SqlCommand("update Users set Name=@name,LastName=@lastname,Email=@email,Username=@username,Password=@password,IdUserType=@idusertype where Id = @id", GetConnection());

            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@lastname", user.LastName);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@idusertype", user.IdUserType);
            command.Parameters.AddWithValue("@id", user.Id);

            return ExecuteDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Users where Id = @id", GetConnection());

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public User GetById(int id)
        {
            try
            {
                GetConnection().Open();

                SqlCommand command = new SqlCommand("select u.Id,u.Name,u.LastName,u.Email,u.Username,u.Password,ut.Name from Users u inner join UserType ut on u.IdUserType = ut.Id where u.Id = @id", GetConnection());

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                User data = new User();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Username = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Password = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.UserType = reader.IsDBNull(6) ? "" : reader.GetString(6);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select u.Id as 'Code',u.Name as 'Name',u.LastName as 'Last name',u.Email,u.Username, ut.Name as 'User type' from Users u inner join UserType ut on u.IdUserType = ut.Id", GetConnection());
            return LoadData(query);
        }

        public bool CheckUsername(string username)
        {
            try
            {
                GetConnection().Open();

                SqlCommand command = new SqlCommand("select u.Username from Users u where u.Username = @username", GetConnection());

                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                string usernameDB = "";

                while (reader.Read())
                {
                    usernameDB = reader.IsDBNull(0) ? "" : reader.GetString(0);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                if (usernameDB == username)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public User GetLogin(string username, string password)
        {
            try
            {
                GetConnection().Open();

                SqlCommand command = new SqlCommand("select u.Id,u.Name,u.LastName,u.Email,u.Username,u.Password,u.IdUserType from Users u where u.Username = @username and u.Password = @password", GetConnection());

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                User data = new User();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Username = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Password = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.IdUserType = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}