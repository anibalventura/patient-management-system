using BusinessLayer.Repository;
using BusinessLayer.Service;
using BusinessLayer.Enum;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AppointmentsForm : Form
    {
        public static AppointmentsForm Instance { get; } = new AppointmentsForm();

        private AppointmentService _appointmentService;

        public AppointmentsForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _appointmentService = new AppointmentService(connection);
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
            HideButtons();
            LoadAppointments();

            AppointmentRepository.Instance.IdSelectedAppointment = null;
        }

        private void AppointmentsForm_VisibleChanged(object sender, EventArgs e)
        {
            HideButtons();
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

        private void DgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HideButtons();

                int selection = Convert.ToInt32(DgvAppointments.Rows[e.RowIndex].Cells[0].Value.ToString());

                AppointmentRepository.Instance.IdSelectedAppointment = selection;

                Appointment appointment = _appointmentService.GetById(selection);

                switch (appointment.IdAppointmentStatus)
                {
                    case (int)AppointmentStatus.PENDING_CONSULT:
                        BtnConsult.Show();
                        break;
                    case (int)AppointmentStatus.PENDING_RESULT:
                        BtnConsultResults.Show();
                        break;
                    case (int)AppointmentStatus.COMPLETE:
                        BtnSeeResults.Show();
                        break;
                }
            }
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

        private void HideButtons()
        {
            BtnConsult.Hide();
            BtnConsultResults.Hide();
            BtnSeeResults.Hide();
        }

        private void LoadAppointments()
        {
            DgvAppointments.DataSource = _appointmentService.GetAllPending();
            DgvAppointments.ClearSelection();
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
            if (AppointmentRepository.Instance.IdSelectedAppointment != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this appointment?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.OK)
                {
                    bool result = _appointmentService.Delete((int)AppointmentRepository.Instance.IdSelectedAppointment);

                    if (result)
                    {
                        MessageBox.Show("Appointment deleted successfully.", "Notification!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadAppointments();
                    AppointmentRepository.Instance.IdSelectedAppointment = null;
                }
                else
                {
                    DgvAppointments.ClearSelection();
                    AppointmentRepository.Instance.IdSelectedAppointment = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a appointment.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            AppointmentRepository.Instance.IdSelectedAppointment = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
