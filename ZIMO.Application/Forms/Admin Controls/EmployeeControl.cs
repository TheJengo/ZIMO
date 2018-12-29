using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.Admin_Controls
{
    public partial class EmployeeControl : UserControl
    {
        private IAdminController userController;

        public EmployeeControl()
        {
            InitializeComponent();
        }

        public void SetAuthorization(IAdminController userController)
        {
            this.userController = userController;
            InitializeDetails();
        }

        private IList<User> Users;
        private IList<Department> Departments;
        private IList<Role> Roles;

        private void InitializeDetails()
        {
            ClearManageUserTextboxes();

            Users = userController.GetAllUsers(true);
            Departments = userController.GetDepartments();
            Roles = userController.GetRoles();
            ListUtil.InitializeDropdownList(dropManageEmployeeDepartment, Departments);
            ListUtil.InitializeDropdownList(dropManageEmployeeRole, Roles);

            selectedUserIndex = -1;
            ListUtil.InitializeListView(mlvUsers, Users);

            tbcEmployee.SelectedTab = tbpSearchEmployee;
            tbpManageEmployee.Text = "Add Employee";
            btnManageEmployeeSubmit.BringToFront();
        }

        /* Manage Users */
        /// <summary>
        /// Managing users who selected on the list and selection operation
        /// </summary>
        private int selectedUserIndex = -1;

        private User selectedUser;
        private bool withPassives = true;

        private void mlvUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedUserIndex = mlvUsers.FocusedItem.Index;
                selectedUser = Users.ElementAt(selectedUserIndex);

                btnManageEmployeeDelete.Text = "DELETE";
                btnManageEmployeeUpdate.BringToFront();

                txtManageEmployeeUsername.Text = selectedUser.Username;
                txtManageEmployeeUsername.Enabled = false;

                txtManageEmployeeFirstName.Text = selectedUser.Employee.FirstName;
                txtManageEmployeeLastName.Text = selectedUser.Employee.LastName;
                txtManageEmployeePassword.Text = "password";
                txtManageEmployeeConfirmPassword.Text = "password";
                txtManageEmployeeAvatarPath.Text = selectedUser.Employee.Avatar;
                dropManageEmployeeDepartment.selectedIndex =
                    Departments.IndexOf(Departments.First(x => x.Name == selectedUser.Department.Name));
                dropManageEmployeeRole.selectedIndex =
                    Roles.IndexOf(Roles.First(x => x.Name == selectedUser.Role.Name));
                dropManageEmployeeActivity.selectedIndex = selectedUser.IsActive ? 0 : 1;
                
                tbcEmployee.SelectedTab = tbpManageEmployee;
                tbpManageEmployee.Text = "Update Employee";
            }
        }

        // Checks search employee textbox values
        private void txtSearchEmployee_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = txtSearchEmployee.MaximumLength(200);
            dropEmployeeSearchKey_onItemSelected(this, e);
        }

        // Search By parameters after selected from dropdown list
        private void dropEmployeeSearchKey_onItemSelected(object sender, EventArgs e)
        {
            string searchVal = txtSearchEmployee.Text.ToLower();
            Users = userController.GetAllUsers(withPassives);
            switch (dropEmployeeSearchKey.selectedIndex)
            {
                case 0:
                    Users = Users.Where(x => x.Username.ToLower().Contains(searchVal)).ToList();
                    break;
                case 1:
                    Users = Users.Where(x => x.Employee.FirstName.ToLower().Contains(searchVal)).ToList();
                    break;
                case 2:
                    Users = Users.Where(x => x.Employee.LastName.ToLower().Contains(searchVal)).ToList();
                    break;
                case 3:
                    Users = Users.Where(x => x.Department.Name.ToLower().Contains(searchVal)).ToList();
                    break;
                case 4:
                    Users = Users.Where(x => x.Role.Name.ToLower().Contains(searchVal)).ToList();
                    break;
                default:
                    Users = Users.Where(x => x.Username.ToLower().Contains(searchVal)).ToList();
                    break;
            }

            ListUtil.InitializeListView(mlvUsers, Users);
        }

        // When user clicks tabs in the tab control it prepares tab content for operations
        private void tbsEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbcEmployee.SelectedTab == tbpManageEmployee)
            {
                btnManageEmployeeDelete.Text = "RESET";
                btnManageEmployeeDelete_Click(this, e);
                btnManageEmployeeSubmit.BringToFront();
                txtManageEmployeeUsername.Enabled = true;
                selectedUserIndex = -1;

                tbpManageEmployee.Text = "Add Employee";
            }

            if (tbcEmployee.SelectedTab == tbpSearchEmployee)
            {
                ListUtil.InitializeListView(mlvUsers, Users);
                InitializeDetails();
            }

            pnlManageFailAlert.Visible = false;
            pnlManageSuccessfulAlert.Visible = false;
        }

        // Delete/Reset Button for managing selected user 
        private void btnManageEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (btnManageEmployeeDelete.Text == "DELETE")
            {
                userController.ManageUser(selectedUser, EntityState.Deleted);

                AnimationUtil.HideSync(pnlManageFailAlert);
                AnimationUtil.ShowSync(pnlManageSuccessfulAlert);
            }

            if (btnManageEmployeeDelete.Text == "RESET")
            {
                ClearManageUserTextboxes();
            }
        }

        private void ClearManageUserTextboxes()
        {
            txtManageEmployeeUsername.Text = "";
            txtManageEmployeePassword.Text = "password";
            txtManageEmployeeConfirmPassword.Text = "password";
            txtManageEmployeeFirstName.Text = "";
            txtManageEmployeeLastName.Text = "";
            txtManageEmployeeAvatarPath.Text = "";
            txtSearchEmployee.Text = "";
        }

        private bool isPassFieldChanged = false;

        private void btnManageEmployeeSubmit_Click(object sender, EventArgs e)
        {
            if (TextUtil.IsNull(txtManageEmployeeUsername.Text) || Users.FirstOrDefault(x =>
                    x.Username.ToLower().Equals(txtManageEmployeeUsername.Text.ToLower())) != null)
            {
                ShowFailAlert();
                return;
            }
            if (txtManageEmployeePassword.Text != txtManageEmployeeConfirmPassword.Text &&
                     !isPassFieldChanged)
            {
                ShowFailAlert();
                return;
            }
            if ((TextUtil.IsNull(txtManageEmployeeFirstName.Text) || 
                      TextUtil.IsNull(txtManageEmployeeLastName.Text) ||
                      TextUtil.IsNull(txtManageEmployeeAvatarPath.Text)))
            {
                ShowFailAlert();
                return;
            }

            if (!(TextUtil.IsOnlyLetters(txtManageEmployeeFirstName.Text) &&
                TextUtil.IsOnlyLetters(txtManageEmployeeFirstName.Text)))
            {
                ShowFailAlert();
                return;
            }
            if (!TextUtil.IsEmail(txtManageEmployeeUsername.Text) ||
                !txtManageEmployeeAvatarPath.Text.StartsWith("Avatars"))
            {
                ShowFailAlert();
                return;
            }
            var user = new User
            {
                Username = txtManageEmployeeUsername.Text,
                Password = txtManageEmployeePassword.Text,
                Employee = new Employee
                {
                    Avatar = txtManageEmployeeAvatarPath.Text,
                    FirstName = txtManageEmployeeFirstName.Text,
                    LastName = txtManageEmployeeLastName.Text,
                    EntityState = EntityState.Added
                },
                Department_Id = Departments.ElementAt(dropManageEmployeeDepartment.selectedIndex).Id,
                Role_Id = Roles.ElementAt(dropManageEmployeeRole.selectedIndex).Id,
                IsActive = dropManageEmployeeActivity.selectedIndex == 0 ? true : false
            };

            userController.ManageUser(user, EntityState.Added);

            AnimationUtil.HideSync(pnlManageFailAlert);
            AnimationUtil.ShowSync(pnlManageSuccessfulAlert);

            InitializeDetails();
        }

        private void ShowFailAlert()
        {
            AnimationUtil.HideSync(pnlManageSuccessfulAlert);
            AnimationUtil.ShowSync(pnlManageFailAlert);
        }

        // If checkbox selected updates withPassives variable
        private void cboxIsActive_OnChange(object sender, EventArgs e)
        {
            if (cboxEmployeeSearchIsActive.Checked)
                withPassives = true;
            else
                withPassives = false;

            dropEmployeeSearchKey_onItemSelected(this, e);
        }

        // Toggle Employee Is Active checkbox
        private void lblSearchEmployeeContainPassives_Click(object sender, EventArgs e)
        {
            if (cboxEmployeeSearchIsActive.Checked)
                cboxEmployeeSearchIsActive.Checked = false;
            else
                cboxEmployeeSearchIsActive.Checked = true;

            cboxIsActive_OnChange(this, e);
        }

        // Check does any changes happened in password field
        private void txtManageEmployeePassword_OnValueChanged(object sender, EventArgs e)
        {
            txtManageEmployeePassword.Text = txtManageEmployeePassword.MaximumLength(150);
            txtManageEmployeeConfirmPassword.Text = txtManageEmployeeConfirmPassword.MaximumLength(150);
            isPassFieldChanged = true;
            if ((txtManageEmployeePassword.Text == "password" && txtManageEmployeeConfirmPassword.Text == "password") || (TextUtil.IsNull(txtManageEmployeePassword.Text) && TextUtil.IsNull(txtManageEmployeeConfirmPassword.Text)))
            {
                isPassFieldChanged = false;
            }
        }

        // Open File Dialog for instance of image
        private void btnManageOpenFileDialog_Click(object sender, EventArgs e)
        {
            FileUtil.OpenFileDialog(txtManageEmployeeAvatarPath);
        }

        // Check Textbox Length
        private void txtManageEmployeeUsername_OnValueChanged(object sender, EventArgs e)
        {
            txtManageEmployeeUsername.Text = txtManageEmployeeUsername.MaximumLength(200);
        }

        // Check Textbox Length
        private void txtManageEmployeeFirstName_OnValueChanged(object sender, EventArgs e)
        {
            txtManageEmployeeFirstName.Text = txtManageEmployeeFirstName.MaximumLength(50);
        }

        // Check Textbox Length
        private void txtManageEmployeeLastName_OnValueChanged(object sender, EventArgs e)
        {
            txtManageEmployeeLastName.Text = txtManageEmployeeLastName.MaximumLength(50);
        }

        // Check Textbox Length
        private void txtManageEmployeeAvatarPath_OnValueChanged(object sender, EventArgs e)
        {
            txtManageEmployeeAvatarPath.Text = txtManageEmployeeAvatarPath.MaximumLength(200);
        }

        private void btnManageEmployeeUpdate_Click(object sender, EventArgs e)
        {
            bool checkNulls = TextUtil.IsNull(txtManageEmployeeUsername.Text) ||
                              TextUtil.IsNull(txtManageEmployeeFirstName.Text) ||
                              TextUtil.IsNull(txtManageEmployeeLastName.Text) ||
                              TextUtil.IsNull(txtManageEmployeeAvatarPath.Text);

            if (!TextUtil.IsEmail(txtManageEmployeeUsername.Text) &&
                !txtManageEmployeeAvatarPath.Text.StartsWith("Avatars"))
            {
                ShowFailAlert();
                return;
            }

            if (txtManageEmployeePassword.Text == txtManageEmployeeConfirmPassword.Text &&
                isPassFieldChanged)
            {
                selectedUser.Password = txtManageEmployeePassword.Text;
            }
            if(txtManageEmployeePassword.Text != txtManageEmployeeConfirmPassword.Text )
            {
                ShowFailAlert();
                return;
            }

            if (checkNulls)
            {
                ShowFailAlert();
                return;
            }

            if (!(TextUtil.IsOnlyLetters(txtManageEmployeeFirstName.Text) &&
                  TextUtil.IsOnlyLetters(txtManageEmployeeFirstName.Text)))
            {
                ShowFailAlert();
                return;
            }

            selectedUser.Employee.FirstName = txtManageEmployeeFirstName.Text;
            selectedUser.Employee.LastName = txtManageEmployeeLastName.Text;
            selectedUser.Employee.Avatar = txtManageEmployeeAvatarPath.Text;
            selectedUser.Department_Id = Departments.ElementAt(dropManageEmployeeDepartment.selectedIndex).Id;
            selectedUser.Role_Id = Roles.ElementAt(dropManageEmployeeRole.selectedIndex).Id;
            selectedUser.Employee_Id = selectedUser.Employee.User_Id;
            selectedUser.IsActive = (dropManageEmployeeActivity.selectedIndex == 0) ? true : false;

            userController.ManageUser(selectedUser, EntityState.Modified);

            AnimationUtil.HideSync(pnlManageFailAlert);
            AnimationUtil.ShowSync(pnlManageSuccessfulAlert);
            
            InitializeDetails();
        }
    }
}
    