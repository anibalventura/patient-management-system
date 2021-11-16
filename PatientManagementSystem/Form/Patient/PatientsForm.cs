using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class PatientsForm : Form
    {
        public static PatientsForm Instance { get; } = new PatientsForm();

        public PatientsForm()
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

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void PatientsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void PatientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPatient();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditPatient();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadPatients()
        {

        }

        private void AddPatient()
        {
            AddPatientForm newAddPatientForm = new AddPatientForm();
            newAddPatientForm.Show();
            this.Hide();
        }

        private void EditPatient()
        {
            AddPatientForm newAddPatientForm = new AddPatientForm();
            newAddPatientForm.Show();
            this.Hide();
        }

        private void DeletePatient()
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
