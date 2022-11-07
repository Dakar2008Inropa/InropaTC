namespace InropaTC
{
    partial class SettingsForm
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
            this.InstallationPathLabel = new System.Windows.Forms.Label();
            this.InstallationPathTextbox = new System.Windows.Forms.TextBox();
            this.BrowseInstallationPathBtn = new System.Windows.Forms.Button();
            this.InstallationPathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CoreTypeLabel = new System.Windows.Forms.Label();
            this.CoreTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InstallationPathLabel
            // 
            this.InstallationPathLabel.Location = new System.Drawing.Point(10, 10);
            this.InstallationPathLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.InstallationPathLabel.Name = "InstallationPathLabel";
            this.InstallationPathLabel.Size = new System.Drawing.Size(121, 23);
            this.InstallationPathLabel.TabIndex = 0;
            this.InstallationPathLabel.Text = "Installation Path:";
            this.InstallationPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstallationPathTextbox
            // 
            this.InstallationPathTextbox.BackColor = System.Drawing.Color.White;
            this.InstallationPathTextbox.Enabled = false;
            this.InstallationPathTextbox.Location = new System.Drawing.Point(134, 10);
            this.InstallationPathTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.InstallationPathTextbox.Name = "InstallationPathTextbox";
            this.InstallationPathTextbox.ReadOnly = true;
            this.InstallationPathTextbox.Size = new System.Drawing.Size(409, 23);
            this.InstallationPathTextbox.TabIndex = 1;
            // 
            // BrowseInstallationPathBtn
            // 
            this.BrowseInstallationPathBtn.ForeColor = System.Drawing.Color.Black;
            this.BrowseInstallationPathBtn.Location = new System.Drawing.Point(546, 10);
            this.BrowseInstallationPathBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.BrowseInstallationPathBtn.Name = "BrowseInstallationPathBtn";
            this.BrowseInstallationPathBtn.Size = new System.Drawing.Size(31, 23);
            this.BrowseInstallationPathBtn.TabIndex = 2;
            this.BrowseInstallationPathBtn.Text = "...";
            this.BrowseInstallationPathBtn.UseVisualStyleBackColor = true;
            this.BrowseInstallationPathBtn.Click += new System.EventHandler(this.BrowseInstallationPathBtn_Click);
            // 
            // CoreTypeLabel
            // 
            this.CoreTypeLabel.Location = new System.Drawing.Point(10, 43);
            this.CoreTypeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.CoreTypeLabel.Name = "CoreTypeLabel";
            this.CoreTypeLabel.Size = new System.Drawing.Size(121, 23);
            this.CoreTypeLabel.TabIndex = 3;
            this.CoreTypeLabel.Text = "Core Type:";
            this.CoreTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoreTypeComboBox
            // 
            this.CoreTypeComboBox.BackColor = System.Drawing.Color.White;
            this.CoreTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoreTypeComboBox.FormattingEnabled = true;
            this.CoreTypeComboBox.Location = new System.Drawing.Point(134, 43);
            this.CoreTypeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.CoreTypeComboBox.Name = "CoreTypeComboBox";
            this.CoreTypeComboBox.Size = new System.Drawing.Size(443, 24);
            this.CoreTypeComboBox.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(587, 75);
            this.Controls.Add(this.CoreTypeComboBox);
            this.Controls.Add(this.CoreTypeLabel);
            this.Controls.Add(this.BrowseInstallationPathBtn);
            this.Controls.Add(this.InstallationPathTextbox);
            this.Controls.Add(this.InstallationPathLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InstallationPathLabel;
        private TextBox InstallationPathTextbox;
        private Button BrowseInstallationPathBtn;
        private FolderBrowserDialog InstallationPathBrowser;
        private Label CoreTypeLabel;
        private ComboBox CoreTypeComboBox;
    }
}