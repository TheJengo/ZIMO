using System;
using System.Windows.Forms;
using ZIMO.App.Utils;
using ZIMO.BLL.Login_Operations;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms
{
    public partial class AdminForm : Form
    {
        private User _activeUser;
        private IAdminController userController;
        public AdminForm()
        {
            // initializing bussines layer components
            userController = new AdminController();
            _activeUser = userController.GetUser();

            InitializeComponent();

            AnimationUtil.Animator = animSlider;
            AnimationUtil.SlidedControls.Add(ctrlEmployees);
            AnimationUtil.SlidedControls.Add(ctrlDepartments);
            AnimationUtil.SlidedControls.Add(ctrlItems);
            AnimationUtil.SlidedControls.Add(ctrlStocks);
            AnimationUtil.SlidedControls.Add(ctrlGarbages);
            AnimationUtil.SlidedControls.Add(ctrlSettings);
            AnimationUtil.SlidedControls.Add(ctrlReports);

            MenuUtil.InitializeMenuItems(_activeUser, lblMenuAvatarName, lblMenuDepartmentInfo, lblMenuRoleInfo,
                pboxAvatar);
        }

        /* MENU ITEMS */
        private void btnMenuManageEmployees_Click(object sender, EventArgs e)
        {
            ctrlEmployees.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlEmployees);
        }

        /* Manage Departments */
        /// <summary>
        /// Manage Department Menu button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuManageDepartments_Click(object sender, EventArgs e)
        {
            ctrlDepartments.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlDepartments);
        }

        /* MANAGE ITEMS */
        private void btnMenuManageItems_Click(object sender, EventArgs e)
        {
            ctrlItems.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlItems);
        }
        
        /* MANAGE STOCKS AND ITEMS */
        private void btnMenuStockItems_Click(object sender, EventArgs e)
        {
            ctrlStocks.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlStocks);
        }

        /*   MANAGE GARBAGE   */
        private void btnMenuManageGarbageItems_Click(object sender, EventArgs e)
        {
           ctrlGarbages.SetAuthorization(userController);
           AnimationUtil.ShowSync(ctrlGarbages);
        }

        /* Reports */
        private void btnMenuReports_Click(object sender, EventArgs e)
        {
            ctrlReports.SetAuthorization(userController, true);
            AnimationUtil.ShowSync(ctrlReports);
        }

        /*   SETTINGS   */
        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            ctrlSettings.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlSettings);
        }

        /* LOGOUT  */
        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            ILoginController loginController = new LoginController();
            loginController.LogoutUser();
            this.Close();
        }
    }
}
