using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SeeAppointmentResultsForm : Form
    {
        private LabResultService _labResultService;

        public SeeAppointmentResultsForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _labResultService = new LabResultService(connection);
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

        private void SeeAppointmentResultsForm_Load(object sender, EventArgs e)
        {
            LoadLabResults();
        }

        private void SeeAppointmentResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppointmentsForm.Instance.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadLabResults()
        {
            DgvLabResults.DataSource = _labResultService.GetCompleteByAppointment((int)AppointmentRepository.Instance.IdSelectedAppointment);
            DgvLabResults.ClearSelection();
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
