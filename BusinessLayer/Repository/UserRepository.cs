namespace BusinessLayer.Repository
{
    public class UserRepository
    {
        public static UserRepository Instance { get; } = new UserRepository();

        public int? IdSelectedUser { get; set; } = null;
    }
}
