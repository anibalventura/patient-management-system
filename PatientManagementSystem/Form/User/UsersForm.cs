using BusinessLayer.Service;
using BusinessLayer.Repository;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class UsersForm : Form
    {
        public static UsersForm Instance { get; } = new UsersForm();

        private UserService _userService;

        public UsersForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _userService = new UserService(connection);
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

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();

            UserRepository.Instance.IdSelectedUser = null;
        }

        private void UsersForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.Instance.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserRepository.Instance.IdSelectedUser = Convert.ToInt32(DgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadUsers()
        {
            DgvUsers.DataSource = _userService.GetAll();
            DgvUsers.ClearSelection();
        }

        private void AddUser()
        {
            AddUserForm newAddUserForm = new AddUserForm();
            newAddUserForm.Show();
            this.Hide();
        }

        private void EditUser()
        {
            if (UserRepository.Instance.IdSelectedUser != null)
            {
                AddUserForm newAddUserForm = new AddUserForm();
                newAddUserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a user.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteUser()
        {
            if (UserRepository.Instance.IdSelectedUser != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this user?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.OK)
                {
                    bool result = _userService.Delete((int)UserRepository.Instance.IdSelectedUser);

                    if (result)
                    {
                        MessageBox.Show("User deleted successfully.", "Notification!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadUsers();
                }
                else
                {
                    DgvUsers.ClearSelection();
                    UserRepository.Instance.IdSelectedUser = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a user.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseForm()
        {
            UserRepository.Instance.IdSelectedUser = null;

            HomeForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}
