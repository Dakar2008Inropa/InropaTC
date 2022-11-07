namespace InropaTC
{
    public partial class SettingsForm : Form
    {
        public Setting setting;
        public SettingsForm(Setting setting)
        {
            this.setting = setting;
            InitializeComponent();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if(CoreTypeComboBox.SelectedIndex != -1)
            {
                setting.CoreType = CoreTypeComboBox.SelectedItem.ToString();
            }
            SettingHelper.SaveSettings(setting);
        }

        private void BrowseInstallationPathBtn_Click(object sender, EventArgs e)
        {
            if (InstallationPathBrowser.ShowDialog() == DialogResult.OK)
            {
                setting.InstallationPath = InstallationPathBrowser.SelectedPath;
                InstallationPathTextbox.Text = InstallationPathBrowser.SelectedPath;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            InstallationPathBrowser.Description = "Select folder where your Inropa Programmer Cell Is Located";
            InstallationPathBrowser.UseDescriptionForTitle = true;
            if (!string.IsNullOrEmpty(setting.InstallationPath))
            {
                InstallationPathTextbox.Text = setting.InstallationPath;

                InstallationPathBrowser.InitialDirectory = setting.InstallationPath;
            }
            if (string.IsNullOrEmpty(setting.CoreType))
            {
                foreach (var item in EnumUtil.GetEnumValues<CoreType>())
                {
                    CoreTypeComboBox.Items.Add(item.ToString());
                }
                CoreTypeComboBox.SelectedIndex = 0;
            }
            else
            {
                foreach (var item in EnumUtil.GetEnumValues<CoreType>())
                {
                    CoreTypeComboBox.Items.Add(item.ToString());
                }
                foreach (var item in CoreTypeComboBox.Items)
                {
                    if (item.ToString() == setting.CoreType)
                    {
                        CoreTypeComboBox.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
}