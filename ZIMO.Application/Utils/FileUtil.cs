using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIMO.App.Utils
{
    public static class FileUtil
    {
        /// <summary>
        /// Opens a file dialog to get user avatar infos to set textbox text 
        /// </summary>
        /// <param name="textBox">Textbox Control</param>
        public static void OpenFileDialog(Bunifu.Framework.UI.BunifuMaterialTextbox textBox)
        {
            OpenFileDialog ofdPicturePath = new OpenFileDialog();

            ofdPicturePath.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory+"Assets\\Avatars";
            ofdPicturePath.Filter = "Image Files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            ofdPicturePath.FilterIndex = 0;
            ofdPicturePath.RestoreDirectory = true;

            if (ofdPicturePath.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = ofdPicturePath.FileName;
                string[] selectedName = selectedFileName.Split(new string[] { "Assets\\" }, StringSplitOptions.None);
                textBox.Text = selectedName[selectedName.Length - 1];
            }
        }

        /// <summary>
        /// Returns Files in Report directory
        /// </summary>
        /// <returns>FileInfo List</returns>
        public static IList<FileInfo> GetFileList()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\Reports");
            Console.WriteLine(dirInfo.Attributes);
            IList<FileInfo> fileNames = dirInfo.GetFiles("*.pdf");
            return fileNames.ToList();
        }
    }
}
