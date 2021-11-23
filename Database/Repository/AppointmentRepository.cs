using Database.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repository
{
    public class AppointmentRepository : BaseRepository, IRepository<Appointment>
    {
        public AppointmentRepository(SqlConnection connection) : base(connection) { }

        public bool Add(Appointment appointment)
        {
            string sqlQuery = "insert into Appointments(IdPatient, IdDoctor, DateAndTime, Cause, IdAppointmentStatus) values(@idpatient, @iddoctor, @dateandtime, @cause, @idappointmentstatus)";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@idpatient", appointment.IdPatient);
            command.Parameters.AddWithValue("@iddoctor", appointment.IdDoctor);
            command.Parameters.AddWithValue("@dateandtime", appointment.DateAndTime);
            command.Parameters.AddWithValue("@cause", appointment.Cause);
            command.Parameters.AddWithValue("@idappointmentstatus", appointment.IdAppointmentStatus);

            return ExecuteDml(command);
        }

        public bool Edit(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        // Update appointment to 'Pending Results' status (2).
        public bool Consult(int appointmentId)
        {
            string sqlQuery = "update Appointments set IdAppointmentStatus = 2 where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", appointmentId);

            return ExecuteDml(command);
        }

        // Update appointment to 'Complete' status (1).
        public bool Complete(int appointmentId)
        {
            string sqlQuery = "update Appointments set IdAppointmentStatus = 1 where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", appointmentId);

            return ExecuteDml(command);
        }

        public bool Delete(int appointmentId)
        {
            string sqlQuery = "delete Appointments where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", appointmentId);

            return ExecuteDml(command);
        }

        public Appointment GetById(int appointmentId)
        {
            try
            {
                GetConnection().Open();

                string sqlQuery = "select Id, IdPatient, IdDoctor, DateAndTime, Cause, IdAppointmentStatus from Appointments where Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

                command.Parameters.AddWithValue("@id", appointmentId);

                SqlDataReader reader = command.ExecuteReader();

                Appointment data = new Appointment();
                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.IdPatient = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.IdDoctor = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.DateAndTime = reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3);
                    data.Cause = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.IdAppointmentStatus = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
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
            string sqlQuery = "select ap.Id as 'Code', (p.Name + ' ' + p.LastName) as 'Patient', (d.Name + ' ' + d.LastName) as 'Doctor', cast(ap.DateAndTime as Date) as 'Date', cast(ap.DateAndTime as Time(0)) as 'Time', ap.Cause, apst.Name as 'Status' from Appointments ap inner join Patients p on ap.IdPatient = p.Id inner join Doctors d on ap.IdDoctor = d.Id inner join AppointmentStatus apst on ap.IdAppointmentStatus = apst.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
