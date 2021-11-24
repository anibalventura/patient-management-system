using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SelectPatientAptForm : Form
    {
        public static SelectPatientAptForm Instance { get; } = new SelectPatientAptForm();

        private PatientService _patientService;

        public SelectPatientAptForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _patientService = new PatientService(connection);
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

            AppointmentRepository.Instance.IdSelectedPatient = null;
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            SearchPatient();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AppointmentRepository.Instance.IdSelectedPatient = Convert.ToInt32(DgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
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
            DgvPatients.DataSource = _patientService.GetAll();
            DgvPatients.ClearSelection();
        }

        private void SearchPatient()
        {
            if (TxtBxPatientIdentification.MaskCompleted)
            {
                string patientIdentification = TxtBxPatientIdentification.Text;

                if (patientIdentification != null)
                {
                    DgvPatients.DataSource = _patientService.GetByIdentf(patientIdentification);
                    DgvPatients.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please complete the field.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearSearch()
        {
            LoadPatients();
            TxtBxPatientIdentification.Clear();
        }

        private void NextStep()
        {
            if (AppointmentRepository.Instance.IdSelectedPatient != null)
            {
                SelectDoctorAptForm newSelectDoctorAptForm = new SelectDoctorAptForm();
                newSelectDoctorAptForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a patient to continue.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            AppointmentsForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
