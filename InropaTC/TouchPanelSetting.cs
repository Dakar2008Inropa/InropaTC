using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InropaTC
{
    public class TouchPanelSetting
    {
        public string Filename { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public string DisplayName { get; set; }
        public TouchPanelClass FileSetting { get; set; }
    }
}