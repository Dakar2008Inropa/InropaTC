using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InropaTC
{
    public partial class CloneTypeForm : Form
    {
        private Setting setting;
        private SteelCell cell;
        private List<CellListHelper> CellList;
        private bool MultipleCells;
        private List<TouchPanelSetting> TouchPanelSettings = new List<TouchPanelSetting>();
        private string TouchPanelPath = $@"c:\ProgramData\Inropa\Touchpanel\Settings\Actions\";
        private string typeToClone;
        string NewTypeName = "";

        public TouchPanelClass tpc { get; set; }

        public CloneTypeForm(Setting setting, SteelCell cell, List<CellListHelper> CellList, string typeToClone)
        {
            this.setting = setting;
            this.cell = cell;
            this.CellList = CellList;
            this.MultipleCells = Helper.CheckIfMultipleCellsFound(setting);
            this.typeToClone = typeToClone;
            InitializeComponent();
        }

        private void MultipleCellsForm()
        {
            if (MultipleCells)
            {
                TouchPanelInsertGroupBox.Visible = false;
                SaveBtn.Location = new Point(11, 67);
                this.Size = new Size(713, 160);
            }
            else
            {
                TouchPanelInsertGroupBox.Visible = true;
                SaveBtn.Location = new Point(11, 404);
                this.Size = new Size(713, 499);
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

        private void WriteNewBlockAdapter(JToken token, string folderpath, string clonepath, bool cloneToNewType = false)
        {
            JObject obj = token as JObject;
            string currentBlockAdapter = null;
            foreach (var item in token.Children())
            {
                JProperty jprop = item as JProperty;
                if (jprop.Name.Split(',')[0] == typeToClone)
                {
                    JValue jvalue = item.Children().FirstOrDefault() as JValue;
                    if (cloneToNewType)
                    {
                        if (File.Exists(Path.Combine(clonepath, jvalue.Value.ToString())))
                        {
                            string getfilename = Path.GetFileNameWithoutExtension(jvalue.Value.ToString());
                            string[] splitfilename = getfilename.Split('_');
                            string newfilename = $"{splitfilename[0]}_{NewTypeName}.json";

                            File.Copy(Path.Combine(clonepath, jvalue.Value.ToString()), Path.Combine(clonepath, newfilename));
                            currentBlockAdapter = newfilename;
                            break;
                        }
                    }
                    else
                    {
                        currentBlockAdapter = jvalue.Value.ToString();
                        break;
                    }
                }
            }
            JValue value = new JValue(currentBlockAdapter);
            obj.Add($"{NewTypeName},{(int)PaintTypeNumber.Value}", value);
            JToken newtoken = obj;
            JSONHelper.WriteToJsonFile(newtoken, folderpath);
        }

        private TouchPanelSetting NewTouchPanelItem(int typeid, string typename)
        {
            TouchPanelSetting tps = new TouchPanelSetting();
            tps.Filename = Path.Combine(TouchPanelPath, $"{typeid.ToString().PadLeft(2, '0')}_{typename}.json");
            tps.Type = typename;
            tps.TypeId = typeid;

            tpc.Filename = typename;
            tpc.GuiDescription = TouchPanelDisplayTextbox.Text;

            tps.FileSetting = tpc;

            return tps;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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

                                    WriteNewBlockAdapter(cell.PoseFitting, cell.PoseFittingWorkPiecePath, cell.PoseFittingFolderPath);
                                    WriteNewBlockAdapter(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath, cell.PaintPlanningFolderPath, true);
                                    //WriteNewBlockAdapter(cell.Segmentation, cell.SegmentationWorkPiecePath, cell.SegmentationFolderPath, true);
                                    WriteNewBlockAdapter(cell.Classification, cell.ClassificationWorkPiecePath, cell.ClassificationFolderPath, true);
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

                            WriteNewBlockAdapter(cell.PoseFitting, cell.PoseFittingWorkPiecePath, cell.PoseFittingFolderPath);
                            WriteNewBlockAdapter(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath, cell.PaintPlanningFolderPath, true);
                            //WriteNewBlockAdapter(cell.Segmentation, cell.SegmentationWorkPiecePath, cell.SegmentationFolderPath, true);
                            WriteNewBlockAdapter(cell.Classification, cell.ClassificationWorkPiecePath, cell.ClassificationFolderPath, true);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    WriteNewBlockAdapter(cell.PoseFitting, cell.PoseFittingWorkPiecePath, cell.PoseFittingFolderPath);
                    WriteNewBlockAdapter(cell.PaintPlanning, cell.PaintPlannerWorkPiecePath, cell.PaintPlanningFolderPath, true);
                    //WriteNewBlockAdapter(cell.Segmentation, cell.SegmentationWorkPiecePath, cell.SegmentationFolderPath, true);
                    WriteNewBlockAdapter(cell.Classification, cell.ClassificationWorkPiecePath, cell.ClassificationFolderPath, true);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void CloneTypeForm_Load(object sender, EventArgs e)
        {
            MultipleCellsForm();
            this.Text = $"Clone - {typeToClone}";
        }

        private void CustomizeBtn_Click(object sender, EventArgs e)
        {
            CustomizeTPForm customizeTPForm = new CustomizeTPForm(tpc);
            if (customizeTPForm.ShowDialog() == DialogResult.OK)
            {
                tpc = customizeTPForm.tpc;
            }
        }

        private void UseMultiplePaintTypeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseMultiplePaintTypeCheckbox.Checked)
            {
                PaintTypeNumber.Enabled = true;
                PaintTypeNumber.Value = 1;
                PaintTypeNumber.Minimum = 1;
            }
            else
            {
                PaintTypeNumber.Enabled = false;
                PaintTypeNumber.Value = -1;
                PaintTypeNumber.Minimum = -1;
            }
        }
    }
}