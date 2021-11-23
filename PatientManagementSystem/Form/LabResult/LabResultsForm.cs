using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LabResultsForm : Form
    {
        public static LabResultsForm Instance { get; } = new LabResultsForm();

        private LabResultService _labResultService;

        public LabResultsForm()
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

        private void LabResultsForm_Load(object sender, EventArgs e)
        {
            BtnReportResult.Hide();

            LoadLabResults();

            LabResultRepository.Instance.IdSelectedLabResult = null;
        }

        private void LabResultsForm_VisibleChanged(object sender, EventArgs e)
        {
            BtnReportResult.Hide();

            LoadLabResults();
        }

        private void LabResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchByPatientIdentification();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void DgvLabResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LabResultRepository.Instance.IdSelectedLabResult = Convert.ToInt32(DgvLabResults.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnReportResult.Show();
            }
        }

        private void BtnReportResult_Click(object sender, EventArgs e)
        {
            ReportLabResult();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadLabResults()
        {
            DgvLabResults.DataSource = _labResultService.GetAllPending();
            DgvLabResults.ClearSelection();
        }

        private void SearchByPatientIdentification()
        {
            string patientIdentification = TxtBxPatientIdentification.Text;

            if (patientIdentification != null)
            {
                DgvLabResults.DataSource = _labResultService.GetByPatient(patientIdentification);
                DgvLabResults.ClearSelection();
            }
        }

        private void ClearSearch()
        {
            LoadLabResults();
            TxtBxPatientIdentification.Clear();
            BtnReportResult.Hide();
        }

        private void ReportLabResult()
        {
            ReportLabResultForm newReportLabResultForm = new ReportLabResultForm();
            newReportLabResultForm.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            LabResultRepository.Instance.IdSelectedLabResult = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
