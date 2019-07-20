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
            this.gameFolderButton.Size = new System.Drawing.Size(110, 25);
            this.gameFolderButton.TabIndex = 2;
            this.gameFolderButton.Text = "適用先フォルダ指定";
            this.gameFolderButton.UseVisualStyleBackColor = true;
            this.gameFolderButton.Click += new System.EventHandler(this.GameFolderButton_Click);
            // 
            // gameFolder
            // 
            this.gameFolder.Location = new System.Drawing.Point(522, 45);
            this.gameFolder.Name = "gameFolder";
            this.gameFolder.ReadOnly = true;
            this.gameFolder.Size = new System.Drawing.Size(300, 19);
            this.gameFolder.TabIndex = 3;
            this.gameFolder.Text = "Modを適用するフォルダを指定してください。";
            // 
            // modAddButton
            // 
            this.modAddButton.Location = new System.Drawing.Point(522, 70);
            this.modAddButton.Name = "modAddButton";
            this.modAddButton.Size = new System.Drawing.Size(75, 23);
            this.modAddButton.TabIndex = 4;
            this.modAddButton.Text = "Mod追加";
            this.modAddButton.UseVisualStyleBackColor = true;
            this.modAddButton.Click += new System.EventHandler(this.ModAddButton_Click);
            // 
            // modDeleteButton
            // 
            this.modDeleteButton.Location = new System.Drawing.Point(522, 99);
            this.modDeleteButton.Name = "modDeleteButton";
            this.modDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.modDeleteButton.TabIndex = 5;
            this.modDeleteButton.Text = "Mod削除";
            this.modDeleteButton.UseVisualStyleBackColor = true;
            this.modDeleteButton.Click += new System.EventHandler(this.ModDeleteButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(522, 270);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(35, 25);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(522, 301);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(35, 25);
            this.downButton.TabIndex = 7;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 336);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.modDeleteButton);
            this.Controls.Add(this.modAddButton);
            this.Controls.Add(this.gameFolder);
            this.Controls.Add(this.gameFolderButton);
            this.Controls.Add(this.modListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
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
    }
}

