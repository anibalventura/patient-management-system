using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddLabTestForm : Form
    {
        public AddLabTestForm()
        {
            InitializeComponent();
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
            CloseForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void AddLabTest()
        {

        }

        private void LoadLabTestToEdit()
        {

        }

        private void EditLabTest()
        {

        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}
