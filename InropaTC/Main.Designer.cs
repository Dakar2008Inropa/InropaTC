namespace InropaTC
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SelectCellLabel = new System.Windows.Forms.Label();
            this.SteelCellsCombobox = new System.Windows.Forms.ComboBox();
            this.TypesGroupBox = new System.Windows.Forms.GroupBox();
            this.CellTypesListBox = new System.Windows.Forms.ListBox();
            this.TypeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloneSelectedTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditSelectedTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSelectedTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassificationComboBox = new System.Windows.Forms.ComboBox();
            this.ClassificationLabel = new System.Windows.Forms.Label();
            this.SegmentationComboBox = new System.Windows.Forms.ComboBox();
            this.SegmentationLabel = new System.Windows.Forms.Label();
            this.PaintPlanningComboBox = new System.Windows.Forms.ComboBox();
            this.PaintPlanningLabel = new System.Windows.Forms.Label();
            this.PoseFittingComboBox = new System.Windows.Forms.ComboBox();
            this.PoseFittingLabel = new System.Windows.Forms.Label();
            this.SaveConfigBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.TypesGroupBox.SuspendLayout();
            this.TypeContextMenu.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectCellLabel
            // 
            this.SelectCellLabel.Enabled = false;
            this.SelectCellLabel.Location = new System.Drawing.Point(518, 14);
            this.SelectCellLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SelectCellLabel.Name = "SelectCellLabel";
            this.SelectCellLabel.Size = new System.Drawing.Size(92, 24);
            this.SelectCellLabel.TabIndex = 0;
            this.SelectCellLabel.Text = "Select Cell:";
            this.SelectCellLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SteelCellsCombobox
            // 
            this.SteelCellsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteelCellsCombobox.Enabled = false;
            this.SteelCellsCombobox.FormattingEnabled = true;
            this.SteelCellsCombobox.Location = new System.Drawing.Point(610, 14);
            this.SteelCellsCombobox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SteelCellsCombobox.Name = "SteelCellsCombobox";
            this.SteelCellsCombobox.Size = new System.Drawing.Size(292, 24);
            this.SteelCellsCombobox.TabIndex = 1;
            this.SteelCellsCombobox.SelectedIndexChanged += new System.EventHandler(this.SteelCellsCombobox_SelectedIndexChanged);
            // 
            // TypesGroupBox
            // 
            this.TypesGroupBox.Controls.Add(this.CellTypesListBox);
            this.TypesGroupBox.Enabled = false;
            this.TypesGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypesGroupBox.ForeColor = System.Drawing.Color.White;
            this.TypesGroupBox.Location = new System.Drawing.Point(10, 43);
            this.TypesGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.TypesGroupBox.Name = "TypesGroupBox";
            this.TypesGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TypesGroupBox.Size = new System.Drawing.Size(312, 317);
            this.TypesGroupBox.TabIndex = 2;
            this.TypesGroupBox.TabStop = false;
            this.TypesGroupBox.Text = "Types";
            // 
            // CellTypesListBox
            // 
            this.CellTypesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellTypesListBox.ContextMenuStrip = this.TypeContextMenu;
            this.CellTypesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellTypesListBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellTypesListBox.FormattingEnabled = true;
            this.CellTypesListBox.ItemHeight = 16;
            this.CellTypesListBox.Location = new System.Drawing.Point(5, 21);
            this.CellTypesListBox.Margin = new System.Windows.Forms.Padding(0);
            this.CellTypesListBox.Name = "CellTypesListBox";
            this.CellTypesListBox.Size = new System.Drawing.Size(302, 291);
            this.CellTypesListBox.TabIndex = 0;
            this.CellTypesListBox.SelectedIndexChanged += new System.EventHandler(this.CellTypesListBox_SelectedIndexChanged);
            // 
            // TypeContextMenu
            // 
            this.TypeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTypeMenuItem,
            this.toolStripSeparator1,
            this.CloneSelectedTypeMenuItem,
            this.toolStripSeparator2,
            this.EditSelectedTypeMenuItem,
            this.DeleteSelectedTypeMenuItem});
            this.TypeContextMenu.Name = "TypeContextMenu";
            this.TypeContextMenu.Size = new System.Drawing.Size(181, 126);
            this.TypeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.TypeContextMenu_Opening);
            // 
            // NewTypeMenuItem
            // 
            this.NewTypeMenuItem.Image = global::InropaTC.Properties.Resources.Actions_list_add_icon;
            this.NewTypeMenuItem.Name = "NewTypeMenuItem";
            this.NewTypeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewTypeMenuItem.Text = "Create New Type";
            this.NewTypeMenuItem.Click += new System.EventHandler(this.NewTypeMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // CloneSelectedTypeMenuItem
            // 
            this.CloneSelectedTypeMenuItem.Image = global::InropaTC.Properties.Resources.Arrows_icon;
            this.CloneSelectedTypeMenuItem.Name = "CloneSelectedTypeMenuItem";
            this.CloneSelectedTypeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloneSelectedTypeMenuItem.Text = "toolStripMenuItem1";
            this.CloneSelectedTypeMenuItem.Click += new System.EventHandler(this.CloneSelectedTypeMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // EditSelectedTypeMenuItem
            // 
            this.EditSelectedTypeMenuItem.Image = global::InropaTC.Properties.Resources.pencil_icon;
            this.EditSelectedTypeMenuItem.Name = "EditSelectedTypeMenuItem";
            this.EditSelectedTypeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditSelectedTypeMenuItem.Text = "Edit";
            this.EditSelectedTypeMenuItem.Click += new System.EventHandler(this.EditTypeBtn_Click);
            // 
            // DeleteSelectedTypeMenuItem
            // 
            this.DeleteSelectedTypeMenuItem.Image = global::InropaTC.Properties.Resources.Actions_edit_delete_icon;
            this.DeleteSelectedTypeMenuItem.Name = "DeleteSelectedTypeMenuItem";
            this.DeleteSelectedTypeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteSelectedTypeMenuItem.Text = "Delete";
            this.DeleteSelectedTypeMenuItem.Click += new System.EventHandler(this.DeleteTypeBtn_Click);
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.ClassificationComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.ClassificationLabel);
            this.ConfigurationGroupBox.Controls.Add(this.SegmentationComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.SegmentationLabel);
            this.ConfigurationGroupBox.Controls.Add(this.PaintPlanningComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.PaintPlanningLabel);
            this.ConfigurationGroupBox.Controls.Add(this.PoseFittingComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.PoseFittingLabel);
            this.ConfigurationGroupBox.Enabled = false;
            this.ConfigurationGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfigurationGroupBox.ForeColor = System.Drawing.Color.White;
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(327, 43);
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(575, 317);
            this.ConfigurationGroupBox.TabIndex = 3;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configurations";
            // 
            // ClassificationComboBox
            // 
            this.ClassificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassificationComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassificationComboBox.ForeColor = System.Drawing.Color.Black;
            this.ClassificationComboBox.FormattingEnabled = true;
            this.ClassificationComboBox.Location = new System.Drawing.Point(5, 271);
            this.ClassificationComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ClassificationComboBox.Name = "ClassificationComboBox";
            this.ClassificationComboBox.Size = new System.Drawing.Size(562, 24);
            this.ClassificationComboBox.TabIndex = 7;
            // 
            // ClassificationLabel
            // 
            this.ClassificationLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassificationLabel.Location = new System.Drawing.Point(5, 234);
            this.ClassificationLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ClassificationLabel.Name = "ClassificationLabel";
            this.ClassificationLabel.Size = new System.Drawing.Size(565, 32);
            this.ClassificationLabel.TabIndex = 6;
            this.ClassificationLabel.Text = "Classification";
            this.ClassificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SegmentationComboBox
            // 
            this.SegmentationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SegmentationComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SegmentationComboBox.ForeColor = System.Drawing.Color.Black;
            this.SegmentationComboBox.FormattingEnabled = true;
            this.SegmentationComboBox.Location = new System.Drawing.Point(5, 200);
            this.SegmentationComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.SegmentationComboBox.Name = "SegmentationComboBox";
            this.SegmentationComboBox.Size = new System.Drawing.Size(562, 24);
            this.SegmentationComboBox.TabIndex = 5;
            // 
            // SegmentationLabel
            // 
            this.SegmentationLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SegmentationLabel.Location = new System.Drawing.Point(5, 163);
            this.SegmentationLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SegmentationLabel.Name = "SegmentationLabel";
            this.SegmentationLabel.Size = new System.Drawing.Size(565, 32);
            this.SegmentationLabel.TabIndex = 4;
            this.SegmentationLabel.Text = "Segmentation";
            this.SegmentationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaintPlanningComboBox
            // 
            this.PaintPlanningComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaintPlanningComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaintPlanningComboBox.ForeColor = System.Drawing.Color.Black;
            this.PaintPlanningComboBox.FormattingEnabled = true;
            this.PaintPlanningComboBox.Location = new System.Drawing.Point(5, 129);
            this.PaintPlanningComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PaintPlanningComboBox.Name = "PaintPlanningComboBox";
            this.PaintPlanningComboBox.Size = new System.Drawing.Size(562, 24);
            this.PaintPlanningComboBox.TabIndex = 3;
            // 
            // PaintPlanningLabel
            // 
            this.PaintPlanningLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaintPlanningLabel.Location = new System.Drawing.Point(5, 92);
            this.PaintPlanningLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PaintPlanningLabel.Name = "PaintPlanningLabel";
            this.PaintPlanningLabel.Size = new System.Drawing.Size(565, 32);
            this.PaintPlanningLabel.TabIndex = 2;
            this.PaintPlanningLabel.Text = "PaintPlanning:";
            this.PaintPlanningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PoseFittingComboBox
            // 
            this.PoseFittingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoseFittingComboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoseFittingComboBox.ForeColor = System.Drawing.Color.Black;
            this.PoseFittingComboBox.FormattingEnabled = true;
            this.PoseFittingComboBox.Location = new System.Drawing.Point(5, 58);
            this.PoseFittingComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PoseFittingComboBox.Name = "PoseFittingComboBox";
            this.PoseFittingComboBox.Size = new System.Drawing.Size(562, 24);
            this.PoseFittingComboBox.TabIndex = 1;
            // 
            // PoseFittingLabel
            // 
            this.PoseFittingLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoseFittingLabel.Location = new System.Drawing.Point(5, 21);
            this.PoseFittingLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PoseFittingLabel.Name = "PoseFittingLabel";
            this.PoseFittingLabel.Size = new System.Drawing.Size(565, 32);
            this.PoseFittingLabel.TabIndex = 0;
            this.PoseFittingLabel.Text = "PoseFitting:";
            this.PoseFittingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveConfigBtn
            // 
            this.SaveConfigBtn.BackColor = System.Drawing.Color.Silver;
            this.SaveConfigBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConfigBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveConfigBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveConfigBtn.Image = global::InropaTC.Properties.Resources.Save_icon_16x16;
            this.SaveConfigBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveConfigBtn.Location = new System.Drawing.Point(10, 10);
            this.SaveConfigBtn.Name = "SaveConfigBtn";
            this.SaveConfigBtn.Size = new System.Drawing.Size(74, 28);
            this.SaveConfigBtn.TabIndex = 8;
            this.SaveConfigBtn.Text = "Save";
            this.SaveConfigBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveConfigBtn.UseVisualStyleBackColor = false;
            this.SaveConfigBtn.Click += new System.EventHandler(this.SaveConfigBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Silver;
            this.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingsBtn.Image = global::InropaTC.Properties.Resources.settings_icon;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(234, 10);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(88, 28);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(912, 368);
            this.Controls.Add(this.SaveConfigBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.TypesGroupBox);
            this.Controls.Add(this.SteelCellsCombobox);
            this.Controls.Add(this.SelectCellLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Inropa Type Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TypesGroupBox.ResumeLayout(false);
            this.TypeContextMenu.ResumeLayout(false);
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label SelectCellLabel;
        private ComboBox SteelCellsCombobox;
        private GroupBox TypesGroupBox;
        private GroupBox ConfigurationGroupBox;
        private ListBox CellTypesListBox;
        private Label PoseFittingLabel;
        private ComboBox PoseFittingComboBox;
        private ComboBox PaintPlanningComboBox;
        private Label PaintPlanningLabel;
        private ComboBox SegmentationComboBox;
        private Label SegmentationLabel;
        private ComboBox ClassificationComboBox;
        private Label ClassificationLabel;
        private Button SaveConfigBtn;
        private Button SettingsBtn;
        private ContextMenuStrip TypeContextMenu;
        private ToolStripMenuItem CloneSelectedTypeMenuItem;
        private ToolStripMenuItem NewTypeMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem EditSelectedTypeMenuItem;
        private ToolStripMenuItem DeleteSelectedTypeMenuItem;
    }
}