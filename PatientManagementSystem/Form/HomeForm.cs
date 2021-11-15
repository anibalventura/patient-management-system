using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class HomeForm : Form
    {
        public static HomeForm Instance { get; } = new HomeForm();

        public HomeForm()
        {
            InitializeComponent();
        }

        // Disable window close button.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;  // CS_NOCLOSE
                return parms;
            }
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
            UsersForm newUsersForm = new UsersForm();
            newUsersForm.Show();
            this.Hide();
        }

        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm newDoctorsForm = new DoctorsForm();
            newDoctorsForm.Show();
            this.Hide();
        }

        private void BtnLabTest_Click(object sender, EventArgs e)
        {
            LabTestsForm newLabTestsForm = new LabTestsForm();
            newLabTestsForm.Show();
            this.Hide();
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
