namespace BusinessLayer.Service
{
    public class LoginRepository
    {
        public static LoginRepository Instance { get; } = new LoginRepository();

        public int? IdLogedUserType { get; set; } = null;
    }
}