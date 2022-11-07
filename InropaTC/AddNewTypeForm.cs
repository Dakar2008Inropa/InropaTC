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
        public AddNewTypeForm(Setting setting, SteelCell cell, List<CellListHelper> CellList)
        {
            this.setting = setting;
            this.cell = cell;
            this.CellList = CellList;
            this.MultipleCells = Helper.CheckIfMultipleCellsFound(setting);
            InitializeComponent();
        }

        private void PopulateTypeCombo(ComboBox combo, string ConfigPath)
        {
            combo.DataSource = Helper.GetConfigFiles(ConfigPath);
            combo.DisplayMember = "Name";
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
    }
}