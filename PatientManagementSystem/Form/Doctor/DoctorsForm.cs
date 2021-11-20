using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class DoctorsForm : Form
    {
        public static DoctorsForm Instance { get; } = new DoctorsForm();

        private DoctorService _doctorService;

        public DoctorsForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _doctorService = new DoctorService(connection);
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

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();

            DoctorRepository.Instance.IdSelectedDoctor = null;
        }

        private void DoctorsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void DoctorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }

        private void DgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DoctorRepository.Instance.IdSelectedDoctor = Convert.ToInt32(DgvDoctors.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteDoctor();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadDoctors()
        {
            DgvDoctors.DataSource = _doctorService.GetAll();
            DgvDoctors.ClearSelection();
        }

        private void AddDoctor()
        {
            DoctorRepository.Instance.IdSelectedDoctor = null;

            AddDoctorForm newAddDoctorForm = new AddDoctorForm();
            newAddDoctorForm.Show();
            this.Hide();
        }

        private void EditDoctor()
        {
            if (DoctorRepository.Instance.IdSelectedDoctor != null)
            {
                AddDoctorForm newAddDoctorForm = new AddDoctorForm();
                newAddDoctorForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a doctor.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteDoctor()
        {
            if (DoctorRepository.Instance.IdSelectedDoctor != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this doctor?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.OK)
                {
                    bool result = _doctorService.Delete((int)DoctorRepository.Instance.IdSelectedDoctor);

                    if (result)
                    {
                        MessageBox.Show("Doctor deleted successfully.", "Notification!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDoctors();
                }
                else
                {
                    DgvDoctors.ClearSelection();
                    DoctorRepository.Instance.IdSelectedDoctor= null;
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            DoctorRepository.Instance.IdSelectedDoctor = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
