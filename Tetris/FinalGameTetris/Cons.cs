using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGameTetris
{
    class Cons
    {
        public static PrivateFontCollection newFont = new PrivateFontCollection();
        private static List<string> ListPathFonts = new List<string>() {
                @"..\..\..\Fonts\Mangabey.ttf",
                @"..\..\..\Fonts\AstrojetsDemoRegular.ttf"
        };

        public static void AddFont()
        {
            string path;
            for (int i = 0; i < ListPathFonts.Count; i++)
            {
                path = getPath(ListPathFonts[i]);
                newFont.AddFontFile(path);
            }
        }

        public static string getPath(string relativePath)
        {
            string s = Path.Combine(Application.StartupPath, relativePath);
            return Path.GetFullPath(s);
        }

        public static string TurnSound = Cons.getPath(@"..\..\..\Sound\turn.wav");
        public static string ScoreSound = Cons.getPath(@"..\..\..\Sound\score.wav");
        public static string LevelUpSound = Cons.getPath(@"..\..\..\Sound\levelup.wav");
        public static string HitBtnSound = Cons.getPath(@"..\..\..\Sound\hit.wav");
        public static string GameOverSound = Cons.getPath(@"..\..\..\Sound\gameover.wav");

        public static int canvasWidth = 10;
        public static int canvasHeight = 20;
        public static int dotSize = 24;
    }
}