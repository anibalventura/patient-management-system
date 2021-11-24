using BusinessLayer.Enum;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            EnableOptionsByUserType();
        }

        private void HomeForm_VisibleChanged(object sender, EventArgs e)
        {
            EnableOptionsByUserType();
        }

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
            PatientsForm newPatientsForm = new PatientsForm();
            newPatientsForm.Show();
            this.Hide();
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm newAppointmentsForm = new AppointmentsForm();
            newAppointmentsForm.Show();
            this.Hide();
        }

        private void BtnLabResults_Click(object sender, EventArgs e)
        {
            LabResultsForm newLabResultsForm = new LabResultsForm();
            newLabResultsForm.Show();
            this.Hide();
        }

        #endregion

        #region Methods

        private void Logout()
        {
            CloseForm();
        }

        private void EnableOptionsByUserType()
        {
            int userType = (int)LoginRepository.Instance.IdLogedUserType;

            if (userType == (int)UserTypeOptions.ADMIN)
            {
                BtnUsers.Enabled = true;
                BtnDoctors.Enabled = true;
                BtnLabTest.Enabled = true;
                BtnPatients.Enabled = false;
                BtnAppointments.Enabled = false;
                BtnLabResults.Enabled = false;
            }
            else if (userType == (int)UserTypeOptions.DOCTOR)
            {
                BtnUsers.Enabled = false;
                BtnDoctors.Enabled = false;
                BtnLabTest.Enabled = false;
                BtnPatients.Enabled = true;
                BtnAppointments.Enabled = true;
                BtnLabResults.Enabled = true;
            }
        }

        private void CloseForm()
        {
            LoginForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
