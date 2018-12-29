using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIMO.App.Extensions
{
    public static class TextboxExtension
    {
        /// <summary>
        /// Check length of the string and take desired max length sub string and return the latest value if its necessary.
        /// </summary>
        /// <param name="txt">Textbox Object</param>
        /// <param name="Length">Desired Length</param>
        /// <returns>Trimmed string</returns>
        public static string MaximumLength(this Bunifu.Framework.UI.BunifuMaterialTextbox txt, int Length)
        {
            return (txt.Text.Length > Length) ? txt.Text.Substring(0, Length) : txt.Text;
        }
    }
}
