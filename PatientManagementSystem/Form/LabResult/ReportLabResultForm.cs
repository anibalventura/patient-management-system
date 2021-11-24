using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ReportLabResultForm : Form
    {
        private LabResultService _labResultService;

        public ReportLabResultForm()
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

        private void ReportLabResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LabResultsForm.Instance.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ReportLabResult();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void ReportLabResult()
        {
            string labResult = TxtBxResult.Text;

            if (String.IsNullOrEmpty(labResult))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = _labResultService.ReportResult(new LabResult()
                {
                    Id = (int)LabResultRepository.Instance.IdSelectedLabResult,
                    Result = labResult,
                    IdResultStatus = 1 // Set to 'Complete' (1).
                });

                if (result)
                {
                    DialogResult response = MessageBox.Show("Lab result reported successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                    else
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem reporting the lab result, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseForm()
        {
            LabResultRepository.Instance.IdSelectedLabResult = null;

            this.Close();
        }

        #endregion
    }
}
