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

        private void LoadCellData(string lastusedcell = null)
        {
            if (Helper.CheckIfMultipleCellsFound(setting))
            {
                NewTypeMenuItem.Visible = true;
                toolStripSeparator1.Visible = true;
                LoadCells(lastusedcell);
            }
            else
            {
                NewTypeMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
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
                string filename = Path.GetFileNameWithoutExtension(item.Name);
                tps.Type = filename.Substring(filename.IndexOf('_') + 1);
                tps.TypeId = int.Parse(splitFileName[0]);
                TouchPanelClass tpc = JSONHelper.DeserializeObject<TouchPanelClass>(tps.Filename);
                tps.FileSetting = tpc;
                tps.DisplayName = tps.FileSetting.GuiDescription;
                TouchPanelSettings.Add(tps);
            }
        }

        private void LoadCell()
        {
            CellHelper = Helper.GetSteelCell(setting);
            if(string.IsNullOrEmpty(CellHelper.Name) || string.IsNullOrEmpty(CellHelper.FolderPath))
            {
                if(MessageBox.Show($"We could not find any cell that is useable, please add cell to {setting.InstallationPath} Application Will Now Exit", "No Cell Found!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                cell = Helper.GetCellData(CellHelper);
                CellTypesListBox.DataSource = cell.Types;
                CellTypesListBox.DisplayMember = "Name";
                SteelCellsCombobox.Visible = false;
                SelectCellLabel.Visible = false;
            }
        }
        
        private void LoadCells(string lastusedcell = null)
        {
            CellList = Helper.GetSteelCells(setting);
            SteelCellsCombobox.DataSource = CellList;
            SteelCellsCombobox.DisplayMember = "Name";

            if(lastusedcell != null)
            {
                SteelCellsCombobox.SelectedItem = CellList.Find(x => x.Name == lastusedcell);
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastUsedCell))
            {
                SteelCellsCombobox.SelectedItem = CellList.Find(x => x.Name == Properties.Settings.Default.LastUsedCell);
            }

            SteelCellsCombobox.Visible = true;
            SelectCellLabel.Visible = true;

            SteelCellsCombobox.Enabled = true;
            SelectCellLabel.Enabled = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var selectedCell = SteelCellsCombobox.SelectedItem as CellListHelper;

            Properties.Settings.Default.WindowPositionX = this.Location.X;
            Properties.Settings.Default.WindowPositionY = this.Location.Y;
            if(Helper.CheckIfMultipleCellsFound(setting))
            {
                Properties.Settings.Default.LastUsedCell = selectedCell.Name;
            }
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
            TypesGroupBox.Enabled = true;
            if (CellTypesListBox.SelectedIndex != -1)
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
                string tempvalue;
                if (itemValue.Path.Contains(','))
                {
                    tempvalue = itemValue.Path.Split(',')[0];
                }
                else
                {
                    tempvalue = itemValue.Path;
                }
                if (tempvalue == Type)
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
            //UpdateCellType(SegmentationComboBox, selectedType.Name, cell.Segmentation);
            //JSONHelper.WriteToJsonFile(cell.Segmentation, cell.SegmentationWorkPiecePath);
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

        private void DeleteCellType(string Type, JToken token, string folderpath, bool deletefile = true)
        {
            foreach (var item in token.Children())
            {
                var itemProp = item as JProperty;
                if (itemProp.Name.Split(',')[0] == Type)
                {
                    JValue jvalue = itemProp.Children().FirstOrDefault() as JValue;
                    if (deletefile)
                    {
                        if (File.Exists(Path.Combine(folderpath, jvalue.Value.ToString())))
                        {
                            File.Delete(Path.Combine(folderpath, jvalue.Value.ToString()));
                        }
                    }
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
            var selectedCell = SteelCellsCombobox.SelectedItem as CellListHelper;
            DeleteCellType(selectedType.Name, cell.PoseFitting, cell.PoseFittingFolderPath, false);
            JSONHelper.WriteToJsonFile(cell.PoseFitting, cell.PoseFittingWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.PaintPlanning, cell.PaintPlanningFolderPath);
            JSONHelper.WriteToJsonFile(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.Segmentation, cell.SegmentationFolderPath, false);
            JSONHelper.WriteToJsonFile(cell.Segmentation, cell.SegmentationWorkPiecePath);
            DeleteCellType(selectedType.Name, cell.Classification, cell.ClassificationFolderPath);
            JSONHelper.WriteToJsonFile(cell.Classification, cell.ClassificationWorkPiecePath);

            if(TouchPanelSettings.Count > 0)
            {
                TouchPanelSetting tps = TouchPanelSettings.Where(x => x.Type == selectedType.Name).FirstOrDefault();
                if (tps != null)
                {
                    if (File.Exists(tps.Filename))
                    {
                        File.Delete(tps.Filename);
                    }
                    var tempTouchPanels = TouchPanelSettings.Where(x => x.TypeId > tps.TypeId).ToList();
                    foreach (var item in tempTouchPanels)
                    {
                        item.TypeId -= 1;

                        if (File.Exists(item.Filename))
                        {
                            File.Delete(item.Filename);
                        }
                        string newFilename = $"{item.TypeId.ToString().PadLeft(2, '0')}_{item.Type}.json";

                        JSONHelper.SerializeObject(item.FileSetting, Path.Combine(TouchPanelPath, newFilename));
                    }
                }
            }
            if (Helper.CheckIfMultipleCellsFound(setting))
            {
                LoadCellData(selectedCell.Name);
            }
            else
            {
                LoadCellData();
            }
        }

        private void DeleteTypeBtn_Click(object sender, EventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            if (MessageBox.Show($"Are you sure you want to delete {selectedType.Name}", $"Delete {selectedType.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DeleteType();
            }
        }

        private void EditTypeBtn_Click(object sender, EventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            var selectedCell = SteelCellsCombobox.SelectedItem as CellListHelper;
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
            if (Helper.CheckIfMultipleCellsFound(setting))
            {
                LoadCellData(selectedCell.Name);
            }
            else
            {
                LoadCellData();
            }
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
            var selectedCell = SteelCellsCombobox.SelectedItem as CellListHelper;
            AddNewTypeForm newTypeForm = new AddNewTypeForm(setting, cell, CellList);
            if(newTypeForm.ShowDialog() == DialogResult.OK)
            {
                if (Helper.CheckIfMultipleCellsFound(setting))
                {
                    LoadCellData(selectedCell.Name);
                }
                else
                {
                    LoadCellData();
                }
            }
        }

        private void CloneSelectedTypeMenuItem_Click(object sender, EventArgs e)
        {
            var selectedType = CellTypesListBox.SelectedItem as SteelTypes;
            var selectedCell = SteelCellsCombobox.SelectedItem as CellListHelper;
            CloneTypeForm cloneTypeForm = new CloneTypeForm(setting, cell, CellList, selectedType.Name);
            if(cloneTypeForm.ShowDialog() == DialogResult.OK)
            {
                if (Helper.CheckIfMultipleCellsFound(setting))
                {
                    LoadCellData(selectedCell.Name);
                }
                else
                {
                    LoadCellData();
                }
            }
        }
    }
}