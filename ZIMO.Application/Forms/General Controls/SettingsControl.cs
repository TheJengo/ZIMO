using System;
using System.Linq;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.General_Controls
{
    public partial class SettingsControl : UserControl
    {
        private User _activeUser;
        private IUserController userController;
        private bool isPassFieldChanged = false;

        public SettingsControl()
        {
            InitializeComponent();
        }

        // Set userController informations and start the controller UI
        public void SetAuthorization(IUserController userController)
        {
            this.userController = userController;
            _activeUser = userController.GetUser();
            InitializeDetails();
        }

        private void InitializeDetails()
        {
            txtUserSettingsUserName.Text = _activeUser.Username;
            txtUserSettingsPassword.Text = "password";
            txtUserSettingsConfirmPassword.Text = "password";
            txtUserSettingsFirstName.Text = _activeUser.Employee.FirstName;
            txtUserSettingsLastName.Text = _activeUser.Employee.LastName;
            txtUserSettingsAvatar.Text = _activeUser.Employee.Avatar;
            lblUserSettingsBorrowQuantity.Text = _activeUser.Borrows.Sum(x => x.Quantity).ToString();

            AnimationUtil.HideSync(pnlActiveUserUpdateFailAlert);
            AnimationUtil.HideSync(pnlActiveUserUpdateSuccessfulAlert);
            isPassFieldChanged = true;
        }

        // Update User
        private void btnUpdateActiveUser_Click(object sender, EventArgs e)
        {
            if (isPassFieldChanged && txtUserSettingsAvatar.Text.StartsWith("Avatars") &&
                !TextUtil.IsNull(txtUserSettingsPassword.Text) && !TextUtil.IsNull(txtUserSettingsConfirmPassword.Text) &&
                txtUserSettingsConfirmPassword.Text == txtUserSettingsPassword.Text)
            {
                if (txtUserSettingsPassword.Text != "password")
                {
                    _activeUser.Password = txtUserSettingsPassword.Text;
                }

                _activeUser.Employee.Avatar = txtUserSettingsAvatar.Text;
                userController.UpdateUser(_activeUser);

                AnimationUtil.HideSync(pnlActiveUserUpdateFailAlert);
                AnimationUtil.ShowSync(pnlActiveUserUpdateSuccessfulAlert);
            }
            else
            {
                AnimationUtil.HideSync(pnlActiveUserUpdateSuccessfulAlert);
                AnimationUtil.ShowSync(pnlActiveUserUpdateFailAlert);
            }
        }

        // Manage password textbox operations
        private void txtUserSettingsPassword_OnValueChanged(object sender, EventArgs e)

        {
            txtUserSettingsPassword.Text = TextUtil.PasswordFieldManager(txtUserSettingsPassword.Text);
            txtUserSettingsConfirmPassword.Text = TextUtil.PasswordFieldManager(txtUserSettingsConfirmPassword.Text);

            txtUserSettingsPassword.Text = txtUserSettingsPassword.MaximumLength(150);
            txtUserSettingsConfirmPassword.Text = txtUserSettingsConfirmPassword.MaximumLength(150);
            if (txtUserSettingsPassword.Text != "password" && txtUserSettingsConfirmPassword.Text != "password" && txtUserSettingsPassword.Text != "" && txtUserSettingsConfirmPassword.Text != "")
            {
                isPassFieldChanged = true;
            }
            else
            {
                isPassFieldChanged = false;
            }
        }

        // File Operations
        private void btnUserAvatarPath_Click(object sender, EventArgs e)
        {
            FileUtil.OpenFileDialog(txtUserSettingsAvatar);
        }

        //Checks Textbox Lengths
        private void txtUserSettingsFirstName_OnValueChanged(object sender, EventArgs e)
        {
            txtUserSettingsFirstName.Text = txtUserSettingsFirstName.MaximumLength(50);
        }

        //Checks Textbox Lengths
        private void txtUserSettingsLastName_OnValueChanged(object sender, EventArgs e)
        {
            txtUserSettingsLastName.Text = txtUserSettingsLastName.MaximumLength(50);
        }

        //Checks Textbox Lengths
        private void txtUserSettingsAvatar_OnValueChanged(object sender, EventArgs e)
        {
            txtUserSettingsAvatar.Text = txtUserSettingsAvatar.MaximumLength(200);
        }
    }
}
