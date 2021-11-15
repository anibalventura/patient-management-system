using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        #region Events

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            LoadUserToEdit();
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsersForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void AddUser()
        {

        }

        private void LoadUserToEdit()
        {

        }

        private void EditUser()
        {

        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
