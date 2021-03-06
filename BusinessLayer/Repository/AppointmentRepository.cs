using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class AppointmentRepository
    {
        public static AppointmentRepository Instance { get; } = new AppointmentRepository();

        public int? IdSelectedAppointment { get; set; } = null;

        public int? IdSelectedPatient { get; set; } = null;

        public int? IdSelectedDoctor { get; set; } = null;

        public List<int> SelectedLabTests { get; set; } = new List<int>();
    }
}
