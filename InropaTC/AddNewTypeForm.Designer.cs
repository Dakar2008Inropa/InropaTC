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
            NameLabel = new Label();
            NameTextbox = new TextBox();
            PoseFittingLabel = new Label();
            PoseFittingCombobox = new ComboBox();
            PaintPlanningCombobox = new ComboBox();
            label1 = new Label();
            SegmentationCombobox = new ComboBox();
            label2 = new Label();
            ClassificationCombobox = new ComboBox();
            label3 = new Label();
            TouchPanelDisplayTextbox = new TextBox();
            TouchPanelDisplayTextLabel = new Label();
            TouchPanelInsertGroupBox = new GroupBox();
            CustomizeBtn = new Button();
            TouchPanelItems = new ListBox();
            AfterRadioBtn = new RadioButton();
            BeforeRadioBtn = new RadioButton();
            SaveBtn = new Button();
            CloneClassificationBtn = new Button();
            NewClassificationBtn = new Button();
            CloneSegmentationBtn = new Button();
            NewPaintPlanningBtn = new Button();
            ClonePaintPlanningBtn = new Button();
            ClonePoseFittingBtn = new Button();
            TouchPanelInsertGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(10, 10);
            NameLabel.Margin = new Padding(0, 0, 0, 5);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(236, 25);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameTextbox
            // 
            NameTextbox.BackColor = Color.White;
            NameTextbox.BorderStyle = BorderStyle.FixedSingle;
            NameTextbox.Location = new Point(10, 40);
            NameTextbox.Margin = new Padding(0, 0, 0, 5);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(677, 23);
            NameTextbox.TabIndex = 1;
            NameTextbox.Leave += NameTextbox_Leave;
            // 
            // PoseFittingLabel
            // 
            PoseFittingLabel.Location = new Point(10, 68);
            PoseFittingLabel.Margin = new Padding(0, 0, 0, 5);
            PoseFittingLabel.Name = "PoseFittingLabel";
            PoseFittingLabel.Size = new Size(236, 25);
            PoseFittingLabel.TabIndex = 2;
            PoseFittingLabel.Text = "Select PoseFitting:";
            PoseFittingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PoseFittingCombobox
            // 
            PoseFittingCombobox.BackColor = Color.White;
            PoseFittingCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            PoseFittingCombobox.FormattingEnabled = true;
            PoseFittingCombobox.Location = new Point(10, 98);
            PoseFittingCombobox.Margin = new Padding(0, 0, 5, 5);
            PoseFittingCombobox.Name = "PoseFittingCombobox";
            PoseFittingCombobox.Size = new Size(517, 24);
            PoseFittingCombobox.TabIndex = 3;
            // 
            // PaintPlanningCombobox
            // 
            PaintPlanningCombobox.BackColor = Color.White;
            PaintPlanningCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            PaintPlanningCombobox.FormattingEnabled = true;
            PaintPlanningCombobox.Location = new Point(10, 157);
            PaintPlanningCombobox.Margin = new Padding(0, 0, 5, 5);
            PaintPlanningCombobox.Name = "PaintPlanningCombobox";
            PaintPlanningCombobox.Size = new Size(517, 24);
            PaintPlanningCombobox.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(10, 127);
            label1.Margin = new Padding(0, 0, 0, 5);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 4;
            label1.Text = "Select PaintPlanning:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SegmentationCombobox
            // 
            SegmentationCombobox.BackColor = Color.White;
            SegmentationCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SegmentationCombobox.FormattingEnabled = true;
            SegmentationCombobox.Location = new Point(10, 216);
            SegmentationCombobox.Margin = new Padding(0, 0, 5, 5);
            SegmentationCombobox.Name = "SegmentationCombobox";
            SegmentationCombobox.Size = new Size(517, 24);
            SegmentationCombobox.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(10, 186);
            label2.Margin = new Padding(0, 0, 0, 5);
            label2.Name = "label2";
            label2.Size = new Size(236, 25);
            label2.TabIndex = 6;
            label2.Text = "Select Segmentation:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClassificationCombobox
            // 
            ClassificationCombobox.BackColor = Color.White;
            ClassificationCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassificationCombobox.FormattingEnabled = true;
            ClassificationCombobox.Location = new Point(10, 275);
            ClassificationCombobox.Margin = new Padding(0, 0, 5, 5);
            ClassificationCombobox.Name = "ClassificationCombobox";
            ClassificationCombobox.Size = new Size(517, 24);
            ClassificationCombobox.TabIndex = 9;
            // 
            // label3
            // 
            label3.Location = new Point(10, 245);
            label3.Margin = new Padding(0, 0, 0, 5);
            label3.Name = "label3";
            label3.Size = new Size(236, 25);
            label3.TabIndex = 8;
            label3.Text = "Select Classification:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TouchPanelDisplayTextbox
            // 
            TouchPanelDisplayTextbox.BackColor = Color.White;
            TouchPanelDisplayTextbox.BorderStyle = BorderStyle.FixedSingle;
            TouchPanelDisplayTextbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TouchPanelDisplayTextbox.Location = new Point(5, 49);
            TouchPanelDisplayTextbox.Margin = new Padding(0, 0, 5, 5);
            TouchPanelDisplayTextbox.Name = "TouchPanelDisplayTextbox";
            TouchPanelDisplayTextbox.Size = new Size(564, 23);
            TouchPanelDisplayTextbox.TabIndex = 11;
            // 
            // TouchPanelDisplayTextLabel
            // 
            TouchPanelDisplayTextLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TouchPanelDisplayTextLabel.Location = new Point(5, 19);
            TouchPanelDisplayTextLabel.Margin = new Padding(0, 0, 0, 5);
            TouchPanelDisplayTextLabel.Name = "TouchPanelDisplayTextLabel";
            TouchPanelDisplayTextLabel.Size = new Size(236, 25);
            TouchPanelDisplayTextLabel.TabIndex = 10;
            TouchPanelDisplayTextLabel.Text = "TouchPanel Display Text:";
            TouchPanelDisplayTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TouchPanelInsertGroupBox
            // 
            TouchPanelInsertGroupBox.Controls.Add(CustomizeBtn);
            TouchPanelInsertGroupBox.Controls.Add(TouchPanelItems);
            TouchPanelInsertGroupBox.Controls.Add(AfterRadioBtn);
            TouchPanelInsertGroupBox.Controls.Add(BeforeRadioBtn);
            TouchPanelInsertGroupBox.Controls.Add(TouchPanelDisplayTextLabel);
            TouchPanelInsertGroupBox.Controls.Add(TouchPanelDisplayTextbox);
            TouchPanelInsertGroupBox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TouchPanelInsertGroupBox.ForeColor = Color.White;
            TouchPanelInsertGroupBox.Location = new Point(10, 332);
            TouchPanelInsertGroupBox.Margin = new Padding(0, 0, 0, 10);
            TouchPanelInsertGroupBox.Name = "TouchPanelInsertGroupBox";
            TouchPanelInsertGroupBox.Padding = new Padding(5);
            TouchPanelInsertGroupBox.Size = new Size(677, 306);
            TouchPanelInsertGroupBox.TabIndex = 12;
            TouchPanelInsertGroupBox.TabStop = false;
            TouchPanelInsertGroupBox.Text = "TouchPanel Insert";
            // 
            // CustomizeBtn
            // 
            CustomizeBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomizeBtn.ForeColor = Color.Black;
            CustomizeBtn.Location = new Point(574, 49);
            CustomizeBtn.Margin = new Padding(0);
            CustomizeBtn.Name = "CustomizeBtn";
            CustomizeBtn.Size = new Size(98, 23);
            CustomizeBtn.TabIndex = 12;
            CustomizeBtn.Text = "Customize";
            CustomizeBtn.UseVisualStyleBackColor = true;
            CustomizeBtn.Click += CustomizeBtn_Click;
            // 
            // TouchPanelItems
            // 
            TouchPanelItems.BackColor = Color.White;
            TouchPanelItems.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TouchPanelItems.FormattingEnabled = true;
            TouchPanelItems.ItemHeight = 16;
            TouchPanelItems.Location = new Point(5, 102);
            TouchPanelItems.Margin = new Padding(0);
            TouchPanelItems.Name = "TouchPanelItems";
            TouchPanelItems.Size = new Size(667, 196);
            TouchPanelItems.TabIndex = 2;
            // 
            // AfterRadioBtn
            // 
            AfterRadioBtn.AutoSize = true;
            AfterRadioBtn.CheckAlign = ContentAlignment.MiddleRight;
            AfterRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AfterRadioBtn.Location = new Point(509, 77);
            AfterRadioBtn.Margin = new Padding(0, 0, 5, 5);
            AfterRadioBtn.Name = "AfterRadioBtn";
            AfterRadioBtn.Size = new Size(158, 20);
            AfterRadioBtn.TabIndex = 1;
            AfterRadioBtn.TabStop = true;
            AfterRadioBtn.Text = "After Selected Type";
            AfterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BeforeRadioBtn
            // 
            BeforeRadioBtn.AutoSize = true;
            BeforeRadioBtn.CheckAlign = ContentAlignment.MiddleRight;
            BeforeRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BeforeRadioBtn.Location = new Point(5, 77);
            BeforeRadioBtn.Margin = new Padding(0, 0, 5, 5);
            BeforeRadioBtn.Name = "BeforeRadioBtn";
            BeforeRadioBtn.Size = new Size(167, 20);
            BeforeRadioBtn.TabIndex = 0;
            BeforeRadioBtn.TabStop = true;
            BeforeRadioBtn.Text = "Before Selected Type";
            BeforeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(10, 648);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(677, 47);
            SaveBtn.TabIndex = 19;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CloneClassificationBtn
            // 
            CloneClassificationBtn.ForeColor = Color.Black;
            CloneClassificationBtn.Location = new Point(532, 276);
            CloneClassificationBtn.Margin = new Padding(0, 0, 5, 5);
            CloneClassificationBtn.Name = "CloneClassificationBtn";
            CloneClassificationBtn.Size = new Size(75, 23);
            CloneClassificationBtn.TabIndex = 15;
            CloneClassificationBtn.Text = "Clone";
            CloneClassificationBtn.UseVisualStyleBackColor = true;
            CloneClassificationBtn.Click += CloneClassificationBtn_Click;
            // 
            // NewClassificationBtn
            // 
            NewClassificationBtn.ForeColor = Color.Black;
            NewClassificationBtn.Location = new Point(612, 276);
            NewClassificationBtn.Margin = new Padding(0, 0, 0, 5);
            NewClassificationBtn.Name = "NewClassificationBtn";
            NewClassificationBtn.Size = new Size(75, 23);
            NewClassificationBtn.TabIndex = 16;
            NewClassificationBtn.Text = "New";
            NewClassificationBtn.UseVisualStyleBackColor = true;
            NewClassificationBtn.Click += NewClassificationBtn_Click;
            // 
            // CloneSegmentationBtn
            // 
            CloneSegmentationBtn.ForeColor = Color.Black;
            CloneSegmentationBtn.Location = new Point(532, 217);
            CloneSegmentationBtn.Margin = new Padding(0, 0, 5, 5);
            CloneSegmentationBtn.Name = "CloneSegmentationBtn";
            CloneSegmentationBtn.Size = new Size(155, 23);
            CloneSegmentationBtn.TabIndex = 18;
            CloneSegmentationBtn.Text = "Clone";
            CloneSegmentationBtn.UseVisualStyleBackColor = true;
            CloneSegmentationBtn.Click += CloneSegmentationBtn_Click;
            // 
            // NewPaintPlanningBtn
            // 
            NewPaintPlanningBtn.ForeColor = Color.Black;
            NewPaintPlanningBtn.Location = new Point(612, 158);
            NewPaintPlanningBtn.Margin = new Padding(0, 0, 0, 5);
            NewPaintPlanningBtn.Name = "NewPaintPlanningBtn";
            NewPaintPlanningBtn.Size = new Size(75, 23);
            NewPaintPlanningBtn.TabIndex = 14;
            NewPaintPlanningBtn.Text = "New";
            NewPaintPlanningBtn.UseVisualStyleBackColor = true;
            NewPaintPlanningBtn.Click += NewPaintPlanningBtn_Click;
            // 
            // ClonePaintPlanningBtn
            // 
            ClonePaintPlanningBtn.ForeColor = Color.Black;
            ClonePaintPlanningBtn.Location = new Point(532, 158);
            ClonePaintPlanningBtn.Margin = new Padding(0, 0, 5, 5);
            ClonePaintPlanningBtn.Name = "ClonePaintPlanningBtn";
            ClonePaintPlanningBtn.Size = new Size(75, 23);
            ClonePaintPlanningBtn.TabIndex = 13;
            ClonePaintPlanningBtn.Text = "Clone";
            ClonePaintPlanningBtn.UseVisualStyleBackColor = true;
            ClonePaintPlanningBtn.Click += ClonePaintPlanningBtn_Click;
            // 
            // ClonePoseFittingBtn
            // 
            ClonePoseFittingBtn.ForeColor = Color.Black;
            ClonePoseFittingBtn.Location = new Point(532, 99);
            ClonePoseFittingBtn.Margin = new Padding(0, 0, 5, 5);
            ClonePoseFittingBtn.Name = "ClonePoseFittingBtn";
            ClonePoseFittingBtn.Size = new Size(155, 23);
            ClonePoseFittingBtn.TabIndex = 17;
            ClonePoseFittingBtn.Text = "Clone";
            ClonePoseFittingBtn.UseVisualStyleBackColor = true;
            ClonePoseFittingBtn.Click += ClonePoseFittingBtn_Click;
            // 
            // AddNewTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 65, 77);
            ClientSize = new Size(697, 705);
            Controls.Add(SaveBtn);
            Controls.Add(CloneSegmentationBtn);
            Controls.Add(ClonePoseFittingBtn);
            Controls.Add(NewClassificationBtn);
            Controls.Add(CloneClassificationBtn);
            Controls.Add(NewPaintPlanningBtn);
            Controls.Add(ClonePaintPlanningBtn);
            Controls.Add(TouchPanelInsertGroupBox);
            Controls.Add(ClassificationCombobox);
            Controls.Add(label3);
            Controls.Add(SegmentationCombobox);
            Controls.Add(label2);
            Controls.Add(PaintPlanningCombobox);
            Controls.Add(label1);
            Controls.Add(PoseFittingCombobox);
            Controls.Add(PoseFittingLabel);
            Controls.Add(NameTextbox);
            Controls.Add(NameLabel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddNewTypeForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Type";
            Load += AddNewTypeForm_Load;
            TouchPanelInsertGroupBox.ResumeLayout(false);
            TouchPanelInsertGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button CustomizeBtn;
    }
}