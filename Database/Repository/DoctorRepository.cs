using Database.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repository
{
    public class DoctorRepository : BaseRepository, IRepository<Doctor>
    {
        public DoctorRepository(SqlConnection connection) : base(connection) { }

        public bool Add(Doctor doctor)
        {
            string sqlQuery = "insert into Doctors(Name, LastName, Email, Phone, Identification) values(@name, @lastname, @email, @phone, @identification)";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", doctor.Name);
            command.Parameters.AddWithValue("@lastname", doctor.LastName);
            command.Parameters.AddWithValue("@email", doctor.Email);
            command.Parameters.AddWithValue("@phone", doctor.Phone);
            command.Parameters.AddWithValue("@identification", doctor.Identification);

            return ExecuteDml(command);
        }

        public bool Edit(Doctor doctor)
        {
            string sqlQuery = "update Doctors set Name = @name, LastName = @lastname, Email = @email, Phone = @phone, Identification = @identification where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", doctor.Name);
            command.Parameters.AddWithValue("@lastname", doctor.LastName);
            command.Parameters.AddWithValue("@email", doctor.Email);
            command.Parameters.AddWithValue("@phone", doctor.Phone);
            command.Parameters.AddWithValue("@identification", doctor.Identification);
            command.Parameters.AddWithValue("@id", doctor.Id);

            return ExecuteDml(command);
        }

        public bool SavePhoto(int id, string destination)
        {

            SqlCommand command = new SqlCommand("update Doctors set Photo = @photo where Id = @id", GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@photo", destination);

            return ExecuteDml(command);
        }

        public bool Delete(int doctorId)
        {
            string sqlQuery = "delete Doctors where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", doctorId);

            return ExecuteDml(command);
        }

        public Doctor GetById(int doctorId)
        {
            try
            {
                GetConnection().Open();

                string sqlQuery = "select Id, Name, LastName, Email, Phone, Identification, Photo from Doctors where Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

                command.Parameters.AddWithValue("@id", doctorId);

                SqlDataReader reader = command.ExecuteReader();

                Doctor data = new Doctor();
                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Phone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Identification = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Photo = reader.IsDBNull(6) ? "" : reader.GetString(6);
                }

                reader.Close();
                reader.Dispose();
                GetConnection().Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetLastId()
        {
            GetConnection().Open();

            string sqlQuery = "select max(Id) as Id from Doctors";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            SqlDataReader reader = command.ExecuteReader();

            int lastId = 0;
            while (reader.Read())
            {
                lastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            }

            reader.Close();
            reader.Dispose();
            GetConnection().Close();

            return lastId;
        }

        public DataTable GetByIdentf(string doctorIdentification)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlQuery = "select Id as 'Code', Name, LastName as 'Last name', Email, Phone, Identification from Doctors where Identification = @patientidentification";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@patientidentification", doctorIdentification);
            adapter.SelectCommand = command;

            return LoadData(adapter);
        }

        public DataTable GetAllPending()
        {
            string sqlQuery = "select Id as 'Code', Name, LastName as 'Last name', Email, Phone, Identification from Doctors";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
