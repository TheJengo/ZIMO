using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIMO.App.Utils
{
    public static class AnimationUtil
    {
        public static BunifuAnimatorNS.BunifuTransition Animator;
        public static IList<Control> SlidedControls = new List<Control>();

        /// <summary>
        /// Hides all UI controls in SlidedControls
        /// </summary>
        private static void HideAll()
        {
            foreach (var control in SlidedControls)
            {
                if(control != null && control.Visible)
                    HideSync(control);
            }
        }

        /// <summary>
        /// Shows the given control. If its part of SlidedControls other controls will hide.
        /// </summary>
        /// <param name="control">UI Control Object</param>
        public static void ShowSync(Control control)
        {
            if(SlidedControls.Contains(control))
                HideAll();
            if(!control.Visible)
                Animator.ShowSync(control);
        }

        /// <summary>
        /// It hides the given UI control
        /// </summary>
        /// <param name="control">UI Control Object</param>
        public static void HideSync(Control control)
        {
            Animator.HideSync(control);
        }
    }
}
