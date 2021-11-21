namespace BusinessLayer.Repository
{
    public class LabResultRepository
    {
        public static LabResultRepository Instance { get; } = new LabResultRepository();

        public int? IdSelectedLabResult { get; set; } = null;
    }
}
