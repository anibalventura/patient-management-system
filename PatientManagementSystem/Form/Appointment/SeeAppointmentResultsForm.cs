using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class SeeAppointmentResultsForm : Form
    {
        public SeeAppointmentResultsForm()
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
            
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
