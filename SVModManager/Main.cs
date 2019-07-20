using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVModManager
{
    public partial class Main : Form
    {
        private ModList modList;
        public Main()
        {
            InitializeComponent();
            //最大サイズと最小サイズを現在のサイズに設定する
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Mod適用先フォルダ
            gameFolder.Text = Properties.Settings.Default.GameDirectory;
            // Modリストの復元
            modList = XmlHelper.Deserialize<ModList>(@"ModList.xml");
            if (modList == null)
            {
                MessageBox.Show("ModList.xmlが見つかりませんでした。\n新規作成します。");
                XmlHelper.Serialize("ModList.xml", new ModList());
                modList = XmlHelper.Deserialize<ModList>(@"ModList.xml");
            }
            foreach (var mod in modList.ModInfo)
            {
                string[] info = { "", mod.ModName, mod.ModFolder };
                var item = new ListViewItem(info)
                {
                    Checked = mod.ModActivation
                };
                modListView.Items.Add(item);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            var newModList = new ModList();
            foreach (ListViewItem item in modListView.Items)
            {
                var info = new ModInfo
                {
                    ModActivation = item.Checked,
                    ModName = item.SubItems[1].Text,
                    ModFolder = item.SubItems[2].Text
                };
                newModList.ModInfo.Add(info);
            }
            Properties.Settings.Default.Save();
            XmlHelper.Serialize("ModList.xml", newModList);
        }

        private void GameFolderButton_Click(object sender, EventArgs e)
        {
            // フォルダ選択ダイアログを表示
            var fbd = new FolderBrowserDialog
            {
                Description = "Modを適用するフォルダを指定してください。",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = @"C:\Windows",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                gameFolder.Text = fbd.SelectedPath;
                Properties.Settings.Default.GameDirectory = fbd.SelectedPath;
            }
        }

        private void ModAddButton_Click(object sender, EventArgs e)
        {
            var newModInfo = ModInfoForm.ShowModInfoForm();
            string[] info = { "", newModInfo.ModName, newModInfo.ModFolder };
            var item = new ListViewItem(info);
            modListView.Items.Add(item);
        }

        private void ModDeleteButton_Click(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 1)
            {
                modListView.Items.Remove(modListView.SelectedItems[0]);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 0)
            {
                return;
            }
            if (modListView.SelectedItems[0].Index == 0)
            {
                return;
            }
            var pos = modListView.SelectedItems[0].Index - 1;
            var item = modListView.SelectedItems[0];
            modListView.Items.Remove(item);
            modListView.Items.Insert(pos, item);
            modListView.Items[pos].Selected = true;
            modListView.Focus();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 0)
            {
                return;
            }
            if (modListView.SelectedItems[0].Index == modListView.Items.Count - 1)
            {
                return;
            }
            var pos = modListView.SelectedItems[0].Index + 1;
            var item = modListView.SelectedItems[0];
            modListView.Items.Remove(item);
            modListView.Items.Insert(pos, item);
            modListView.Items[pos].Selected = true;
            modListView.Focus();
        }
    }
}
