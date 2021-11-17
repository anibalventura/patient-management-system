using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class ConsultAppointmentForm : Form
    {
        public ConsultAppointmentForm()
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

        private void ConsultAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadLabTests();
        }

        private void ConsultAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppointmentsForm.Instance.Show();
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

        }

        private void RunTests()
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
