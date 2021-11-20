using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class PatientsForm : Form
    {
        public static PatientsForm Instance { get; } = new PatientsForm();

        private PatientService _patientService;

        public PatientsForm()
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

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();

            PatientRepository.Instance.IdSelectedPatient = null; 
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

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PatientRepository.Instance.IdSelectedPatient = Convert.ToInt32(DgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
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
            DgvPatients.DataSource = _patientService.GetAll();
            DgvPatients.ClearSelection();
        }

        private void AddPatient()
        {
            PatientRepository.Instance.IdSelectedPatient = null;

            AddPatientForm newAddPatientForm = new AddPatientForm();
            newAddPatientForm.Show();
            this.Hide();
        }

        private void EditPatient()
        {
            if (PatientRepository.Instance.IdSelectedPatient != null)
            {
                AddPatientForm newAddPatientForm = new AddPatientForm();
                newAddPatientForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a patient.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePatient()
        {
            if (PatientRepository.Instance.IdSelectedPatient != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this patient?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.OK)
                {
                    bool result = _patientService.Delete((int)PatientRepository.Instance.IdSelectedPatient);

                    if (result)
                    {
                        MessageBox.Show("Patient deleted successfully.", "Notification!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadPatients();
                }
                else
                {
                    DgvPatients.ClearSelection();
                    PatientRepository.Instance.IdSelectedPatient = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a patient.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            PatientRepository.Instance.IdSelectedPatient = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
