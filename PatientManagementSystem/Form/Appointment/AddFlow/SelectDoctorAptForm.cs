using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SelectDoctorAptForm : Form
    {
        public static SelectDoctorAptForm Instance { get; } = new SelectDoctorAptForm();

        private DoctorService _doctorService;

        public SelectDoctorAptForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _doctorService = new DoctorService(connection);
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

            AppointmentRepository.Instance.IdSelectedDoctor = null;
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            SearchDoctor();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void DgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AppointmentRepository.Instance.IdSelectedDoctor = Convert.ToInt32(DgvDoctors.Rows[e.RowIndex].Cells[0].Value.ToString());
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

        private void LoadDoctors()
        {
            DgvDoctors.DataSource = _doctorService.GetAll();
            DgvDoctors.ClearSelection();
        }

        private void SearchDoctor()
        {
            string doctorIdentification = TxtBxDoctorIdentification.Text;

            if (doctorIdentification != null)
            {
                DgvDoctors.DataSource = _doctorService.GetByIdentf(doctorIdentification);
                DgvDoctors.ClearSelection();
            }
        }

        private void ClearSearch()
        {
            LoadDoctors();
            TxtBxDoctorIdentification.Clear();
        }

        private void NextStep()
        {
            if (AppointmentRepository.Instance.IdSelectedDoctor != null)
            {
                AddAppointmentForm newAddAppointmentForm = new AddAppointmentForm();
                newAddAppointmentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a doctor to continue.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            SelectPatientAptForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
