using Newtonsoft.Json.Linq;

namespace InropaTC
{
    public partial class Main : Form
    {
        private Setting setting;
        private SteelCell cell;
        private List<CellListHelper> CellList;
        private CellListHelper CellHelper;
        private List<TouchPanelSetting> TouchPanelSettings = new List<TouchPanelSetting>();
        private string TouchPanelPath = $@"c:\ProgramData\Inropa\Touchpanel\Settings\Actions\";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadLastWindowPosition();
            setting = SettingHelper.LoadSettings();
            if (string.IsNullOrEmpty(setting.InstallationPath))
            {
                setting = Helper.LoadSettings(setting);
            }
            LoadCellData();
        }

        private void LoadLastWindowPosition()
        {
            this.Location = new Point(Properties.Settings.Default.WindowPositionX, Properties.Settings.Default.WindowPositionY);
        }

        private void LoadCellData()
        {
            if (Helper.CheckIfMultipleCellsFound(setting))
            {
                LoadCells();
            }
            else
            {
                LoadTouchPanelSettings();
                LoadCell();
            }
        }

        private void LoadTouchPanelSettings()
        {
            DirectoryInfo dir = new DirectoryInfo(TouchPanelPath);
            TouchPanelSettings.Clear();
            foreach (FileInfo item in dir.GetFiles())
            {
                TouchPanelSetting tps = new TouchPanelSetting();
                tps.Filename = item.FullName;
                string[] splitFileName = Path.GetFileNameWithoutExtension(item.Name).Split('_');
                tps.Type = splitFileName[1];
                tps.TypeId = int.Parse(splitFileName[0]);
                TouchPanelClass tpc = JSONHelper.DeserializeObject<TouchPanelClass>(tps.Filename);
                tps.FileSetting = tpc;
                TouchPanelSettings.Add(tps);
            }
        }

        private void LoadCell()
        {
            CellHelper = Helper.GetSteelCell(setting);
            cell = Helper.GetCellData(CellHelper);
            CellTypesListBox.DataSource = cell.Types;
            CellTypesListBox.DisplayMember = "Name";
            SteelCellsCombobox.Visible = false;
            SelectCellLabel.Visible = false;
        }
        
        private void LoadCells()
        {
            CellList = Helper.GetSteelCells(setting);
            SteelCellsCombobox.DataSource = CellList;
            SteelCellsCombobox.DisplayMember = "Name";

            SteelCellsCombobox.Visible = true;
            SelectCellLabel.Visible = true;

            SteelCellsCombobox.Enabled = true;
            SelectCellLabel.Enabled = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowPositionX = this.Location.X;
            Properties.Settings.Default.WindowPositionY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void SteelCellsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypesGroupBox.Enabled = true;
            CellTypesListBox.ClearSelected();
            CellTypesListBox.DataSource = null;
            CellListHelper listHelper = SteelCellsCombobox.SelectedItem as CellListHelper;
            cell = Helper.GetCellData(listHelper);
            CellTypesListBox.DataSource = cell.Types;
            CellTypesListBox.DisplayMember = "Name";
        }

        private void CellTypesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CellTypesListBox.SelectedIndex != -1)
            {
                var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
                ConfigurationGroupBox.Enabled = true;
                PopulateTypeCombo(PoseFittingComboBox, cell.PoseFittingFolderPath);
                PopulateTypeCombo(PaintPlanningComboBox, cell.PaintPlanningFolderPath);
                PopulateTypeCombo(SegmentationComboBox, cell.SegmentationFolderPath);
                PopulateTypeCombo(ClassificationComboBox, cell.ClassificationFolderPath);
                SelectCurrentConfig(PoseFittingComboBox, selectedType.Name, cell.PoseFitting);
                SelectCurrentConfig(PaintPlanningComboBox, selectedType.Name, cell.PaintPlanning);
                SelectCurrentConfig(SegmentationComboBox, selectedType.Name, cell.Segmentation);
                SelectCurrentConfig(ClassificationComboBox, selectedType.Name, cell.Classification);
            }
        }

        private void PopulateTypeCombo(ComboBox combo, string ConfigPath)
        {
            combo.DataSource = Helper.GetConfigFiles(ConfigPath);
            combo.DisplayMember = "Name";
        }
        
        private void SelectCurrentConfig(ComboBox combo, string Type, JToken token)
        {
            string configFile = "";
            foreach (var item in token.Children())
            {
                var itemValue = item.FirstOrDefault() as JValue;
                if (itemValue.Path == Type)
                {
                    configFile = Path.GetFileNameWithoutExtension(itemValue.Value.ToString());
                    break;
                }
            }
            foreach (ListClass item in combo.Items)
            {
                if (item.Name == configFile)
                {
                    combo.SelectedItem = item;
                    break;
                }
            }
        }

        private void SaveConfigBtn_Click(object sender, EventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            UpdateCellType(PoseFittingComboBox, selectedType.Name, cell.PoseFitting);
            JSONHelper.WriteToJsonFile(cell.PoseFitting, cell.PoseFittingWorkPiecePath);
            UpdateCellType(PaintPlanningComboBox, selectedType.Name, cell.PaintPlanning);
            JSONHelper.WriteToJsonFile(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath);
            UpdateCellType(SegmentationComboBox, selectedType.Name, cell.Segmentation);
            JSONHelper.WriteToJsonFile(cell.Segmentation, cell.SegmentationWorkPiecePath);
            UpdateCellType(ClassificationComboBox, selectedType.Name, cell.Classification);
            JSONHelper.WriteToJsonFile(cell.Classification, cell.ClassificationWorkPiecePath);
        }
        
        private void UpdateCellType(ComboBox combo, string Type, JToken token)
        {
            foreach (var item in token.Children())
            {
                var itemValue = item.FirstOrDefault() as JValue;
                if (itemValue.Path == Type)
                {
                    itemValue.Value = (combo.SelectedItem as ListClass).Value;
                    break;
                }
            }
        }

        private void DeleteCellType(string Type, JToken token)
        {
            foreach (var item in token.Children())
            {
                var itemProp = item as JProperty;
                if(itemProp.Name == Type)
                {
                    itemProp.Remove();
                    break;
                }
            }
        }

        private void EditCellType(EditTypeClass etc, JToken token)
        {
            var tokenObj = token as JObject;
            JProperty selectedJProp = null;
            foreach (var item in token.Children())
            {
                var itemJprop = item as JProperty;
                if (itemJprop.Name == etc.OldName)
                {
                    selectedJProp = itemJprop;
                    break;
                }
            }
            JProperty newJProp = new JProperty(etc.NewName, selectedJProp.Value);
            selectedJProp.Replace(newJProp);
        }

        private void DeleteType()
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            DeleteCellType(selectedType.Name, cell.PoseFitting);
            JSONHelper.WriteToJsonFile(cell.PoseFitting, cell.PoseFittingWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.PaintPlanning);
            JSONHelper.WriteToJsonFile(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.Segmentation);
            JSONHelper.WriteToJsonFile(cell.Segmentation, cell.SegmentationWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.Classification);
            JSONHelper.WriteToJsonFile(cell.Classification, cell.ClassificationWorkPiecePath);

            LoadCells();
        }

        private void DeleteTypeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this type?", "Delete Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DeleteType();
            }
        }

        private void EditTypeBtn_Click(object sender, EventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            EditTypeForm etf = new EditTypeForm(selectedType.Name);
            var result = etf.ShowDialog();
            if(result == DialogResult.OK)
            {
                EditTypeClass etc = etf.ETC;
                EditCellType(etc, cell.PoseFitting);
                JSONHelper.WriteToJsonFile(cell.PoseFitting, cell.PoseFittingWorkPiecePath);
                EditCellType(etc, cell.PaintPlanning);
                JSONHelper.WriteToJsonFile(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath);
                EditCellType(etc, cell.Segmentation);
                JSONHelper.WriteToJsonFile(cell.Segmentation, cell.SegmentationWorkPiecePath);
                EditCellType(etc, cell.Classification);
                JSONHelper.WriteToJsonFile(cell.Classification, cell.ClassificationWorkPiecePath);

                if (!Helper.CheckIfMultipleCellsFound(setting))
                {
                    TouchPanelSetting old_tps = TouchPanelSettings.Where(m => m.Type == etc.OldName).FirstOrDefault();
                    if (old_tps != null)
                    {
                        TouchPanelClass tpc = new TouchPanelClass();
                        tpc.Filename = etc.NewName;
                        tpc.GuiDescription = old_tps.FileSetting.GuiDescription;
                        JSONHelper.SerializeObject(tpc, Path.Combine(TouchPanelPath, $"{old_tps.TypeId}_{etc.NewName}.json"));
                    }
                    File.Delete(old_tps.Filename);
                    LoadTouchPanelSettings();
                }
            }
            LoadCells();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Helper.LoadSettings(setting);
            LoadCellData();
        }

        private void TypeContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            CloneSelectedTypeMenuItem.Text = $"Clone {selectedType.Name}";
            EditSelectedTypeMenuItem.Text = $"Edit {selectedType.Name}";
            DeleteSelectedTypeMenuItem.Text = $"Delete {selectedType.Name}";
        }

        private void NewTypeMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTypeForm newTypeForm = new AddNewTypeForm(setting, cell, CellList);
            if(newTypeForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}