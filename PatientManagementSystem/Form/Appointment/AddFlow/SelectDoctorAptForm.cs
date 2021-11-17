using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SelectDoctorAptForm : Form
    {
        public static SelectDoctorAptForm Instance { get; } = new SelectDoctorAptForm();

        public SelectDoctorAptForm()
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

        private void SelectDoctorAptForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchDoctor();
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

        private void LoadDoctors()
        {

        }

        private void SearchDoctor()
        {

        }

        private void NextStep()
        {
            AddAppointmentForm newAddAppointmentForm = new AddAppointmentForm();
            newAddAppointmentForm.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            SelectPatientAptForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
