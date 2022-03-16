using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGameTetris
{
    public partial class FNewGame : Form
    {
        #region Field
        private int level;
        private Button activeBtn = null;

        FGame mainGame;
        public FGame MainGame
        {
            get
            {
                return mainGame;
            }

            set
            {
                mainGame = value;
            }
        }
        #endregion

        public FNewGame()
        {
            InitializeComponent();

            //set Font
            lbHeader.Font = new Font(Cons.newFont.Families[0], 24, FontStyle.Regular);
            foreach (var control in pnlBody.Controls)
            {
                if (control.GetType() == typeof(CTButton))
                {
                    var btn = control as CTButton;
                    btn.Font = new Font(Cons.newFont.Families[1], 16, FontStyle.Regular); 
                }
            }
            btnStartGame.Font = new Font(Cons.newFont.Families[1], 16, FontStyle.Regular); 
        }

        private void HighLightBtn(Button btn)
        {
            btn.BackColor = ThemeColor.SecondaryColor;
            btn.ForeColor = ThemeColor.PrimaryColor;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void UnHighLightBtn(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = ThemeColor.AccentLightColor;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void btnLV0_Click(object sender, EventArgs e)
        {
            level = 0;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnLV5_Click(object sender, EventArgs e)
        {
            level = 5;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnLV1_Click(object sender, EventArgs e)
        {
            level = 1;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnLV2_Click(object sender, EventArgs e)
        {

            level = 2;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnLV3_Click(object sender, EventArgs e)
        {

            level = 3;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnLV4_Click(object sender, EventArgs e)
        {

            level = 4;
            if (activeBtn != null)
                UnHighLightBtn(activeBtn);
            activeBtn = sender as Button;
            HighLightBtn(activeBtn);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (activeBtn == null)
                return;
            if (mainGame != null)
                mainGame.Close();
            mainGame = new FGame
            {
                Level = level
            };
            FMainMenu.UpdateState(true, true, true, true);
            mainGame.StartGame();
            mainGame.Show();
        }

        #region Mouse Event
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn == btn)
            {
                btn.FlatAppearance.MouseOverBackColor = ThemeColor.SecondaryColor;
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 108, 126);
            }
        }
        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn == btn)
            {
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.SecondaryColor;
            }
            else
            {
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.PrimarySupLightColor;
            }
        }
        #endregion
    }
}
