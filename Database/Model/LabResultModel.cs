namespace Database.Model
{
    public class LabResult
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdAppointment { get; set; }
        public int IdLabTest { get; set; }
        public int IdDoctor { get; set; }
        public string Result { get; set; }
        public int IdResultStatus { get; set; }
    }
}
