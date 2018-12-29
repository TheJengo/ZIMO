using System;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.Login_Operations;

namespace ZIMO.App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When you click it closes the login form and exits the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When you click it minimizes the login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// This methods starts the login process and draws an output on the screen after it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ILoginController loginController = new LoginController();
            if (txtPassword.Text.Length > 3  && txtUsername.Text.Length > 3 && TextUtil.IsEmail(txtUsername.Text) && loginController.LoginUser(txtUsername.Text, txtPassword.Text))
            {
                    lblFailAlert.Visible = false;
                    lblSuccessAlert.Visible = true;
                    
                    switch (loginController.GetLoginType())
                    {
                        case 1:
                            // Pop-up admin form
                            this.Hide();
                            AdminForm adminForm = new AdminForm();
                            adminForm.ShowDialog();
                            Application.Restart();
                            break;
                        case 2:
                            // Pop-up Sales Manager form
                            this.Hide();
                            SalesForm salesForm = new SalesForm();
                            salesForm.ShowDialog();
                            Application.Restart();
                        break;
                        case 3:
                            // Pop-up Charged Employee form
                            this.Hide();
                            ChargedForm chargedForm = new ChargedForm();
                            chargedForm.ShowDialog();
                            Application.Restart();
                        break;
                        default:
                            lblSuccessAlert.Visible = false;
                            lblFailAlert.Visible = true;
                            break;
                    }
                }
            else
            {
                lblSuccessAlert.Visible = false;
                lblFailAlert.Visible = true;
            }
        }
        /// <summary>
        /// This method avoids user from input values bigger than normal sizes for username text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.MaximumLength(200);
        }
        /// <summary>
        /// This method avoids user from input values bigger than normal sizes for password text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.MaximumLength(150);
            txtPassword.Text = TextUtil.PasswordFieldManager(txtPassword.Text);
        }

        /// <summary>
        /// Better UX. The best key down event hit enter after filled your password box :D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this,e);
            }
        }
    }
}
