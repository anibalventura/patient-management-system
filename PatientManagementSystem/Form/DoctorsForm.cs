using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class DoctorsForm : Form
    {
        public static DoctorsForm Instance { get; } = new DoctorsForm();

        public DoctorsForm()
        {
            InitializeComponent();
        }

        #region Events

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void DoctorsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void DoctorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteDoctor();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadDoctors()
        {

        }

        private void AddDoctor()
        {
            AddDoctorForm newAddDoctorForm = new AddDoctorForm();
            newAddDoctorForm.Show();
            this.Hide();
        }

        private void EditDoctor()
        {
            AddDoctorForm newAddDoctorForm = new AddDoctorForm();
            newAddDoctorForm.Show();
            this.Hide();
        }

        private void DeleteDoctor()
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
