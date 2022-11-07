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
                TouchPanelSettings.Add(tps);
            }
        }

        private void PopulateTouchPanelListbox()
        {
            TouchPanelItems.Items.Clear();
            TouchPanelItems.DataSource = TouchPanelSettings.OrderBy(x => x.TypeId).ToList();
            TouchPanelItems.DisplayMember = "Type";
        }

        private void AddNewTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ClonePoseFittingBtn_Click(object sender, EventArgs e)
        {
            if(NameTextbox.TextLength == 0)
            {
                if(MessageBox.Show("You must enter a name for the new type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    NameTextbox.Focus();
                }
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to clone the pose fitting settings for {PoseFittingCombobox.Text} to {NewTypeName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JToken selectedPoseFitting = null;
                    var currentPoseFitting = PoseFittingCombobox.SelectedItem as ListClass;
                    foreach (var item in cell.PoseFitting)
                    {
                        var itemJProp = item as JProperty;
                        var itemValue = itemJProp.FirstOrDefault() as JValue;
                        if (itemValue.Value.ToString() == currentPoseFitting.Value.ToString())
                        {
                            selectedPoseFitting = JSONHelper.LoadJsonData($@"{cell.PoseFittingFolderPath}\{itemValue.Value}");
                            break;
                        }
                    }
                    string newFileName = $"PoseFitting_{NewTypeName}";
                    JSONHelper.SerializeObject(selectedPoseFitting, cell.PoseFittingFolderPath + $@"\{newFileName}.json");
                    PopulateTypeCombo(PoseFittingCombobox, cell.PoseFittingFolderPath, newFileName);
                }
            }
        }

        private void NameTextbox_Leave(object sender, EventArgs e)
        {
            NewTypeName = NameTextbox.Text.Replace(" ", "-");
        }
    }
}