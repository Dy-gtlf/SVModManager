using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVModManager
{
    public partial class ModInfoForm : Form
    {
        public ModInfo modInfo = new ModInfo();

        public ModInfoForm(string path)
        {
            InitializeComponent();
            modFolder.Text = path;
            modName.Text = Path.GetFileName(path);
        }

        private void ModFolderButton_Click(object sender, EventArgs e)
        {
            // フォルダ選択ダイアログを表示
            var fbd = new FolderBrowserDialog
            {
                Description = "Modのフォルダを指定してください。",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = @"C:\Windows",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                modFolder.Text = fbd.SelectedPath;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (modName.Text == "")
            {
                MessageBox.Show("Mod名を記入してください。");
                return;
            }
            if (modFolder.Text == "")
            {
                MessageBox.Show("Modのフォルダを指定してください。");
                return;
            }
            modInfo.ModName = modName.Text;
            modInfo.ModFolder = modFolder.Text;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            modInfo = null;
            Close();
        }

        static public ModInfo ShowModInfoForm(string path)
        {
            var modInfoForm = new ModInfoForm(path);
            modInfoForm.ShowDialog();
            var modInfo = modInfoForm.modInfo;
            return modInfo;
        }
    }
}
