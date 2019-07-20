namespace SVModManager
{
    partial class ModInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modFolderButton = new System.Windows.Forms.Button();
            this.modFolder = new System.Windows.Forms.TextBox();
            this.modName = new System.Windows.Forms.TextBox();
            this.modNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modFolderButton
            // 
            this.modFolderButton.Location = new System.Drawing.Point(12, 49);
            this.modFolderButton.Name = "modFolderButton";
            this.modFolderButton.Size = new System.Drawing.Size(75, 23);
            this.modFolderButton.TabIndex = 0;
            this.modFolderButton.Text = "Modフォルダ";
            this.modFolderButton.UseVisualStyleBackColor = true;
            this.modFolderButton.Click += new System.EventHandler(this.ModFolderButton_Click);
            // 
            // modFolder
            // 
            this.modFolder.Location = new System.Drawing.Point(12, 78);
            this.modFolder.Name = "modFolder";
            this.modFolder.ReadOnly = true;
            this.modFolder.Size = new System.Drawing.Size(331, 19);
            this.modFolder.TabIndex = 1;
            // 
            // modName
            // 
            this.modName.Location = new System.Drawing.Point(12, 24);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(331, 19);
            this.modName.TabIndex = 2;
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(12, 9);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(38, 12);
            this.modNameLabel.TabIndex = 3;
            this.modNameLabel.Text = "Mod名";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(91, 103);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(187, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ModInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 136);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.modNameLabel);
            this.Controls.Add(this.modName);
            this.Controls.Add(this.modFolder);
            this.Controls.Add(this.modFolderButton);
            this.Name = "ModInfoForm";
            this.Text = "Mod情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modFolderButton;
        private System.Windows.Forms.TextBox modFolder;
        private System.Windows.Forms.TextBox modName;
        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}