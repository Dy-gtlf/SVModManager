namespace SVModManager
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.modListView = new System.Windows.Forms.ListView();
            this.Activation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameFolderButton = new System.Windows.Forms.Button();
            this.gameFolder = new System.Windows.Forms.TextBox();
            this.modAddButton = new System.Windows.Forms.Button();
            this.modDeleteButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.backUpButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modListView
            // 
            this.modListView.CheckBoxes = true;
            this.modListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Activation,
            this.ModName,
            this.ModFolder});
            this.modListView.FullRowSelect = true;
            this.modListView.LabelWrap = false;
            this.modListView.Location = new System.Drawing.Point(12, 12);
            this.modListView.MultiSelect = false;
            this.modListView.Name = "modListView";
            this.modListView.Size = new System.Drawing.Size(504, 314);
            this.modListView.TabIndex = 1;
            this.modListView.UseCompatibleStateImageBehavior = false;
            this.modListView.View = System.Windows.Forms.View.Details;
            // 
            // Activation
            // 
            this.Activation.Text = "";
            this.Activation.Width = 30;
            // 
            // ModName
            // 
            this.ModName.Text = "Mod名";
            this.ModName.Width = 150;
            // 
            // ModFolder
            // 
            this.ModFolder.Text = "フォルダ";
            this.ModFolder.Width = 320;
            // 
            // gameFolderButton
            // 
            this.gameFolderButton.Location = new System.Drawing.Point(522, 12);
            this.gameFolderButton.Name = "gameFolderButton";
            this.gameFolderButton.Size = new System.Drawing.Size(110, 23);
            this.gameFolderButton.TabIndex = 2;
            this.gameFolderButton.Text = "Mod適用先フォルダ";
            this.gameFolderButton.UseVisualStyleBackColor = true;
            this.gameFolderButton.Click += new System.EventHandler(this.GameFolderButton_Click);
            // 
            // gameFolder
            // 
            this.gameFolder.Location = new System.Drawing.Point(522, 41);
            this.gameFolder.Name = "gameFolder";
            this.gameFolder.ReadOnly = true;
            this.gameFolder.Size = new System.Drawing.Size(110, 19);
            this.gameFolder.TabIndex = 3;
            // 
            // modAddButton
            // 
            this.modAddButton.Location = new System.Drawing.Point(522, 124);
            this.modAddButton.Name = "modAddButton";
            this.modAddButton.Size = new System.Drawing.Size(110, 23);
            this.modAddButton.TabIndex = 4;
            this.modAddButton.Text = "Mod追加";
            this.modAddButton.UseVisualStyleBackColor = true;
            this.modAddButton.Click += new System.EventHandler(this.ModAddButton_Click);
            // 
            // modDeleteButton
            // 
            this.modDeleteButton.Location = new System.Drawing.Point(522, 153);
            this.modDeleteButton.Name = "modDeleteButton";
            this.modDeleteButton.Size = new System.Drawing.Size(110, 23);
            this.modDeleteButton.TabIndex = 5;
            this.modDeleteButton.Text = "Mod削除";
            this.modDeleteButton.UseVisualStyleBackColor = true;
            this.modDeleteButton.Click += new System.EventHandler(this.ModDeleteButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(522, 182);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(35, 25);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(522, 213);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(35, 25);
            this.downButton.TabIndex = 7;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // backUpButton
            // 
            this.backUpButton.Location = new System.Drawing.Point(522, 66);
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.Size = new System.Drawing.Size(110, 23);
            this.backUpButton.TabIndex = 8;
            this.backUpButton.Text = "バックアップ生成";
            this.backUpButton.UseVisualStyleBackColor = true;
            this.backUpButton.Click += new System.EventHandler(this.BackUpButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(522, 301);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(110, 23);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "適用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(522, 95);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(110, 23);
            this.restoreButton.TabIndex = 10;
            this.restoreButton.Text = "復元";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 336);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.backUpButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.modDeleteButton);
            this.Controls.Add(this.modAddButton);
            this.Controls.Add(this.gameFolder);
            this.Controls.Add(this.gameFolderButton);
            this.Controls.Add(this.modListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVModManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.Button gameFolderButton;
        private System.Windows.Forms.TextBox gameFolder;
        private System.Windows.Forms.Button modAddButton;
        private System.Windows.Forms.Button modDeleteButton;
        private System.Windows.Forms.ColumnHeader Activation;
        private System.Windows.Forms.ColumnHeader ModName;
        private System.Windows.Forms.ColumnHeader ModFolder;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button backUpButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button restoreButton;
    }
}

