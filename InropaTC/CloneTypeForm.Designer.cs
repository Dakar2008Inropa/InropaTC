namespace InropaTC
{
    partial class CloneTypeForm
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TouchPanelInsertGroupBox = new System.Windows.Forms.GroupBox();
            this.TouchPanelItems = new System.Windows.Forms.ListBox();
            this.AfterRadioBtn = new System.Windows.Forms.RadioButton();
            this.BeforeRadioBtn = new System.Windows.Forms.RadioButton();
            this.TouchPanelDisplayTextLabel = new System.Windows.Forms.Label();
            this.TouchPanelDisplayTextbox = new System.Windows.Forms.TextBox();
            this.TouchPanelInsertGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.Color.White;
            this.NameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextbox.Location = new System.Drawing.Point(11, 39);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(677, 23);
            this.NameTextbox.TabIndex = 3;
            this.NameTextbox.Leave += new System.EventHandler(this.NameTextbox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(11, 9);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(236, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(11, 404);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(677, 47);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TouchPanelInsertGroupBox
            // 
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelItems);
            this.TouchPanelInsertGroupBox.Controls.Add(this.AfterRadioBtn);
            this.TouchPanelInsertGroupBox.Controls.Add(this.BeforeRadioBtn);
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelDisplayTextLabel);
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelDisplayTextbox);
            this.TouchPanelInsertGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TouchPanelInsertGroupBox.ForeColor = System.Drawing.Color.White;
            this.TouchPanelInsertGroupBox.Location = new System.Drawing.Point(11, 88);
            this.TouchPanelInsertGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TouchPanelInsertGroupBox.Name = "TouchPanelInsertGroupBox";
            this.TouchPanelInsertGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TouchPanelInsertGroupBox.Size = new System.Drawing.Size(677, 306);
            this.TouchPanelInsertGroupBox.TabIndex = 20;
            this.TouchPanelInsertGroupBox.TabStop = false;
            this.TouchPanelInsertGroupBox.Text = "TouchPanel Insert";
            // 
            // TouchPanelItems
            // 
            this.TouchPanelItems.BackColor = System.Drawing.Color.White;
            this.TouchPanelItems.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TouchPanelItems.FormattingEnabled = true;
            this.TouchPanelItems.ItemHeight = 16;
            this.TouchPanelItems.Location = new System.Drawing.Point(5, 102);
            this.TouchPanelItems.Margin = new System.Windows.Forms.Padding(0);
            this.TouchPanelItems.Name = "TouchPanelItems";
            this.TouchPanelItems.Size = new System.Drawing.Size(667, 196);
            this.TouchPanelItems.TabIndex = 2;
            // 
            // AfterRadioBtn
            // 
            this.AfterRadioBtn.AutoSize = true;
            this.AfterRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AfterRadioBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AfterRadioBtn.Location = new System.Drawing.Point(511, 79);
            this.AfterRadioBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.AfterRadioBtn.Name = "AfterRadioBtn";
            this.AfterRadioBtn.Size = new System.Drawing.Size(158, 20);
            this.AfterRadioBtn.TabIndex = 1;
            this.AfterRadioBtn.TabStop = true;
            this.AfterRadioBtn.Text = "After Selected Type";
            this.AfterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BeforeRadioBtn
            // 
            this.BeforeRadioBtn.AutoSize = true;
            this.BeforeRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeforeRadioBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BeforeRadioBtn.Location = new System.Drawing.Point(7, 79);
            this.BeforeRadioBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BeforeRadioBtn.Name = "BeforeRadioBtn";
            this.BeforeRadioBtn.Size = new System.Drawing.Size(167, 20);
            this.BeforeRadioBtn.TabIndex = 0;
            this.BeforeRadioBtn.TabStop = true;
            this.BeforeRadioBtn.Text = "Before Selected Type";
            this.BeforeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TouchPanelDisplayTextLabel
            // 
            this.TouchPanelDisplayTextLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TouchPanelDisplayTextLabel.Location = new System.Drawing.Point(5, 19);
            this.TouchPanelDisplayTextLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.TouchPanelDisplayTextLabel.Name = "TouchPanelDisplayTextLabel";
            this.TouchPanelDisplayTextLabel.Size = new System.Drawing.Size(236, 25);
            this.TouchPanelDisplayTextLabel.TabIndex = 10;
            this.TouchPanelDisplayTextLabel.Text = "TouchPanel Display Text:";
            this.TouchPanelDisplayTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TouchPanelDisplayTextbox
            // 
            this.TouchPanelDisplayTextbox.BackColor = System.Drawing.Color.White;
            this.TouchPanelDisplayTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TouchPanelDisplayTextbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TouchPanelDisplayTextbox.Location = new System.Drawing.Point(5, 49);
            this.TouchPanelDisplayTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.TouchPanelDisplayTextbox.Name = "TouchPanelDisplayTextbox";
            this.TouchPanelDisplayTextbox.Size = new System.Drawing.Size(667, 23);
            this.TouchPanelDisplayTextbox.TabIndex = 11;
            // 
            // CloneTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(697, 460);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TouchPanelInsertGroupBox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CloneTypeForm";
            this.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clone";
            this.Load += new System.EventHandler(this.CloneTypeForm_Load);
            this.TouchPanelInsertGroupBox.ResumeLayout(false);
            this.TouchPanelInsertGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameTextbox;
        private Label NameLabel;
        private Button SaveBtn;
        private GroupBox TouchPanelInsertGroupBox;
        private ListBox TouchPanelItems;
        private RadioButton AfterRadioBtn;
        private RadioButton BeforeRadioBtn;
        private Label TouchPanelDisplayTextLabel;
        private TextBox TouchPanelDisplayTextbox;
    }
}