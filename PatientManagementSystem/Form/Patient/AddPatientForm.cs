using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
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

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            LoadPatientToEdit();
        }

        private void AddPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientsForm.Instance.Show();
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

        private void AddPatient()
        {

        }

        private void LoadPatientToEdit()
        {

        }

        private void EditPatient()
        {

        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
