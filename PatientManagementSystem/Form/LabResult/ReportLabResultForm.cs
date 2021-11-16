using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ReportLabResultForm : Form
    {
        public ReportLabResultForm()
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
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
