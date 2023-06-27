using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InropaTC
{
    public static class ColorConverter
    {
        public static Color HexToRgb(string hexColor, int alpha)
        {
            if (hexColor.StartsWith("#"))
                hexColor = hexColor.Substring(1);

            int red = int.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}