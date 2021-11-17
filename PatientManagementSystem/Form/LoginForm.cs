using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance { get; } = new LoginForm();

        private UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _userService = new UserService(connection);
        }

        #region Events

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        #endregion

        #region Methods

        private void LoginUser()
        {
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;

            User user = _userService.GetLogin(username, password);

            if (user.Username == username && user.Password == password)
            {
                LoginRepository.Instance.IdLogedUserType = user.IdUserType;

                HomeForm newHomeForm = new HomeForm();
                newHomeForm.Show();
                this.Hide();

                ClearForm();
            }
            else if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please complete all fields to login.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Username or password are incorrect.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            TxtBxUsername.Clear();
            TxtBxPassword.Clear();
        }

        #endregion
    }
}
