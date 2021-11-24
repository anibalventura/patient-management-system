using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddLabTestForm : Form
    {
        private LabTestService _labTestService;

        public AddLabTestForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _labTestService = new LabTestService(connection);
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

        private void AddLabTestForm_Load(object sender, EventArgs e)
        {
            LoadLabTestToEdit();
        }

        private void AddLabTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LabTestsForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LabTestRepository.Instance.IdSelectedLabTest != null)
            {
                EditLabTest();
            }
            else
            {
                AddLabTest();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void AddLabTest()
        {
            string name = TxtBxTestName.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = _labTestService.Add(new LabTest()
                {
                    Name = name,
                });

                if (result)
                {
                    DialogResult response = MessageBox.Show("Lab test created successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the lab test, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadLabTestToEdit()
        {
            if (LabTestRepository.Instance.IdSelectedLabTest != null)
            {
                LabTest labTest = _labTestService.GetById((int)LabTestRepository.Instance.IdSelectedLabTest);

                TxtBxTestName.Text = labTest.Name;
            }
        }

        private void EditLabTest()
        {
            string name = TxtBxTestName.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = _labTestService.Edit(new LabTest()
                {
                    Id = (int)LabTestRepository.Instance.IdSelectedLabTest,
                    Name = name,
                });

                if (result)
                {
                    DialogResult response = MessageBox.Show("Lab test edited successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem editing the lab test, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseForm()
        {
            LabTestRepository.Instance.IdSelectedLabTest = null;

            this.Close();
        }

        #endregion
    }
}
