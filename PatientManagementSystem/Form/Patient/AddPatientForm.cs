using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using FileHandler;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddPatientForm : Form
    {
        private PatientService _patientService;
        private FileSaver _fileSaver;
        private string _fileName;

        public AddPatientForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _patientService = new PatientService(connection);

            // Init file saver.
            _fileSaver = new FileSaver();
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

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            LoadPatientToEdit();

            DtpBirthDate.MaxDate = DateTime.Now;
        }

        private void AddPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientsForm.Instance.Show();
        }

        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            SelectPhoto();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (PatientRepository.Instance.IdSelectedPatient != null)
            {
                EditPatient();
            }
            else
            {
                AddPatient();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void SelectPhoto()
        {
            DialogResult result = PhotoDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (PhotoDialog.FileName.EndsWith(".png") || PhotoDialog.FileName.EndsWith(".jpg") || PhotoDialog.FileName.EndsWith(".jpeg"))
                {
                    string file = PhotoDialog.FileName;
                    _fileName = file;

                    PbPatient.ImageLocation = file;
                }
                else
                {
                    MessageBox.Show("Only can select files with image format (*.PNG; *.JPG, *.JPEG).", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SavePhoto()
        {
            int id = PatientRepository.Instance.IdSelectedPatient == null ? _patientService.GetLastId() : (int)PatientRepository.Instance.IdSelectedPatient;
            string directory = $@"Images\Patients\{id}\";
            string destination = _fileSaver.SaveFile(_fileName, directory);

            if (destination != null)
            {
                _patientService.SavePhoto(id, destination);
            }
        }

        private void AddPatient()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string phone = TxtBxPhone.Text;
            string address = TxtBxAddress.Text;
            string identification = TxtBxIdentification.Text;
            DateTime birthDate = DtpBirthDate.Value.Date;
            bool smoker = ChkBxNo.Checked ? false : ChkBxYes.Checked;
            string allergies = TxtBxAllergies.Text;
            string photo = PbPatient.ImageLocation;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || !TxtBxPhone.MaskCompleted || String.IsNullOrEmpty(address)
                || !TxtBxIdentification.MaskCompleted || birthDate == DateTime.Now.Date || String.IsNullOrEmpty(allergies)
                || String.IsNullOrEmpty(photo))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ChkBxYes.Checked == ChkBxNo.Checked)
            {
                MessageBox.Show("Select one option for smoker.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = _patientService.Add(new Patient()
                {
                    Name = name,
                    LastName = lastName,
                    Phone = phone,
                    Address = address,
                    Identification = identification,
                    BirthDate = birthDate,
                    Smoker = smoker,
                    Allergies = allergies,
                });

                if (result)
                {
                    SavePhoto();

                    DialogResult response = MessageBox.Show("Patient created successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the patient, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPatientToEdit()
        {
            if (PatientRepository.Instance.IdSelectedPatient != null)
            {
                Patient patient = _patientService.GetById((int)PatientRepository.Instance.IdSelectedPatient);

                TxtBxName.Text = patient.Name;
                TxtBxLastName.Text = patient.LastName;
                TxtBxPhone.Text = patient.Phone;
                TxtBxAddress.Text = patient.Address;
                TxtBxIdentification.Text = patient.Identification;
                DtpBirthDate.Value = patient.BirthDate.Date;
                ChkBxYes.Checked = patient.Smoker;
                ChkBxNo.Checked = patient.Smoker == false ? true : false;
                TxtBxAllergies.Text = patient.Allergies;
                PbPatient.ImageLocation = patient.Photo;

                _fileName = patient.Photo;
            }
        }

        private void EditPatient()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string phone = TxtBxPhone.Text;
            string address = TxtBxAddress.Text;
            string identification = TxtBxIdentification.Text;
            DateTime birthDate = DtpBirthDate.Value.Date;
            bool smoker = ChkBxNo.Checked ? false : ChkBxYes.Checked;
            string allergies = TxtBxAllergies.Text;
            string photo = PbPatient.ImageLocation;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || !TxtBxPhone.MaskCompleted || String.IsNullOrEmpty(address)
                || !TxtBxIdentification.MaskCompleted || birthDate == DateTime.Now.Date || String.IsNullOrEmpty(allergies) 
                || String.IsNullOrEmpty(photo))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ChkBxYes.Checked == ChkBxNo.Checked)
            {
                MessageBox.Show("Select one option for smoker.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = _patientService.Edit(new Patient()
                {
                    Id = (int)PatientRepository.Instance.IdSelectedPatient,
                    Name = name,
                    LastName = lastName,
                    Phone = phone,
                    Address = address,
                    Identification = identification,
                    BirthDate = birthDate,
                    Smoker = smoker,
                    Allergies = allergies,
                });

                if (result)
                {
                    SavePhoto();

                    DialogResult response = MessageBox.Show("Patient edited successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem editing the patient, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseForm()
        {
            PatientRepository.Instance.IdSelectedPatient = null;

            this.Close();
        }

        #endregion
    }
}
