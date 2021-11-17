using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
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

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadSelectedInfo();
        }

        private void AddAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppointmentsForm.Instance.Show();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateAppointment();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackStep();
        }

        #endregion

        #region Methods

        private void LoadSelectedInfo()
        {

        }

        private void CreateAppointment()
        {
            CloseForm();
        }

        private void BackStep()
        {
            SelectDoctorAptForm.Instance.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
