using Database.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repository
{
    public class LabTestRepository : BaseRepository, IRepository<LabTest>
    {
        public LabTestRepository(SqlConnection connection) : base(connection) { }

        public bool Add(LabTest labTest)
        {
            string sqlQuery = "insert into LabTests(Name) values(@name)";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", labTest.Name);

            return ExecuteDml(command);
        }

        public bool Edit(LabTest labTest)
        {
            string sqlQuery = "update LabTests set Name = @name where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@name", labTest.Name);
            command.Parameters.AddWithValue("@id", labTest.Id);

            return ExecuteDml(command);
        }

        public bool Delete(int labTestId)
        {
            string sqlQuery = "delete LabTests where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", labTestId);

            return ExecuteDml(command);
        }

        public LabTest GetById(int labTestId)
        {
            try
            {
                GetConnection().Open();

                string sqlQuery = "select Id, Name from LabTests where Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

                command.Parameters.AddWithValue("@id", labTestId);

                SqlDataReader reader = command.ExecuteReader();

                LabTest data = new LabTest();
                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
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

        public DataTable GetAllPending()
        {
            string sqlQuery = "select Id as 'Code', Name from LabTests";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
