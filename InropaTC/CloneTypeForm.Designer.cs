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
            SaveBtn = new Button();
            TouchPanelInsertGroupBox = new GroupBox();
            CustomizeBtn = new Button();
            TouchPanelItems = new ListBox();
            AfterRadioBtn = new RadioButton();
            BeforeRadioBtn = new RadioButton();
            TouchPanelDisplayTextLabel = new Label();
            TouchPanelDisplayTextbox = new TextBox();
            TypeConfigGroupBox = new GroupBox();
            PaintTypeNumber = new NumericUpDown();
            UseMultiplePaintTypeCheckbox = new CheckBox();
            NameLabel = new Label();
            NameTextbox = new TextBox();
            TouchPanelInsertGroupBox.SuspendLayout();
            TypeConfigGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaintTypeNumber).BeginInit();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(9, 439);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(677, 47);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
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
            TouchPanelInsertGroupBox.Location = new Point(9, 123);
            TouchPanelInsertGroupBox.Margin = new Padding(0, 0, 0, 10);
            TouchPanelInsertGroupBox.Name = "TouchPanelInsertGroupBox";
            TouchPanelInsertGroupBox.Padding = new Padding(5);
            TouchPanelInsertGroupBox.Size = new Size(677, 306);
            TouchPanelInsertGroupBox.TabIndex = 2;
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
            CustomizeBtn.TabIndex = 9;
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
            TouchPanelItems.TabIndex = 6;
            // 
            // AfterRadioBtn
            // 
            AfterRadioBtn.AutoSize = true;
            AfterRadioBtn.CheckAlign = ContentAlignment.MiddleRight;
            AfterRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AfterRadioBtn.Location = new Point(511, 79);
            AfterRadioBtn.Margin = new Padding(0, 0, 5, 5);
            AfterRadioBtn.Name = "AfterRadioBtn";
            AfterRadioBtn.Size = new Size(158, 20);
            AfterRadioBtn.TabIndex = 5;
            AfterRadioBtn.TabStop = true;
            AfterRadioBtn.Text = "After Selected Type";
            AfterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BeforeRadioBtn
            // 
            BeforeRadioBtn.AutoSize = true;
            BeforeRadioBtn.CheckAlign = ContentAlignment.MiddleRight;
            BeforeRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BeforeRadioBtn.Location = new Point(7, 79);
            BeforeRadioBtn.Margin = new Padding(0, 0, 5, 5);
            BeforeRadioBtn.Name = "BeforeRadioBtn";
            BeforeRadioBtn.Size = new Size(167, 20);
            BeforeRadioBtn.TabIndex = 4;
            BeforeRadioBtn.TabStop = true;
            BeforeRadioBtn.Text = "Before Selected Type";
            BeforeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TouchPanelDisplayTextLabel
            // 
            TouchPanelDisplayTextLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TouchPanelDisplayTextLabel.Location = new Point(5, 19);
            TouchPanelDisplayTextLabel.Margin = new Padding(0, 0, 0, 5);
            TouchPanelDisplayTextLabel.Name = "TouchPanelDisplayTextLabel";
            TouchPanelDisplayTextLabel.Size = new Size(236, 25);
            TouchPanelDisplayTextLabel.TabIndex = 7;
            TouchPanelDisplayTextLabel.Text = "TouchPanel Display Text:";
            TouchPanelDisplayTextLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            TouchPanelDisplayTextbox.TabIndex = 3;
            // 
            // TypeConfigGroupBox
            // 
            TypeConfigGroupBox.Controls.Add(PaintTypeNumber);
            TypeConfigGroupBox.Controls.Add(UseMultiplePaintTypeCheckbox);
            TypeConfigGroupBox.Controls.Add(NameLabel);
            TypeConfigGroupBox.Controls.Add(NameTextbox);
            TypeConfigGroupBox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TypeConfigGroupBox.ForeColor = Color.White;
            TypeConfigGroupBox.Location = new Point(9, 9);
            TypeConfigGroupBox.Margin = new Padding(0, 0, 0, 5);
            TypeConfigGroupBox.Name = "TypeConfigGroupBox";
            TypeConfigGroupBox.Padding = new Padding(5);
            TypeConfigGroupBox.Size = new Size(677, 109);
            TypeConfigGroupBox.TabIndex = 21;
            TypeConfigGroupBox.TabStop = false;
            TypeConfigGroupBox.Text = "Type Configuration";
            // 
            // PaintTypeNumber
            // 
            PaintTypeNumber.BorderStyle = BorderStyle.FixedSingle;
            PaintTypeNumber.Enabled = false;
            PaintTypeNumber.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PaintTypeNumber.Location = new Point(198, 79);
            PaintTypeNumber.Margin = new Padding(0);
            PaintTypeNumber.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            PaintTypeNumber.Name = "PaintTypeNumber";
            PaintTypeNumber.Size = new Size(474, 23);
            PaintTypeNumber.TabIndex = 3;
            PaintTypeNumber.TextAlign = HorizontalAlignment.Center;
            PaintTypeNumber.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // UseMultiplePaintTypeCheckbox
            // 
            UseMultiplePaintTypeCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            UseMultiplePaintTypeCheckbox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UseMultiplePaintTypeCheckbox.Location = new Point(5, 79);
            UseMultiplePaintTypeCheckbox.Margin = new Padding(0, 0, 5, 0);
            UseMultiplePaintTypeCheckbox.Name = "UseMultiplePaintTypeCheckbox";
            UseMultiplePaintTypeCheckbox.Size = new Size(188, 23);
            UseMultiplePaintTypeCheckbox.TabIndex = 2;
            UseMultiplePaintTypeCheckbox.Text = "Use Multiple Paint Type";
            UseMultiplePaintTypeCheckbox.UseVisualStyleBackColor = true;
            UseMultiplePaintTypeCheckbox.CheckedChanged += UseMultiplePaintTypeCheckbox_CheckedChanged;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(5, 21);
            NameLabel.Margin = new Padding(0, 0, 0, 5);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(667, 25);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameTextbox
            // 
            NameTextbox.BackColor = Color.White;
            NameTextbox.BorderStyle = BorderStyle.FixedSingle;
            NameTextbox.Location = new Point(5, 51);
            NameTextbox.Margin = new Padding(0, 0, 0, 5);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(667, 23);
            NameTextbox.TabIndex = 1;
            NameTextbox.Leave += NameTextbox_Leave;
            // 
            // CloneTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 65, 77);
            ClientSize = new Size(697, 493);
            Controls.Add(TypeConfigGroupBox);
            Controls.Add(SaveBtn);
            Controls.Add(TouchPanelInsertGroupBox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CloneTypeForm";
            Padding = new Padding(11, 9, 11, 9);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clone";
            Load += CloneTypeForm_Load;
            TouchPanelInsertGroupBox.ResumeLayout(false);
            TouchPanelInsertGroupBox.PerformLayout();
            TypeConfigGroupBox.ResumeLayout(false);
            TypeConfigGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaintTypeNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button SaveBtn;
        private GroupBox TouchPanelInsertGroupBox;
        private ListBox TouchPanelItems;
        private RadioButton AfterRadioBtn;
        private RadioButton BeforeRadioBtn;
        private Label TouchPanelDisplayTextLabel;
        private TextBox TouchPanelDisplayTextbox;
        private Button CustomizeBtn;
        private GroupBox TypeConfigGroupBox;
        private NumericUpDown PaintTypeNumber;
        private CheckBox UseMultiplePaintTypeCheckbox;
        private Label NameLabel;
        private TextBox NameTextbox;
    }
}