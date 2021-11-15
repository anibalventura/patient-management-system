using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class UsersForm : Form
    {
        public static UsersForm Instance { get; } = new UsersForm();

        public UsersForm()
        {
            InitializeComponent();
        }

        #region Events

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void UsersForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadUsers()
        {

        }

        private void AddUser()
        {
            AddUserForm newAddUserForm = new AddUserForm();
            newAddUserForm.Show();
            this.Hide();
        }

        private void EditUser()
        {
            AddUserForm newAddUserForm = new AddUserForm();
            newAddUserForm.Show();
            this.Hide();
        }

        private void DeleteUser()
        {

        }

        private void CloseForm()
        {
            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
