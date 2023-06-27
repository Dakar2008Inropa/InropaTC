using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InropaTC
{
    public class TouchPanelClass
    {
        public string GuiDescription { get; set; }
        public string Filename { get; set; }
        public bool UseCustomColors { get; set; }
        public string BackgroundColor { get; set; }
        public int BackgroundTransparency { get; set; }
        public string ForegroundColor { get; set; }
        public int ForegroundTransparency { get; set; }
    }
}