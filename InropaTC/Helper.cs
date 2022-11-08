using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InropaTC
{
    public static class Helper
    {
        public static Setting LoadSettings(Setting setting)
        {
            SettingsForm settingsForm = new SettingsForm(setting);
            var result = settingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                setting = settingsForm.setting;
            }
            return setting;
        }

        public static bool CheckIfMultipleCellsFound(Setting setting)
        {
            DirectoryInfo di = new DirectoryInfo(setting.InstallationPath);
            int countsteelcells = 0;
            foreach (DirectoryInfo directory in di.GetDirectories())
            {
                if (directory.GetDirectories().Where(x => x.Name == "PoseFittingBlockAdapter").Count() > 0)
                {
                    countsteelcells++;
                    continue;
                }
            }
            return countsteelcells > 1 ? true : false;
        }

        public static List<CellListHelper> GetSteelCells(Setting setting)
        {
            List<SteelCell> cells = new List<SteelCell>();
            DirectoryInfo di = new DirectoryInfo(setting.InstallationPath);

            List<CellListHelper> steel_cells = new List<CellListHelper>();
            foreach (DirectoryInfo directory in di.GetDirectories())
            {
                if (directory.GetDirectories().Where(x => x.Name == "PoseFittingBlockAdapter").Count() > 0)
                {
                    CellListHelper cellListHelper = new CellListHelper();
                    cellListHelper.Name = directory.Name;
                    cellListHelper.FolderPath = directory.FullName;
                    steel_cells.Add(cellListHelper);
                    continue;
                }
            }
            return steel_cells;
        }

        public static CellListHelper GetSteelCell(Setting setting)
        {
            DirectoryInfo di = new DirectoryInfo(setting.InstallationPath);
            DirectoryInfo cellInfo = null;
            foreach (DirectoryInfo directory in di.GetDirectories())
            {
                if(directory.GetDirectories().Where(x => x.Name == "PoseFittingBlockAdapter").Count() > 0)
                {
                    cellInfo = directory;
                    break;
                }
            }
            CellListHelper cellListHelper = new CellListHelper();
            if (cellInfo != null)
            {
                cellListHelper.Name = cellInfo.Name;
                cellListHelper.FolderPath = cellInfo.FullName;
            }
            return cellListHelper;
        }

        public static SteelCell GetCellData(CellListHelper cell)
        {
            SteelCell sCell = new SteelCell();
            sCell.CellName = cell.Name;

            List<SteelTypes> types = new List<SteelTypes>();

            string PoseFitting_WorkpieceTypesToConfigurationFilesPath = Path.Combine(cell.FolderPath, "PoseFittingBlockAdapter", "PoseFitting_WorkpieceTypesToConfigurationFiles.json");
            string PaintPlanning_WorkpieceTypesToConfigurationFilesPath = Path.Combine(cell.FolderPath, "SteelPaintPlanningBlockAdapter", "SteelPaintPlanning_WorkpieceTypesToConfigurationFiles.json");
            string Segmentation_WorkpieceTypesToConfigurationFilesPath = Path.Combine(cell.FolderPath, "SteelSegmentationBlockAdapter", "SteelSegmentation_WorkpieceTypesToConfigurationFiles.json");
            string Classification_WorkpieceTypesToConfigurationFilesPath = Path.Combine(cell.FolderPath, "SurfaceClassificationBlockAdapter", "SurfaceClassification_WorkpieceTypesToConfigurationFiles.json");

            JToken PoseFitting = JSONHelper.LoadJsonData(PoseFitting_WorkpieceTypesToConfigurationFilesPath);
            JToken PaintPlanning = JSONHelper.LoadJsonData(PaintPlanning_WorkpieceTypesToConfigurationFilesPath);
            JToken Segmentation = JSONHelper.LoadJsonData(Segmentation_WorkpieceTypesToConfigurationFilesPath);
            JToken Classification = JSONHelper.LoadJsonData(Classification_WorkpieceTypesToConfigurationFilesPath);

            foreach (var item in PoseFitting.Children())
            {
                var type = item as JProperty;
                SteelTypes st = new SteelTypes();
                st.Name = type.Name;
                types.Add(st);
            }

            sCell.Types = types;
            sCell.PoseFitting = PoseFitting;
            sCell.PoseFittingWorkPiecePath = PoseFitting_WorkpieceTypesToConfigurationFilesPath;
            sCell.PoseFittingFolderPath = Path.Combine(cell.FolderPath, "PoseFittingBlockAdapter");
            sCell.PaintPlanning = PaintPlanning;
            sCell.PaintPlannerWorkPiecePath = PaintPlanning_WorkpieceTypesToConfigurationFilesPath;
            sCell.PaintPlanningFolderPath = Path.Combine(cell.FolderPath, "SteelPaintPlanningBlockAdapter");
            sCell.Segmentation = Segmentation;
            sCell.SegmentationWorkPiecePath = Segmentation_WorkpieceTypesToConfigurationFilesPath;
            sCell.SegmentationFolderPath = Path.Combine(cell.FolderPath, "SteelSegmentationBlockAdapter");
            sCell.Classification = Classification;
            sCell.ClassificationWorkPiecePath = Classification_WorkpieceTypesToConfigurationFilesPath;
            sCell.ClassificationFolderPath = Path.Combine(cell.FolderPath, "SurfaceClassificationBlockAdapter");
            return sCell;
        }

        public static List<ListClass> GetConfigFiles(string FolderPath)
        {
            List<ListClass> list = new List<ListClass>();
            DirectoryInfo di = new DirectoryInfo(FolderPath);
            var files = di.GetFiles().Where(x => !x.Name.EndsWith("settings.json") && !x.Name.EndsWith("WorkpieceTypesToConfigurationFiles.json") && !x.Name.EndsWith("Empty.json") && !x.Name.EndsWith("jsonpatch")).ToList();
            foreach (FileInfo file in files)
            {
                ListClass lc = new ListClass();
                lc.Name = Path.GetFileNameWithoutExtension(file.Name);
                lc.Value = file.Name;
                list.Add(lc);
            }
            return list;
        }
    }
}