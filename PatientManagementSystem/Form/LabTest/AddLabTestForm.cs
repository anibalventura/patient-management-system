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
