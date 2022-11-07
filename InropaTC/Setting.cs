using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InropaTC
{
    public enum CoreType
    {
        Steel
    }
    public class Setting
    {
        public string InstallationPath { get; set; }
        public string CoreType { get; set; }
    }
}