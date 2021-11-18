using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using FileHandler;

namespace PatientManagementSystem
{
    public partial class AddDoctorForm : Form
    {
        private DoctorService _doctorService;
        private FileSaver _fileSaver;
        private string _fileName;

        public AddDoctorForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _doctorService = new DoctorService(connection);

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

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctorToEdit();
        }

        private void AddDoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoctorsForm.Instance.Show();
        }

        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            SelectPhoto();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DoctorRepository.Instance.IdSelectedDoctor != null)
            {
                EditDoctor();
            }
            else
            {
                AddDoctor();
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
                string file = PhotoDialog.FileName;
                _fileName = file;

                PbDoctor.ImageLocation = file;
            }
        }

        private void SavePhoto()
        {
            int id = DoctorRepository.Instance.IdSelectedDoctor == null ? _doctorService.GetLastId() : (int)DoctorRepository.Instance.IdSelectedDoctor;
            string directory = $@"Images\Doctors\{id}\";
            string destination = _fileSaver.SaveFile(_fileName, directory);

            if (destination != null)
            {
                _doctorService.SavePhoto(id, destination);
            }
        }

        private void AddDoctor()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string email = TxtBxEmail.Text;
            string phone = TxtBxPhone.Text;
            string identification = TxtBxIdentification.Text;
            string photo = PbDoctor.ImageLocation;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email)
                || !TxtBxPhone.MaskCompleted || !TxtBxIdentification.MaskCompleted || String.IsNullOrEmpty(photo))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Doctor newDoctor = new Doctor()
                {
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Phone = phone,
                    Identification = identification,
                };

                bool result = _doctorService.Add(newDoctor);

                if (result)
                {
                    SavePhoto();

                    DialogResult response = MessageBox.Show("Doctor created successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the doctor, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDoctorToEdit()
        {
            if (DoctorRepository.Instance.IdSelectedDoctor != null)
            {
                Doctor doctor = _doctorService.GetById((int)DoctorRepository.Instance.IdSelectedDoctor);

                TxtBxName.Text = doctor.Name;
                TxtBxLastName.Text = doctor.LastName;
                TxtBxEmail.Text = doctor.Email;
                TxtBxPhone.Text = doctor.Phone;
                TxtBxIdentification.Text = doctor.Identification;
                PbDoctor.ImageLocation = doctor.Photo;
                _fileName = doctor.Photo;
            }
        }

        private void EditDoctor()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string email = TxtBxEmail.Text;
            string phone = TxtBxPhone.Text;
            string identification = TxtBxIdentification.Text;
            string photo = PbDoctor.ImageLocation;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email)
                || !TxtBxPhone.MaskCompleted || !TxtBxIdentification.MaskCompleted || String.IsNullOrEmpty(photo))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Doctor updatedDoctor = new Doctor()
                {
                    Id = (int)DoctorRepository.Instance.IdSelectedDoctor,
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Phone = phone,
                    Identification = identification,
                };

                bool result = _doctorService.Edit(updatedDoctor);

                if (result)
                {
                    SavePhoto();

                    DialogResult response = MessageBox.Show("Doctor edited successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem editing the doctor, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseForm()
        {
            DoctorRepository.Instance.IdSelectedDoctor = null;
            this.Close();
        }

        #endregion
    }
}
