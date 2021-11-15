using System;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class LabTestsForm : Form
    {
        public static LabTestsForm Instance { get; } = new LabTestsForm();

        public LabTestsForm()
        {
            InitializeComponent();
        }

        #region Events

        private void LabTestsForm_Load(object sender, EventArgs e)
        {
            LoadLabTests();
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

        }

        private void AddLabTest()
        {
            AddLabTestForm newAddLabTestForm = new AddLabTestForm();
            newAddLabTestForm.Show();
            this.Hide();
        }

        private void EditLabTest()
        {
            AddLabTestForm newAddLabTestForm = new AddLabTestForm();
            newAddLabTestForm.Show();
            this.Hide();
        }

        private void DeleteLabTest()
        {

        }

        private void CloseForm()
        {
            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
