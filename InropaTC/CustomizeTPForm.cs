namespace InropaTC
{
    public partial class CustomizeTPForm : Form
    {
        public TouchPanelClass tpc { get; set; }

        public CustomizeTPForm(TouchPanelClass touchPanelClass)
        {
            tpc = touchPanelClass;
            if (tpc == null)
            {
                tpc = new TouchPanelClass();
            }
            InitializeComponent();
        }

        private void CustomizeTPForm_Load(object sender, EventArgs e)
        {
            if (tpc.UseCustomColors)
            {
                UseCustomColorCheckbox.Checked = true;
            }
            else
            {
                UseCustomColorCheckbox.Checked = false;
            }
            if (!string.IsNullOrEmpty(tpc.BackgroundColor))
            {
                BackgroundColorBox.BackColor = ColorConverter.HexToRgb(tpc.BackgroundColor, tpc.BackgroundTransparency);
            }
            else
            {
                BackgroundColorBox.BackColor = Color.Silver;
            }
            if (!string.IsNullOrEmpty(tpc.ForegroundColor))
            {
                ForegroundColorBox.BackColor = ColorConverter.HexToRgb(tpc.ForegroundColor, tpc.ForegroundTransparency);
            }
            else
            {
                ForegroundColorBox.BackColor = Color.Black;
            }
        }

        private void UseCustomColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseCustomColorCheckbox.Checked)
            {
                tpc.UseCustomColors = true;
                CustomColorGroupBox.Enabled = true;
            }
            else
            {
                tpc.UseCustomColors = false;
                CustomColorGroupBox.Enabled = false;
            }
        }

        private void BackgroundColorBox_DoubleClick(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    BackgroundColorBox.BackColor = selectedColor;
                }
            }
        }

        private void ForegroundColorBox_DoubleClick(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    ForegroundColorBox.BackColor = selectedColor;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            tpc.BackgroundColor = $"#{BackgroundColorBox.BackColor.R.ToString("X2")}{BackgroundColorBox.BackColor.G.ToString("X2")}{BackgroundColorBox.BackColor.B.ToString("X2")}";
            tpc.ForegroundColor = $"#{ForegroundColorBox.BackColor.R.ToString("X2")}{ForegroundColorBox.BackColor.G.ToString("X2")}{ForegroundColorBox.BackColor.B.ToString("X2")}";
            tpc.BackgroundTransparency = (int)BGTransBox.Value;
            tpc.ForegroundTransparency = (int)FGTransBox.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}