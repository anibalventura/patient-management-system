using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        #region Events

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctorToEdit();
        }

        private void AddDoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoctorsForm.Instance.Show();
        }

        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            SelectPhoto();
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

        private void SelectPhoto()
        {

        }

        private void AddDoctor()
        {

        }

        private void LoadDoctorToEdit()
        {

        }

        private void EditDoctor()
        {

        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
