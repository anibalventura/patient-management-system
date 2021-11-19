namespace BusinessLayer.Repository
{
    public class LabTestRepository
    {
        public static LabTestRepository Instance { get; } = new LabTestRepository();

        public int? IdSelectedLabTest { get; set; } = null;
    }
}
