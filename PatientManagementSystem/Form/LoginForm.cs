using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance { get; } = new LoginForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region Methods

        private void Login()
        {
            HomeForm newHomeForm = new HomeForm();
            newHomeForm.Show();
            this.Hide();

            ClearForm();
        }

        private void ClearForm()
        {
            TxtBxUsername.Clear();
            TxtBxPassword.Clear();
        }

        #endregion
    }
}
