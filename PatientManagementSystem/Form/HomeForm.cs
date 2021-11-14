using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Events

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void MsItemLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoctors_Click(object sender, EventArgs e)
        {

        }

        private void BtnLabTest_Click(object sender, EventArgs e)
        {

        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {

        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {

        }

        private void BtnLabResults_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        private void Logout()
        {
            CloseForm();
        }

        private void CloseForm()
        {
            LoginForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
