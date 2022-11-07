using Newtonsoft.Json.Linq;

namespace InropaTC
{
    public class SteelCell
    {
        public string CellName { get; set; }
        public JToken PoseFitting { get; set; }
        public string PoseFittingFolderPath { get; set; }
        public string PoseFittingWorkPiecePath { get; set; }
        public JToken PaintPlanning { get; set; }
        public string PaintPlanningFolderPath { get; set; }
        public string PaintPlannerWorkPiecePath { get; set; }
        public JToken Segmentation { get; set; }
        public string SegmentationFolderPath { get; set; }
        public string SegmentationWorkPiecePath { get; set; }
        public JToken Classification { get; set; }
        public string ClassificationFolderPath { get; set; }
        public string ClassificationWorkPiecePath { get; set; }
        public List<SteelTypes> Types { get; set; }
    }
    public class SteelTypes
    {
        public string Name { get; set; }
    }
}