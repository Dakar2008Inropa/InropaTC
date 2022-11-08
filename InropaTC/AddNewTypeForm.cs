using Newtonsoft.Json.Linq;
using System.Data;

namespace InropaTC
{
    public partial class AddNewTypeForm : Form
    {
        private Setting setting;
        private SteelCell cell;
        private List<CellListHelper> CellList;
        private bool MultipleCells;
        private List<TouchPanelSetting> TouchPanelSettings = new List<TouchPanelSetting>();
        private string TouchPanelPath = $@"c:\ProgramData\Inropa\Touchpanel\Settings\Actions\";
        string NewTypeName = "";
        public AddNewTypeForm(Setting setting, SteelCell cell, List<CellListHelper> CellList)
        {
            this.setting = setting;
            this.cell = cell;
            this.CellList = CellList;
            this.MultipleCells = Helper.CheckIfMultipleCellsFound(setting);
            InitializeComponent();
        }

        private void PopulateTypeCombo(ComboBox combo, string ConfigPath, string newestItem = null)
        {
            combo.DataSource = null;
            combo.Items.Clear();
            combo.DataSource = Helper.GetConfigFiles(ConfigPath);
            combo.DisplayMember = "Name";

            if (!string.IsNullOrEmpty(newestItem))
            {
                foreach (var item in combo.Items)
                {
                    ListClass listclassItem = item as ListClass;
                    if (listclassItem.Name == newestItem)
                    {
                        combo.SelectedItem = item;
                    }
                }
            }
        }

        private void AddNewTypeForm_Load(object sender, EventArgs e)
        {
            MultipleCellsForm();
            PopulateTypeCombo(PoseFittingCombobox, cell.PoseFittingFolderPath);
            PopulateTypeCombo(PaintPlanningCombobox, cell.PaintPlanningFolderPath);
            PopulateTypeCombo(SegmentationCombobox, cell.SegmentationFolderPath);
            PopulateTypeCombo(ClassificationCombobox, cell.ClassificationFolderPath);
        }

        private void MultipleCellsForm()
        {
            if (MultipleCells)
            {
                TouchPanelInsertGroupBox.Visible = false;
                SaveBtn.Location = new Point(10, 318);
                this.Size = new Size(713, 414);
            }
            else
            {
                TouchPanelInsertGroupBox.Visible = true;
                SaveBtn.Location = new Point(10, 648);
                this.Size = new Size(713, 744);
                LoadTouchPanelSettings();
                PopulateTouchPanelListbox();
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
                tps.DisplayName = tps.FileSetting.GuiDescription;
                TouchPanelSettings.Add(tps);
            }
        }

        private void PopulateTouchPanelListbox()
        {
            TouchPanelItems.Items.Clear();
            TouchPanelItems.DataSource = TouchPanelSettings.OrderBy(x => x.TypeId).ToList();
            TouchPanelItems.DisplayMember = "DisplayName";

            TouchPanelItems.ClearSelected();
        }

        private void AddNewTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void CloneBlocKAdapter(string msgtext, ComboBox combo, JToken tokenList, string folderpath, string fileprefix)
        {
            if (NameTextbox.TextLength == 0)
            {
                if (MessageBox.Show("You must enter a name for the new type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    NameTextbox.Focus();
                }
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to clone the {msgtext} settings for {combo.Text} to {NewTypeName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JToken selected = null;
                    var current = combo.SelectedItem as ListClass;
                    foreach (var item in tokenList)
                    {
                        var itemJProp = item as JProperty;
                        var itemValue = itemJProp.FirstOrDefault() as JValue;
                        if (itemValue.Value.ToString() == current.Value.ToString())
                        {
                            selected = JSONHelper.LoadJsonData($@"{folderpath}\{itemValue.Value}");
                            break;
                        }
                    }
                    string newFileName = $"{fileprefix}_{NewTypeName}";
                    JSONHelper.SerializeObject(selected, folderpath + $@"\{newFileName}.json");
                    PopulateTypeCombo(combo, folderpath, newFileName);
                }
            }
        }

        private void ClonePoseFittingBtn_Click(object sender, EventArgs e)
        {
            CloneBlocKAdapter("pose fitting", PoseFittingCombobox, cell.PoseFitting, cell.PoseFittingFolderPath, "PoseFitting");
        }

        private void NameTextbox_Leave(object sender, EventArgs e)
        {
            NewTypeName = NameTextbox.Text.Replace(" ", "-");

            if (cell.Types.Any(x => x.Name.ToLower() == NewTypeName.ToLower()) || cell.Types.Any(x => x.Name.ToLower() == NewTypeName.Replace("-", "_").ToLower()))
            {
                if (MessageBox.Show($"The Type {NewTypeName} already exist, please enter different one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    NameTextbox.SelectAll();
                    NameTextbox.Focus();
                }
            }
        }

        private void ClonePaintPlanningBtn_Click(object sender, EventArgs e)
        {
            CloneBlocKAdapter("paint planning", PaintPlanningCombobox, cell.PaintPlanning, cell.PaintPlanningFolderPath, "SteelPaintPlanning");
        }

        private void CloneSegmentationBtn_Click(object sender, EventArgs e)
        {
            CloneBlocKAdapter("segmentation", SegmentationCombobox, cell.Segmentation, cell.SegmentationFolderPath, "SteelSegmenter");
        }

        private void CloneClassificationBtn_Click(object sender, EventArgs e)
        {
            CloneBlocKAdapter("classification", ClassificationCombobox, cell.Classification, cell.ClassificationFolderPath, "SurfaceClassification");
        }

        private void NewPaintPlanningBtn_Click(object sender, EventArgs e)
        {
            if (NameTextbox.TextLength == 0)
            {
                if (MessageBox.Show("You must enter a name for the new type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    NameTextbox.Focus();
                }
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to create a new empty paint planning settings to {NewTypeName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JToken newType = JSONHelper.LoadJsonData($@"{cell.PaintPlanningFolderPath}\SteelPaintPlanning_Empty.json");

                    string newFileName = $"SteelPaintPlanning_{NewTypeName}";

                    JSONHelper.SerializeObject(newType, cell.PaintPlanningFolderPath + $@"\{newFileName}.json");

                    PopulateTypeCombo(PaintPlanningCombobox, cell.PaintPlanningFolderPath, newFileName);
                }
            }
        }

        private void NewClassificationBtn_Click(object sender, EventArgs e)
        {
            if (NameTextbox.TextLength == 0)
            {
                if (MessageBox.Show("You must enter a name for the new type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    NameTextbox.Focus();
                }
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to create a new empty classification settings to {NewTypeName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JToken newType = JSONHelper.LoadJsonData($@"{cell.ClassificationFolderPath}\SurfaceClassification_Empty.json");

                    string newFileName = $"SurfaceClassification_{NewTypeName}";

                    JSONHelper.SerializeObject(newType, cell.ClassificationFolderPath + $@"\{newFileName}.json");

                    PopulateTypeCombo(ClassificationCombobox, cell.ClassificationFolderPath, newFileName);
                }
            }
        }

        private void WriteNewBlockAdapter(ComboBox combo, JToken token, SteelCell cell, string folderpath)
        {
            JObject obj = token as JObject;
            var currentBlockAdapter = combo.SelectedItem as ListClass;
            JValue value = new JValue(currentBlockAdapter.Value);
            obj.Add(NewTypeName, value);
            JToken newtoken = obj;
            JSONHelper.WriteToJsonFile(newtoken, folderpath);
        }

        private bool CheckIfTouchPanelNameEmpty()
        {
            if (TouchPanelDisplayTextbox.TextLength == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckIfTouchPanelItemSelected()
        {
            if (TouchPanelItems.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckIfTouchPanelIsEmpty()
        {
            if (TouchPanelItems.Items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckIfBeforeAfterPicked()
        {
            if (BeforeRadioBtn.Checked || AfterRadioBtn.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private TouchPanelSetting NewTouchPanelItem(int typeid, string typename)
        {
            TouchPanelSetting tps = new TouchPanelSetting();
            tps.Filename = Path.Combine(TouchPanelPath, $"{typeid.ToString().PadLeft(2, '0')}_{typename}.json");
            tps.Type = typename;
            tps.TypeId = typeid;

            TouchPanelClass tpc = new TouchPanelClass();
            tpc.Filename = typename;
            tpc.GuiDescription = TouchPanelDisplayTextbox.Text;

            tps.FileSetting = tpc;

            return tps;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!MultipleCells)
            {
                if (CheckIfTouchPanelNameEmpty())
                {
                    if (MessageBox.Show("Display name on touch panel is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        TouchPanelDisplayTextbox.Focus();
                    }
                }
                else
                {
                    if (!CheckIfTouchPanelIsEmpty())
                    {
                        if (!CheckIfTouchPanelItemSelected())
                        {
                            if (MessageBox.Show("You must select an item from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                TouchPanelItems.Focus();
                            }
                        }
                        else
                        {
                            if (!CheckIfBeforeAfterPicked())
                            {
                                var selectedTouchPanelItem = TouchPanelItems.SelectedItem as TouchPanelSetting;
                                MessageBox.Show($"You must choose if the item should be before or after the {selectedTouchPanelItem.DisplayName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (BeforeRadioBtn.Checked)
                                {
                                    var selectedTouchPanelItem = TouchPanelItems.SelectedItem as TouchPanelSetting;
                                    var tempTouchPanelList = TouchPanelSettings.Where(x => x.TypeId >= selectedTouchPanelItem.TypeId).ToList();
                                    foreach (var item in tempTouchPanelList)
                                    {
                                        item.TypeId += 1;
                                        if (File.Exists(item.Filename))
                                        {
                                            File.Delete(item.Filename);
                                        }
                                        string newFilename = $"{item.TypeId.ToString().PadLeft(2, '0')}_{item.Type}.json";

                                        JSONHelper.SerializeObject(item.FileSetting, Path.Combine(TouchPanelPath, newFilename));
                                    }
                                    TouchPanelSetting newtouchpanelitem = NewTouchPanelItem(selectedTouchPanelItem.TypeId - 1, NewTypeName);
                                    JSONHelper.SerializeObject(newtouchpanelitem.FileSetting, newtouchpanelitem.Filename);
                                }
                                else
                                {
                                    var selectedTouchPanelItem = TouchPanelItems.SelectedItem as TouchPanelSetting;
                                    var tempTouchPanelList = TouchPanelSettings.Where(x => x.TypeId > selectedTouchPanelItem.TypeId).ToList();
                                    foreach (var item in tempTouchPanelList)
                                    {
                                        item.TypeId += 1;
                                        if (File.Exists(item.Filename))
                                        {
                                            File.Delete(item.Filename);
                                        }
                                        string newFilename = $"{item.TypeId.ToString().PadLeft(2, '0')}_{item.Type}.json";

                                        JSONHelper.SerializeObject(item.FileSetting, Path.Combine(TouchPanelPath, newFilename));
                                    }
                                    TouchPanelSetting newtouchpanelitem = NewTouchPanelItem(selectedTouchPanelItem.TypeId + 1, NewTypeName);
                                    JSONHelper.SerializeObject(newtouchpanelitem.FileSetting, newtouchpanelitem.Filename);
                                }
                                
                                WriteNewBlockAdapter(PoseFittingCombobox, cell.PoseFitting, cell, cell.PoseFittingWorkPiecePath);
                                WriteNewBlockAdapter(PaintPlanningCombobox, cell.PaintPlanning, cell, cell.PaintPlannerWorkPiecePath);
                                WriteNewBlockAdapter(SegmentationCombobox, cell.Segmentation, cell, cell.SegmentationWorkPiecePath);
                                WriteNewBlockAdapter(ClassificationCombobox, cell.Classification, cell, cell.ClassificationWorkPiecePath);
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        TouchPanelClass tpc = new TouchPanelClass();
                        tpc.Filename = NewTypeName;
                        tpc.GuiDescription = TouchPanelDisplayTextbox.Text;

                        JSONHelper.SerializeObject(tpc, Path.Combine(TouchPanelPath, $"01_{NewTypeName}.json"));

                        WriteNewBlockAdapter(PoseFittingCombobox, cell.PoseFitting, cell, cell.PoseFittingWorkPiecePath);
                        WriteNewBlockAdapter(PaintPlanningCombobox, cell.PaintPlanning, cell, cell.PaintPlannerWorkPiecePath);
                        WriteNewBlockAdapter(SegmentationCombobox, cell.Segmentation, cell, cell.SegmentationWorkPiecePath);
                        WriteNewBlockAdapter(ClassificationCombobox, cell.Classification, cell, cell.ClassificationWorkPiecePath);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                WriteNewBlockAdapter(PoseFittingCombobox, cell.PoseFitting, cell, cell.PoseFittingWorkPiecePath);
                WriteNewBlockAdapter(PaintPlanningCombobox, cell.PaintPlanning, cell, cell.PaintPlannerWorkPiecePath);
                WriteNewBlockAdapter(SegmentationCombobox, cell.Segmentation, cell, cell.SegmentationWorkPiecePath);
                WriteNewBlockAdapter(ClassificationCombobox, cell.Classification, cell, cell.ClassificationWorkPiecePath);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}