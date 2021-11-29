using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ConsultAppointmentResultsForm : Form
    {
        private LabResultService _labResultService;
        private AppointmentService _appointmentService;

        public ConsultAppointmentResultsForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _labResultService = new LabResultService(connection);
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

        private void ConsultAppointmentResultsForm_Load(object sender, EventArgs e)
        {
            LoadLabResults();
        }

        private void ConsultAppointmentResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppointmentsForm.Instance.Show();
        }

        private void BtnCompleteAppointment_Click(object sender, EventArgs e)
        {
            CompleteAppointment();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadLabResults()
        {
            DgvLabResults.DataSource = _labResultService.GetByAppointment((int)AppointmentRepository.Instance.IdSelectedAppointment);
            DgvLabResults.ClearSelection();
        }

        private void CompleteAppointment()
        {
            bool result = _appointmentService.Complete((int)AppointmentRepository.Instance.IdSelectedAppointment);

            if (result)
            {
                DialogResult response = MessageBox.Show("Appointment complete successfully.", "Notification!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (response == DialogResult.OK)
                {
                    CloseForm();
                }
            }
            else
            {
                MessageBox.Show("There was a problem completing the appointment, try again later.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseForm()
        {
            AppointmentRepository.Instance.IdSelectedAppointment = null;

            this.Close();
        }

        #endregion
    }
}
