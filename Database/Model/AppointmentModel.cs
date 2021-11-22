using System;

namespace Database.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Cause { get; set; }
        public int IdAppointmentStatus { get; set; }
    }
}
