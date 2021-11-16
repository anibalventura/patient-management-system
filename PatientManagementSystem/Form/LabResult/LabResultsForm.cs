using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LabResultsForm : Form
    {
        public static LabResultsForm Instance { get; } = new LabResultsForm();

        public LabResultsForm()
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

        private void LabResultsForm_Load(object sender, EventArgs e)
        {
            LoadLabResults();
        }

        private void LabResultsForm_VisibleChanged(object sender, EventArgs e)
        {
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

        }

        private void SearchByPatientIdentification()
        {

        }

        private void ReportLabResult()
        {
            ReportLabResultForm newReportLabResultForm = new ReportLabResultForm();
            newReportLabResultForm.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
