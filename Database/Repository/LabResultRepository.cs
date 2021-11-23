using System;
using System.Data;
using System.Data.SqlClient;
using Database.Model;

namespace Database.Repository
{
    public class LabResultRepository : BaseRepository, IRepository<LabResult>
    {
        public LabResultRepository(SqlConnection connection) : base(connection) { }

        public bool Add(LabResult labResult)
        {
            string sqlQuery = "insert into LabResults(IdPatient, IdAppointment, IdLabTest, IdDoctor, IdResultStatus) values(@idpatient, @idappointment, @idlabtest, @iddoctor, @idresultstatus)";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@idpatient", labResult.IdPatient);
            command.Parameters.AddWithValue("@idappointment", labResult.IdAppointment);
            command.Parameters.AddWithValue("@idlabtest", labResult.IdLabTest);
            command.Parameters.AddWithValue("@iddoctor", labResult.IdDoctor);
            command.Parameters.AddWithValue("@idresultstatus", labResult.IdResultStatus);

            return ExecuteDml(command);
        }

        public bool Edit(LabResult labResult)
        {
            throw new NotImplementedException();
        }

        public bool ReportResult(LabResult labResult)
        {
            string sqlQuery = "update LabResults set Result = @result, IdResultStatus = @idresultstatus where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@result", labResult.Result);
            command.Parameters.AddWithValue("@idresultstatus", labResult.IdResultStatus);
            command.Parameters.AddWithValue("@id", labResult.Id);

            return ExecuteDml(command);
        }

        public bool Delete(int labResultId)
        {
            throw new NotImplementedException();
        }

        public LabResult GetById(int labResultId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetByPatient(string patientIdentification)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlQuery = "select lr.Id as 'Code', p.Name, p.LastName as 'Last name', p.Identification, lt.Name as 'Lab test' from LabResults lr inner join Patients p on lr.IdPatient = p.Id inner join LabTests lt on lr.IdLabTest = lt.Id where p.Identification = @patientidentification";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@patientidentification", patientIdentification);
            adapter.SelectCommand = command;

            return LoadData(adapter);
        }

        public DataTable GetByAppointment(int appointmentId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlQuery = "select lt.Name as 'Test Name', rs.Name as 'Result Status' from LabResults lr inner join LabTests lt on lr.IdLabTest = lt.Id inner join ResultStatus rs on lr.IdResultStatus = rs.Id where lr.IdAppointment = @appointmentid";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@appointmentid", appointmentId);
            adapter.SelectCommand = command;

            return LoadData(adapter);
        }

        // Get only lab results by appointment and with result 'Complete' (1).
        public DataTable GetCompleteByAppointment(int appointmentId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlQuery = "select lt.Name as 'Test Name', lr.Result from LabResults lr inner join LabTests lt on lr.IdLabTest = lt.Id inner join ResultStatus rs on lr.IdResultStatus = rs.Id where lr.IdAppointment = @appointmentid and rs.Id = 1";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@appointmentid", appointmentId);
            adapter.SelectCommand = command;

            return LoadData(adapter);
        }

        // Get only lab results with 'Pending' status (2).
        public DataTable GetAllPending()
        {
            string sqlQuery = "select lr.Id as 'Code', p.Name, p.LastName as 'Last name', p.Identification, lt.Name as 'Lab test' from LabResults lr inner join Patients p on lr.IdPatient = p.Id inner join LabTests lt on lr.IdLabTest = lt.Id where IdResultStatus = 2";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
