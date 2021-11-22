using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddAppointmentForm : Form
    {
        private PatientService _patientService;
        private DoctorService _doctorService;
        private AppointmentService _appointmentService;

        public AddAppointmentForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _patientService = new PatientService(connection);
            _doctorService = new DoctorService(connection);
            _appointmentService = new AppointmentService(connection);
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveAppoointment();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BackStep();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadSelectedInfo()
        {
            if (AppointmentRepository.Instance.IdSelectedPatient != null && AppointmentRepository.Instance.IdSelectedDoctor != null)
            {
                Patient patient = _patientService.GetById((int)AppointmentRepository.Instance.IdSelectedPatient);
                TxtBxPatient.Text = $"{patient.Name} {patient.LastName}";

                Doctor doctor = _doctorService.GetById((int)AppointmentRepository.Instance.IdSelectedDoctor);
                TxtBxDoctor.Text = $"{doctor.Name} {doctor.LastName}";
            }
        }

        private void SaveAppoointment()
        {
            DateTime date = DtpDate.Value.Date;
            TimeSpan time = DtpTime.Value.TimeOfDay;
            string cause = TxtBxCause.Text;

            if (date == DateTime.Now.Date || time == DateTime.Now.TimeOfDay || String.IsNullOrEmpty(cause))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Appointment newAppointment = new Appointment()
                {
                    IdPatient = (int)AppointmentRepository.Instance.IdSelectedPatient,
                    IdDoctor = (int)AppointmentRepository.Instance.IdSelectedDoctor,
                    DateAndTime = date + time,
                    Cause = cause,
                    IdAppointmentStatus = 3
                };

                bool result = _appointmentService.Add(newAppointment);

                if (result)
                {
                    DialogResult response = MessageBox.Show("Appointment created successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the appointment, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackStep()
        {
            SelectDoctorAptForm.Instance.Show();
            this.Hide();
        }

        private void CloseForm()
        {
            AppointmentRepository.Instance.IdSelectedPatient = null;
            AppointmentRepository.Instance.IdSelectedDoctor = null;

            this.Close();
        }

        #endregion
    }
}
