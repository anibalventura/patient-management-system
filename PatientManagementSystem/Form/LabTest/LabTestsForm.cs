using BusinessLayer.Repository;
using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LabTestsForm : Form
    {
        public static LabTestsForm Instance { get; } = new LabTestsForm();

        private LabTestService _labTestService;

        public LabTestsForm()
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

        private void LabTestsForm_Load(object sender, EventArgs e)
        {
            LoadLabTests();

            LabTestRepository.Instance.IdSelectedLabTest = null;
        }

        private void LabTestsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadLabTests();
        }

        private void LabTestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddLabTest();
        }

        private void DgvLabTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LabTestRepository.Instance.IdSelectedLabTest = Convert.ToInt32(DgvLabTests.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditLabTest();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteLabTest();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadLabTests()
        {
            DgvLabTests.DataSource = _labTestService.GetAllPending();
            DgvLabTests.ClearSelection();
        }

        private void AddLabTest()
        {
            LabTestRepository.Instance.IdSelectedLabTest = null;

            AddLabTestForm newAddLabTestForm = new AddLabTestForm();
            newAddLabTestForm.Show();
            this.Hide();
        }

        private void EditLabTest()
        {
            if (LabTestRepository.Instance.IdSelectedLabTest != null)
            {
                AddLabTestForm newAddLabTestForm = new AddLabTestForm();
                newAddLabTestForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a lab test.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteLabTest()
        {
            if (LabTestRepository.Instance.IdSelectedLabTest != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this lab test?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.OK)
                {
                    bool result = _labTestService.Delete((int)LabTestRepository.Instance.IdSelectedLabTest);

                    if (result)
                    {
                        MessageBox.Show("Lab test deleted successfully.", "Notification!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadLabTests();
                    LabTestRepository.Instance.IdSelectedLabTest = null;
                }
                else
                {
                    DgvLabTests.ClearSelection();
                    LabTestRepository.Instance.IdSelectedLabTest = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a Lab test.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            LabTestRepository.Instance.IdSelectedLabTest = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
