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

        public bool Delete(int appointmentId)
        {
            string sqlQuery = "delete Appointments where Id = @id";
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            command.Parameters.AddWithValue("@id", appointmentId);

            return ExecuteDml(command);
        }

        public Appointment GetById(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            string sqlQuery = "select ap.Id as 'Code', (p.Name + ' ' + p.LastName) as 'Patient', (d.Name + ' ' + d.LastName) as 'Doctor', cast(ap.DateAndTime as Date) as 'Date', cast(ap.DateAndTime as Time(0)) as 'Time', ap.Cause, apst.Name as 'Status' from Appointments ap inner join Patients p on ap.IdPatient = p.Id inner join Doctors d on ap.IdDoctor = d.Id inner join AppointmentStatus apst on ap.IdAppointmentStatus = apst.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GetConnection());
            return LoadData(adapter);
        }
    }
}
