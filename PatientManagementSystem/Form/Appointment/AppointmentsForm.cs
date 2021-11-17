using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AppointmentsForm : Form
    {
        public static AppointmentsForm Instance { get; } = new AppointmentsForm();

        public AppointmentsForm()
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

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void AppointmentsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {
            ConsultAppointment();
        }

        private void BtnConsultResults_Click(object sender, EventArgs e)
        {
            ConsultAppointmentResults();
        }

        private void BtnSeeResults_Click(object sender, EventArgs e)
        {
            SeeAppointmentResults();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadAppointments()
        {

        }

        private void AddAppointment()
        {
            SelectPatientAptForm newSelectPatientAptForm = new SelectPatientAptForm();
            newSelectPatientAptForm.Show();
            this.Hide();
        }

        private void ConsultAppointment()
        {
            ConsultAppointmentForm newConsultAppointmentForm = new ConsultAppointmentForm();
            newConsultAppointmentForm.Show();
            this.Hide();
        }

        private void ConsultAppointmentResults()
        {
            ConsultAppointmentResultsForm newConsultAppointmentResultsForm = new ConsultAppointmentResultsForm();
            newConsultAppointmentResultsForm.Show();
            this.Hide();
        }

        private void SeeAppointmentResults()
        {
            SeeAppointmentResultsForm newSeeAppointmentResultsForm = new SeeAppointmentResultsForm();
            newSeeAppointmentResultsForm.Show();
            this.Hide();
        }

        private void DeleteAppointment()
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
