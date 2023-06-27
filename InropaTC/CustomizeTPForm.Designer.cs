namespace InropaTC
{
    partial class CustomizeTPForm
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
            BackgroundColorBox = new PictureBox();
            ForegroundColorBox = new PictureBox();
            CustomColorGroupBox = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            FGTransBox = new NumericUpDown();
            BGTransBox = new NumericUpDown();
            UseCustomColorCheckbox = new CheckBox();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BackgroundColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForegroundColorBox).BeginInit();
            CustomColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FGTransBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BGTransBox).BeginInit();
            SuspendLayout();
            // 
            // BackgroundColorBox
            // 
            BackgroundColorBox.BackColor = Color.Silver;
            BackgroundColorBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundColorBox.Cursor = Cursors.Hand;
            BackgroundColorBox.Location = new Point(5, 44);
            BackgroundColorBox.Margin = new Padding(0, 0, 5, 5);
            BackgroundColorBox.Name = "BackgroundColorBox";
            BackgroundColorBox.Size = new Size(129, 23);
            BackgroundColorBox.TabIndex = 0;
            BackgroundColorBox.TabStop = false;
            BackgroundColorBox.DoubleClick += BackgroundColorBox_DoubleClick;
            // 
            // ForegroundColorBox
            // 
            ForegroundColorBox.BackColor = Color.Black;
            ForegroundColorBox.BorderStyle = BorderStyle.FixedSingle;
            ForegroundColorBox.Cursor = Cursors.Hand;
            ForegroundColorBox.Location = new Point(139, 44);
            ForegroundColorBox.Margin = new Padding(0, 0, 5, 0);
            ForegroundColorBox.Name = "ForegroundColorBox";
            ForegroundColorBox.Size = new Size(129, 23);
            ForegroundColorBox.TabIndex = 2;
            ForegroundColorBox.TabStop = false;
            ForegroundColorBox.DoubleClick += ForegroundColorBox_DoubleClick;
            // 
            // CustomColorGroupBox
            // 
            CustomColorGroupBox.Controls.Add(label2);
            CustomColorGroupBox.Controls.Add(label1);
            CustomColorGroupBox.Controls.Add(FGTransBox);
            CustomColorGroupBox.Controls.Add(BGTransBox);
            CustomColorGroupBox.Controls.Add(BackgroundColorBox);
            CustomColorGroupBox.Controls.Add(ForegroundColorBox);
            CustomColorGroupBox.Enabled = false;
            CustomColorGroupBox.FlatStyle = FlatStyle.Flat;
            CustomColorGroupBox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CustomColorGroupBox.ForeColor = Color.White;
            CustomColorGroupBox.Location = new Point(5, 40);
            CustomColorGroupBox.Margin = new Padding(0, 0, 0, 5);
            CustomColorGroupBox.Name = "CustomColorGroupBox";
            CustomColorGroupBox.Padding = new Padding(5);
            CustomColorGroupBox.Size = new Size(275, 103);
            CustomColorGroupBox.TabIndex = 4;
            CustomColorGroupBox.TabStop = false;
            CustomColorGroupBox.Text = "Custom Color";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(139, 21);
            label2.Margin = new Padding(0, 0, 0, 5);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 7;
            label2.Text = "Foreground Color";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 21);
            label1.Margin = new Padding(0, 0, 0, 5);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 6;
            label1.Text = "Background Color";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FGTransBox
            // 
            FGTransBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FGTransBox.Location = new Point(139, 72);
            FGTransBox.Margin = new Padding(0);
            FGTransBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            FGTransBox.Name = "FGTransBox";
            FGTransBox.Size = new Size(129, 23);
            FGTransBox.TabIndex = 5;
            FGTransBox.TextAlign = HorizontalAlignment.Center;
            FGTransBox.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // BGTransBox
            // 
            BGTransBox.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BGTransBox.Location = new Point(5, 72);
            BGTransBox.Margin = new Padding(0);
            BGTransBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            BGTransBox.Name = "BGTransBox";
            BGTransBox.Size = new Size(129, 23);
            BGTransBox.TabIndex = 4;
            BGTransBox.TextAlign = HorizontalAlignment.Center;
            BGTransBox.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // UseCustomColorCheckbox
            // 
            UseCustomColorCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            UseCustomColorCheckbox.ForeColor = Color.White;
            UseCustomColorCheckbox.Location = new Point(5, 5);
            UseCustomColorCheckbox.Margin = new Padding(0, 0, 0, 5);
            UseCustomColorCheckbox.Name = "UseCustomColorCheckbox";
            UseCustomColorCheckbox.Size = new Size(275, 30);
            UseCustomColorCheckbox.TabIndex = 5;
            UseCustomColorCheckbox.Text = "Use Custom Colors";
            UseCustomColorCheckbox.UseVisualStyleBackColor = true;
            UseCustomColorCheckbox.CheckedChanged += UseCustomColorCheckbox_CheckedChanged;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(5, 148);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(275, 34);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CustomizeTPForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 65, 77);
            ClientSize = new Size(285, 188);
            Controls.Add(SaveBtn);
            Controls.Add(UseCustomColorCheckbox);
            Controls.Add(CustomColorGroupBox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomizeTPForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customize";
            Load += CustomizeTPForm_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForegroundColorBox).EndInit();
            CustomColorGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FGTransBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BGTransBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BackgroundColorBox;
        private PictureBox ForegroundColorBox;
        private GroupBox CustomColorGroupBox;
        private CheckBox UseCustomColorCheckbox;
        private NumericUpDown BGTransBox;
        private NumericUpDown FGTransBox;
        private Label label2;
        private Label label1;
        private Button SaveBtn;
    }
}