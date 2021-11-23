using Database.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repository
{
    public class PatientRepository : BaseRepository, IRepository<Patient>
    {
        public PatientRepository(SqlConnection connection) : base(connection) { }

        public bool Add(Patient patient)
        {
            string sqlQuery = "insert into Patients(Name, LastName, Phone, Address, Identification, BirthDate, Smoker, Allergies) values(@name, @lastname, @phone, @address, @identification, @birthdate, @smoker, @allergies)";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@lastname", patient.LastName);
            command.Parameters.AddWithValue("@phone", patient.Phone);
            command.Parameters.AddWithValue("@address", patient.Address);
            command.Parameters.AddWithValue("@identification", patient.Identification);
            command.Parameters.AddWithValue("@birthdate", patient.BirthDate);
            command.Parameters.AddWithValue("@smoker", patient.Smoker);
            command.Parameters.AddWithValue("@allergies", patient.Allergies);

            return ExecuteDml(command);
        }

        public bool Edit(Patient patient)
        {
            string sqlQuery = "update Patients set Name = @name, LastName = @lastname, Phone = @phone, Address = @address, Identification = @identification, BirthDate = @birthdate, Smoker = @smoker, Allergies = @allergies where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@lastname", patient.LastName);
            command.Parameters.AddWithValue("@phone", patient.Phone);
            command.Parameters.AddWithValue("@address", patient.Address);
            command.Parameters.AddWithValue("@identification", patient.Identification);
            command.Parameters.AddWithValue("@birthdate", patient.BirthDate);
            command.Parameters.AddWithValue("@smoker", patient.Smoker);
            command.Parameters.AddWithValue("@allergies", patient.Allergies);
            command.Parameters.AddWithValue("@id", patient.Id);

            return ExecuteDml(command);
        }

        public bool SavePhoto(int id, string destination)
        {

            SqlCommand command = new SqlCommand("update Patients set Photo = @photo where Id = @id", GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@photo", destination);

            return ExecuteDml(command);
        }

        public bool Delete(int patientId)
        {
            string sqlQuery = "delete Patients where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", patientId);

            return ExecuteDml(command);
        }

        public Patient GetById(int patientId)
        {
            GetConnection().Open();

            string sqlQuery = "select Id, Name, LastName, Phone, Address, Identification, BirthDate, Smoker, Allergies, Photo from Patients where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", patientId);

            SqlDataReader reader = command.ExecuteReader();

            Patient data = new Patient();
            while (reader.Read())
            {
                data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                data.Phone = reader.IsDBNull(3) ? "" : reader.GetString(3);
                data.Address = reader.IsDBNull(4) ? "" : reader.GetString(4);
                data.Identification = reader.IsDBNull(5) ? "" : reader.GetString(5);
                data.BirthDate = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
                data.Smoker = reader.IsDBNull(7) ? false : reader.GetBoolean(7);
                data.Allergies = reader.IsDBNull(8) ? "" : reader.GetString(8);
                data.Photo = reader.IsDBNull(9) ? "" : reader.GetString(9);
            }

            reader.Close();
            reader.Dispose();
            GetConnection().Close();

            return data;
        }

        public int GetLastId()
        {
            GetConnection().Open();

            string sqlQuery = "select max(Id) as Id from Patients";
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

        public DataTable GetByIdentf(string patientIdentification)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlQuery = "select Id as 'Code', Name, LastName as 'Last name', Phone, Address, Identification, BirthDate as 'Birth date', Smoker, Allergies from Patients where Identification = @patientidentification";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@patientidentification", patientIdentification);
            adapter.SelectCommand = command;

            return LoadData(adapter);
        }

        public DataTable GetAllPending()
        {
            string sqlQuery = "select Id as 'Code', Name, LastName as 'Last name', Phone, Address, Identification, BirthDate as 'Birth date', Smoker, Allergies from Patients";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
