namespace InropaTC
{
    partial class AddNewTypeForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.PoseFittingLabel = new System.Windows.Forms.Label();
            this.PoseFittingCombobox = new System.Windows.Forms.ComboBox();
            this.PaintPlanningCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SegmentationCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassificationCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TouchPanelDisplayTextbox = new System.Windows.Forms.TextBox();
            this.TouchPanelDisplayTextLabel = new System.Windows.Forms.Label();
            this.TouchPanelInsertGroupBox = new System.Windows.Forms.GroupBox();
            this.TouchPanelItems = new System.Windows.Forms.ListBox();
            this.AfterRadioBtn = new System.Windows.Forms.RadioButton();
            this.BeforeRadioBtn = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloneClassificationBtn = new System.Windows.Forms.Button();
            this.NewClassificationBtn = new System.Windows.Forms.Button();
            this.CloneSegmentationBtn = new System.Windows.Forms.Button();
            this.NewPaintPlanningBtn = new System.Windows.Forms.Button();
            this.ClonePaintPlanningBtn = new System.Windows.Forms.Button();
            this.ClonePoseFittingBtn = new System.Windows.Forms.Button();
            this.TouchPanelInsertGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(10, 10);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(236, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.Color.White;
            this.NameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextbox.Location = new System.Drawing.Point(10, 40);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(677, 23);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.Leave += new System.EventHandler(this.NameTextbox_Leave);
            // 
            // PoseFittingLabel
            // 
            this.PoseFittingLabel.Location = new System.Drawing.Point(10, 68);
            this.PoseFittingLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PoseFittingLabel.Name = "PoseFittingLabel";
            this.PoseFittingLabel.Size = new System.Drawing.Size(236, 25);
            this.PoseFittingLabel.TabIndex = 2;
            this.PoseFittingLabel.Text = "Select PoseFitting:";
            this.PoseFittingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PoseFittingCombobox
            // 
            this.PoseFittingCombobox.BackColor = System.Drawing.Color.White;
            this.PoseFittingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoseFittingCombobox.FormattingEnabled = true;
            this.PoseFittingCombobox.Location = new System.Drawing.Point(10, 98);
            this.PoseFittingCombobox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.PoseFittingCombobox.Name = "PoseFittingCombobox";
            this.PoseFittingCombobox.Size = new System.Drawing.Size(517, 24);
            this.PoseFittingCombobox.TabIndex = 3;
            // 
            // PaintPlanningCombobox
            // 
            this.PaintPlanningCombobox.BackColor = System.Drawing.Color.White;
            this.PaintPlanningCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaintPlanningCombobox.FormattingEnabled = true;
            this.PaintPlanningCombobox.Location = new System.Drawing.Point(10, 157);
            this.PaintPlanningCombobox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.PaintPlanningCombobox.Name = "PaintPlanningCombobox";
            this.PaintPlanningCombobox.Size = new System.Drawing.Size(517, 24);
            this.PaintPlanningCombobox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select PaintPlanning:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SegmentationCombobox
            // 
            this.SegmentationCombobox.BackColor = System.Drawing.Color.White;
            this.SegmentationCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SegmentationCombobox.FormattingEnabled = true;
            this.SegmentationCombobox.Location = new System.Drawing.Point(10, 216);
            this.SegmentationCombobox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.SegmentationCombobox.Name = "SegmentationCombobox";
            this.SegmentationCombobox.Size = new System.Drawing.Size(517, 24);
            this.SegmentationCombobox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Segmentation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassificationCombobox
            // 
            this.ClassificationCombobox.BackColor = System.Drawing.Color.White;
            this.ClassificationCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassificationCombobox.FormattingEnabled = true;
            this.ClassificationCombobox.Location = new System.Drawing.Point(10, 275);
            this.ClassificationCombobox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ClassificationCombobox.Name = "ClassificationCombobox";
            this.ClassificationCombobox.Size = new System.Drawing.Size(517, 24);
            this.ClassificationCombobox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Classification:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // TouchPanelInsertGroupBox
            // 
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelItems);
            this.TouchPanelInsertGroupBox.Controls.Add(this.AfterRadioBtn);
            this.TouchPanelInsertGroupBox.Controls.Add(this.BeforeRadioBtn);
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelDisplayTextLabel);
            this.TouchPanelInsertGroupBox.Controls.Add(this.TouchPanelDisplayTextbox);
            this.TouchPanelInsertGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TouchPanelInsertGroupBox.ForeColor = System.Drawing.Color.White;
            this.TouchPanelInsertGroupBox.Location = new System.Drawing.Point(10, 332);
            this.TouchPanelInsertGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TouchPanelInsertGroupBox.Name = "TouchPanelInsertGroupBox";
            this.TouchPanelInsertGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TouchPanelInsertGroupBox.Size = new System.Drawing.Size(677, 306);
            this.TouchPanelInsertGroupBox.TabIndex = 12;
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
            this.AfterRadioBtn.Location = new System.Drawing.Point(509, 77);
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
            this.BeforeRadioBtn.Location = new System.Drawing.Point(5, 77);
            this.BeforeRadioBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BeforeRadioBtn.Name = "BeforeRadioBtn";
            this.BeforeRadioBtn.Size = new System.Drawing.Size(167, 20);
            this.BeforeRadioBtn.TabIndex = 0;
            this.BeforeRadioBtn.TabStop = true;
            this.BeforeRadioBtn.Text = "Before Selected Type";
            this.BeforeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(10, 648);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(677, 47);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloneClassificationBtn
            // 
            this.CloneClassificationBtn.ForeColor = System.Drawing.Color.Black;
            this.CloneClassificationBtn.Location = new System.Drawing.Point(532, 276);
            this.CloneClassificationBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.CloneClassificationBtn.Name = "CloneClassificationBtn";
            this.CloneClassificationBtn.Size = new System.Drawing.Size(75, 23);
            this.CloneClassificationBtn.TabIndex = 15;
            this.CloneClassificationBtn.Text = "Clone";
            this.CloneClassificationBtn.UseVisualStyleBackColor = true;
            this.CloneClassificationBtn.Click += new System.EventHandler(this.CloneClassificationBtn_Click);
            // 
            // NewClassificationBtn
            // 
            this.NewClassificationBtn.ForeColor = System.Drawing.Color.Black;
            this.NewClassificationBtn.Location = new System.Drawing.Point(612, 276);
            this.NewClassificationBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NewClassificationBtn.Name = "NewClassificationBtn";
            this.NewClassificationBtn.Size = new System.Drawing.Size(75, 23);
            this.NewClassificationBtn.TabIndex = 16;
            this.NewClassificationBtn.Text = "New";
            this.NewClassificationBtn.UseVisualStyleBackColor = true;
            this.NewClassificationBtn.Click += new System.EventHandler(this.NewClassificationBtn_Click);
            // 
            // CloneSegmentationBtn
            // 
            this.CloneSegmentationBtn.ForeColor = System.Drawing.Color.Black;
            this.CloneSegmentationBtn.Location = new System.Drawing.Point(532, 217);
            this.CloneSegmentationBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.CloneSegmentationBtn.Name = "CloneSegmentationBtn";
            this.CloneSegmentationBtn.Size = new System.Drawing.Size(155, 23);
            this.CloneSegmentationBtn.TabIndex = 18;
            this.CloneSegmentationBtn.Text = "Clone";
            this.CloneSegmentationBtn.UseVisualStyleBackColor = true;
            this.CloneSegmentationBtn.Click += new System.EventHandler(this.CloneSegmentationBtn_Click);
            // 
            // NewPaintPlanningBtn
            // 
            this.NewPaintPlanningBtn.ForeColor = System.Drawing.Color.Black;
            this.NewPaintPlanningBtn.Location = new System.Drawing.Point(612, 158);
            this.NewPaintPlanningBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.NewPaintPlanningBtn.Name = "NewPaintPlanningBtn";
            this.NewPaintPlanningBtn.Size = new System.Drawing.Size(75, 23);
            this.NewPaintPlanningBtn.TabIndex = 14;
            this.NewPaintPlanningBtn.Text = "New";
            this.NewPaintPlanningBtn.UseVisualStyleBackColor = true;
            this.NewPaintPlanningBtn.Click += new System.EventHandler(this.NewPaintPlanningBtn_Click);
            // 
            // ClonePaintPlanningBtn
            // 
            this.ClonePaintPlanningBtn.ForeColor = System.Drawing.Color.Black;
            this.ClonePaintPlanningBtn.Location = new System.Drawing.Point(532, 158);
            this.ClonePaintPlanningBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ClonePaintPlanningBtn.Name = "ClonePaintPlanningBtn";
            this.ClonePaintPlanningBtn.Size = new System.Drawing.Size(75, 23);
            this.ClonePaintPlanningBtn.TabIndex = 13;
            this.ClonePaintPlanningBtn.Text = "Clone";
            this.ClonePaintPlanningBtn.UseVisualStyleBackColor = true;
            this.ClonePaintPlanningBtn.Click += new System.EventHandler(this.ClonePaintPlanningBtn_Click);
            // 
            // ClonePoseFittingBtn
            // 
            this.ClonePoseFittingBtn.ForeColor = System.Drawing.Color.Black;
            this.ClonePoseFittingBtn.Location = new System.Drawing.Point(532, 99);
            this.ClonePoseFittingBtn.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ClonePoseFittingBtn.Name = "ClonePoseFittingBtn";
            this.ClonePoseFittingBtn.Size = new System.Drawing.Size(155, 23);
            this.ClonePoseFittingBtn.TabIndex = 17;
            this.ClonePoseFittingBtn.Text = "Clone";
            this.ClonePoseFittingBtn.UseVisualStyleBackColor = true;
            this.ClonePoseFittingBtn.Click += new System.EventHandler(this.ClonePoseFittingBtn_Click);
            // 
            // AddNewTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(697, 705);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CloneSegmentationBtn);
            this.Controls.Add(this.ClonePoseFittingBtn);
            this.Controls.Add(this.NewClassificationBtn);
            this.Controls.Add(this.CloneClassificationBtn);
            this.Controls.Add(this.NewPaintPlanningBtn);
            this.Controls.Add(this.ClonePaintPlanningBtn);
            this.Controls.Add(this.TouchPanelInsertGroupBox);
            this.Controls.Add(this.ClassificationCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegmentationCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaintPlanningCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PoseFittingCombobox);
            this.Controls.Add(this.PoseFittingLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewTypeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewTypeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddNewTypeForm_Load);
            this.TouchPanelInsertGroupBox.ResumeLayout(false);
            this.TouchPanelInsertGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextbox;
        private Label PoseFittingLabel;
        private ComboBox PoseFittingCombobox;
        private ComboBox PaintPlanningCombobox;
        private Label label1;
        private ComboBox SegmentationCombobox;
        private Label label2;
        private ComboBox ClassificationCombobox;
        private Label label3;
        private TextBox TouchPanelDisplayTextbox;
        private Label TouchPanelDisplayTextLabel;
        private GroupBox TouchPanelInsertGroupBox;
        private RadioButton BeforeRadioBtn;
        private RadioButton AfterRadioBtn;
        private ListBox TouchPanelItems;
        private Button SaveBtn;
        private Button CloneClassificationBtn;
        private Button NewClassificationBtn;
        private Button CloneSegmentationBtn;
        private Button NewPaintPlanningBtn;
        private Button ClonePaintPlanningBtn;
        private Button ClonePoseFittingBtn;
    }
}