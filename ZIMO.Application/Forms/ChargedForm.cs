using System;
using System.Windows.Forms;
using ZIMO.App.Utils;
using ZIMO.BLL.Login_Operations;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms
{
    public partial class ChargedForm : Form
    {
        private User _activeUser;
        private ISalesController userController;

        public ChargedForm()
        {
            // initializing bussines layer components
            userController = new SalesController();
            _activeUser = userController.GetUser();
            InitializeComponent();

            AnimationUtil.Animator = animSlider;
            AnimationUtil.SlidedControls.Add(ctrlSettings);
            AnimationUtil.SlidedControls.Add(ctrlReports);
            
            MenuUtil.InitializeMenuItems(_activeUser, lblMenuAvatarName, lblMenuDepartmentInfo, lblMenuRoleInfo,
                pboxAvatar);
        }

        /* Reports */
        private void btnMenuReports_Click(object sender, EventArgs e)
        {
            ctrlReports.SetAuthorization(userController, false);
            AnimationUtil.ShowSync(ctrlReports);
        }

        /*   SETTINGS   */
        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            ctrlSettings.SetAuthorization(userController);
            AnimationUtil.ShowSync(ctrlSettings);
        }

        /*   LOGOUT  */
        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            ILoginController loginController = new LoginController();
            loginController.LogoutUser();
            this.Close();
        }
    }
}
