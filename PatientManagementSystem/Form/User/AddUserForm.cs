using BusinessLayer.Repository;
using BusinessLayer.Service;
using Database.Model;
using PatientManagementSystem.CustomControlItem;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientManagementSystem
{
    public partial class AddUserForm : Form
    {
        private UserService _userService;
        private UserTypeService _userTypeService;

        public AddUserForm()
        {
            InitializeComponent();

            // Init SQL connection.
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _userService = new UserService(connection);
            _userTypeService = new UserTypeService(connection);
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

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadUserToEdit();
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsersForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (UserRepository.Instance.IdSelectedUser != null)
            {
                EditUser();
            }
            else
            {
                AddUser();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void LoadComboBox()
        {
            ComboBoxItem defaultOption = new ComboBoxItem
            {
                Text = "Select an option",
                Value = null
            };

            CbxUserType.Items.Add(defaultOption);

            List<UserType> userList = _userTypeService.GetList();

            foreach (UserType userType in userList)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = userType.Name,
                    Value = userType.Id
                };

                CbxUserType.Items.Add(newItem);
            }

            CbxUserType.SelectedItem = defaultOption;
        }

        private void AddUser()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string email = TxtBxEmail.Text;
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;
            string confirmPassword = TxtBxConfirmPassword.Text;
            ComboBoxItem userType = CbxUserType.SelectedItem as ComboBoxItem;

            bool userCreated = _userService.CheckUsername(username);

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(username)
                || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword) || userType.Value == null)
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userCreated)
            {
                MessageBox.Show("Username is registered, please use another username", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords are not the same.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User newUser = new User()
                {
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Username = username,
                    Password = password,
                    IdUserType = (int)userType.Value,
                };

                bool result = _userService.Add(newUser);

                if (result)
                {
                    DialogResult response = MessageBox.Show("User created successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the user, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUserToEdit()
        {
            if (UserRepository.Instance.IdSelectedUser != null)
            {
                User user = _userService.GetById((int)UserRepository.Instance.IdSelectedUser);

                TxtBxName.Text = user.Name;
                TxtBxLastName.Text = user.LastName;
                TxtBxEmail.Text = user.Email;
                TxtBxUsername.Text = user.Username;
                TxtBxPassword.Text = user.Password;
                TxtBxConfirmPassword.Text = user.Password;
                CbxUserType.SelectedIndex = CbxUserType.FindStringExact(user.UserType);

                TxtBxUsername.Enabled = false;
            }
        }

        private void EditUser()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string email = TxtBxEmail.Text;
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;
            string confirmPassword = TxtBxConfirmPassword.Text;
            ComboBoxItem userType = CbxUserType.SelectedItem as ComboBoxItem;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(username)
                || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword) || userType.Value == null)
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords are not the same.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User updatedUser = new User()
                {
                    Id = (int)UserRepository.Instance.IdSelectedUser,
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Username = username,
                    Password = password,
                    IdUserType = (int)userType.Value,
                };

                bool result = _userService.Edit(updatedUser);

                if (result)
                {
                    DialogResult response = MessageBox.Show("User edited successfully.", "Notification!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem editing the user, try again later.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseForm()
        {
            UserRepository.Instance.IdSelectedUser = null;
            this.Close();
        }

        #endregion
    }
}
