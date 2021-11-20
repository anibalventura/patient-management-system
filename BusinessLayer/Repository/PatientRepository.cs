namespace BusinessLayer.Repository
{
    public class PatientRepository
    {
        public static PatientRepository Instance { get; } = new PatientRepository();

        public int? IdSelectedPatient { get; set; } = null;
    }
}
