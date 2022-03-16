using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGameTetris
{
    public class ThemeColor
    {
        public static List<string> ShapeColor = new List<string>() {
            "#F06070",//Pink
            "#ffd166",//Yellow
            "#06d6a0",//Green
            "#118ab2",//Blue
            "#905265",//Dark blue
            "#fe7f2d",//Violet
            "#e63946"//Orange
        };
        public static Color PrimaryColor = ColorTranslator.FromHtml("#222831");
        public static Color PrimaryLightColor = ColorTranslator.FromHtml("#30475E");
        public static Color PrimarySupLightColor = ColorTranslator.FromHtml("#5780AA");
        public static Color SecondaryColor = ColorTranslator.FromHtml("#69EBB7");
        public static Color SecondaryDarkColor = ColorTranslator.FromHtml("#E462AB");
        public static Color AccentLightColor = ColorTranslator.FromHtml("#D6F4FF");
        public static Color AccentDarkColor = ColorTranslator.FromHtml("#546065");
    }
}
