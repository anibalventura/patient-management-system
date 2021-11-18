namespace BusinessLayer.Repository
{
    public class DoctorRepository
    {
        public static DoctorRepository Instance { get; } = new DoctorRepository();

        public int? IdSelectedDoctor { get; set; } = null;
    }
}
