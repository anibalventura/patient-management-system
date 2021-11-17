using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ConsultAppointmentResultsForm : Form
    {
        public ConsultAppointmentResultsForm()
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

        }

        private void CompleteAppointment()
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
