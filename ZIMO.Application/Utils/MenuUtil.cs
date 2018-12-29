using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Utils
{
    public static class MenuUtil
    {
        public static void InitializeMenuItems(User _activeUser, Label lblMenuAvatarName, Label lblMenuDepartmentInfo, Label lblMenuRoleInfo, PictureBox pboxAvatar)
        {
            // initializing menu informations
            if (Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Assets", _activeUser.Employee.Avatar)) != null)
                pboxAvatar.Image =
                    Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Assets", _activeUser.Employee.Avatar));
            lblMenuAvatarName.Text = _activeUser.Employee.FirstName + " " + _activeUser.Employee.LastName;
            AlignCenter(lblMenuAvatarName, 250);
            lblMenuDepartmentInfo.Text = _activeUser.Department.Name + ", ";
            lblMenuRoleInfo.Text = _activeUser.Role.Name;
            AlignCenter(lblMenuAvatarName, 250);
            AlignCenter(lblMenuDepartmentInfo, 250);
            AlignCenter(lblMenuRoleInfo, 250);
        }


        // Helper method for aligning labels
        private static void AlignCenter(Label label, int maxLength)
        {
            label.Location = new Point((maxLength - label.Width) / 2, label.Location.Y);
        }
    }
}
