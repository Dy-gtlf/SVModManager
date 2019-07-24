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
using Microsoft.VisualBasic.FileIO;

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
            gameFolder.Text = Properties.Settings.Default.GameFolder;
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
                Properties.Settings.Default.GameFolder = fbd.SelectedPath;
            }
        }

        private void ModAddButton_Click(object sender, EventArgs e)
        {
            var newModInfo = ModInfoForm.ShowModInfoForm("");
            if (newModInfo != null)
            {
                string[] info = { "", newModInfo.ModName, newModInfo.ModFolder };
                var item = new ListViewItem(info);
                modListView.Items.Add(item);
            }
        }

        private void ModDeleteButton_Click(object sender, EventArgs e)
        {
            if (modListView.SelectedItems.Count == 1)
            {
                var item = modListView.SelectedItems[0];
                var res = MessageBox.Show($"{item.SubItems[1].Text} を削除しますか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    modListView.Items.Remove(modListView.SelectedItems[0]);
                }
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

        private void BackUpButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("現在の状態のバックアップを作成しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes && gameFolder.Text != "")
            {
                try
                {
                    var dir = gameFolder.Text;
                    var backUpDir = $@"backup\{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                    FileSystem.CopyDirectory(dir, backUpDir, UIOption.AllDialogs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            // フォルダ選択ダイアログを表示
            var fbd = new FolderBrowserDialog
            {
                Description = "バックアップフォルダを指定してください。",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = Directory.GetCurrentDirectory() + @"\backup",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                var backUpDir = fbd.SelectedPath;
                var res = MessageBox.Show("バックアップから復元しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes && gameFolder.Text != "")
                {
                    try
                    {
                        var dir = gameFolder.Text;
                        FileSystem.CopyDirectory(backUpDir, dir, UIOption.AllDialogs);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var pathList = new List<string>();
            foreach (ListViewItem mod in modListView.Items)
            {
                if (mod.Checked)
                {
                    pathList.Add(mod.SubItems[2].Text);
                }
            }
            pathList.Reverse();
            var res = MessageBox.Show("Modを適用しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                foreach (var path in pathList)
                {
                    try
                    {
                        FileSystem.CopyDirectory(path, gameFolder.Text, UIOption.AllDialogs);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void ModListView_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }
            var dragFilePathArr = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var newModInfo = ModInfoForm.ShowModInfoForm(dragFilePathArr[0]);
            if (newModInfo != null)
            {
                string[] info = { "", newModInfo.ModName, newModInfo.ModFolder };
                var item = new ListViewItem(info);
                modListView.Items.Add(item);
            }
        }

        private void ModListView_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグドロップ時にカーソルの形状を変更
            e.Effect = DragDropEffects.All;

        }
    }
}
