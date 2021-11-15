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
