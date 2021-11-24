using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ConsultAppointmentForm : Form
    {
        private LabTestService _labTestService;
        private LabResultService _labResultService;
        private AppointmentService _appointmentService;

        public ConsultAppointmentForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _labTestService = new LabTestService(connection);
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

        private void ConsultAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadLabTests();
        }

        private void ConsultAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppointmentsForm.Instance.Show();
        }

        private void DgvLabTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (System.Windows.Forms.DataGridViewRow row in DgvLabTests.SelectedRows)
            {
                AppointmentRepository.Instance.SelectedLabTests.Add(Convert.ToInt32(row.Cells[0].Value));
            }
        }

        private void BtnRunTests_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadLabTests()
        {
            DgvLabTests.DataSource = _labTestService.GetAll();
            DgvLabTests.ClearSelection();
        }

        private void RunTests()
        {
            if (AppointmentRepository.Instance.SelectedLabTests.Count != 0)
            {
                Appointment appointment = _appointmentService.GetById((int)AppointmentRepository.Instance.IdSelectedAppointment);

                foreach (int labTestId in AppointmentRepository.Instance.SelectedLabTests)
                {
                    _labResultService.Add(new LabResult()
                    {
                        IdPatient = appointment.IdPatient,
                        IdAppointment = appointment.Id,
                        IdLabTest = labTestId,
                        IdDoctor = appointment.IdDoctor,
                        IdResultStatus = 2, // Pending Status.
                    });
                }

                bool result = _appointmentService.Consult(appointment.Id);

                if (result)
                {
                    DialogResult response = MessageBox.Show("Appointment consulted successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem consulting the appointment, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select at least one lab test.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            AppointmentRepository.Instance.SelectedLabTests.Clear();

            this.Close();
        }

        #endregion
    }
}
