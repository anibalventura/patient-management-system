using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SelectPatientAptForm : Form
    {
        public static SelectPatientAptForm Instance { get; } = new SelectPatientAptForm();

        public SelectPatientAptForm()
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

        private void SelectPatientAptForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchPatient();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextStep();
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

        private void SearchPatient()
        {

        }

        private void NextStep()
        {
            SelectDoctorAptForm newSelectDoctorAptForm = new SelectDoctorAptForm();
            newSelectDoctorAptForm.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            AppointmentsForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
