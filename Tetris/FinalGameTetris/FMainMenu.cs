using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGameTetris
{
    public partial class FMainMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public static bool isHide = false;
        public static bool isPlayingGame = false;
        public static bool isPlayingMusic = false;
        private Button activeBtn = null;
        public static Timer timerMainMenu;
        private FMusic fMusic;
        private FNewGame fNewGame;
        public FMainMenu()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            fMusic = new FMusic();
            fMusic.TopLevel = false;
            fMusic.Dock = DockStyle.Fill;
            pnlRightSide.Controls.Add(fMusic);
            fMusic.SendToBack();
            fMusic.Show();

            fNewGame = new FNewGame();
            fNewGame.TopLevel = false;
            fNewGame.Dock = DockStyle.Fill;
            pnlRightSide.Controls.Add(fNewGame);
            fNewGame.SendToBack();
            fNewGame.Show();

            timerMainMenu = new Timer();
            timerMainMenu.Interval = 1;
            timerMainMenu.Start();
            timerMainMenu.Tick += Timer_Tick;
            this.KeyPreview = false;

            pnlBar.BackColor = panel1.BackColor = panel2.BackColor = ThemeColor.SecondaryColor;
            //Set Font
            lbLogo.Font = new Font(Cons.newFont.Families[0], 36, FontStyle.Bold);
            foreach (var control in pnlLeft.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    var btn = control as Button;
                    btn.Font = new Font(Cons.newFont.Families[1], 24, FontStyle.Regular);
                }
            }
        }

        #region Highlight
        private void HighLightBtn(Button btn)
        {
            btn.BackColor = ThemeColor.PrimaryColor;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void unHighLightBtn(Button btn)
        {
            btn.BackColor = ThemeColor.PrimaryLightColor;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void showBar(Button btn)
        {
            pnlBar.Visible = true;
            pnlBar.Height = btn.Height;
            pnlBar.Width = 5;
            pnlBar.Top = btn.Top;
            pnlBar.Left = btn.Left;
        }
        #endregion

        public static void UpdateState(bool isHide, bool isPlayingGame, bool isPlayingMusic, bool isEnable)
        {
            FMainMenu.isHide = isHide;
            FMainMenu.isPlayingGame = isPlayingGame;
            FMainMenu.isPlayingMusic = isPlayingMusic;
            FMainMenu.timerMainMenu.Enabled = isEnable;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isHide)
                this.Hide();
            else
            {
                this.Show();
                this.BringToFront();
                fMusic.SendToBack();
                fNewGame.SendToBack();
                if (activeBtn != null)
                {
                    unHighLightBtn(activeBtn);
                    pnlBar.Visible = false;
                }
            }
            if (isPlayingGame)
            {
                btnContinue.Visible = true;
            }
            else
            {
                btnContinue.Visible = false;
            }
            if (isPlayingMusic)
            {
                if (!fMusic.cbTurnOffMusic.Checked)
                    fMusic.Player.controls.play();
            }
            else
            {
                fMusic.Player.controls.pause();
            }
            timerMainMenu.Enabled = false;
        }

        #region Button Click
        private void btnMusic_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            activeBtn = btn;
            showBar(activeBtn);
            HighLightBtn(activeBtn);

            if (activeForm != null)
                activeForm.Close();
            activeForm = null;

            fNewGame.SendToBack();
            fMusic.BringToFront();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == activeBtn)
                return;
            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            activeBtn = btn;
            showBar(activeBtn);
            HighLightBtn(activeBtn);

            fMusic.SendToBack();
            openChildForm(new FHelp());
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            activeBtn = btn;
            showBar(activeBtn);
            HighLightBtn(activeBtn);

            fMusic.SendToBack();
            fNewGame.BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FNotify messBox = new FNotify("Are you want to quit?", "Yes", "No");
            messBox.ShowDialog();
            if(messBox.isOK)
                Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FNotify messBox = new FNotify("Are you want to quit?", "Yes", "No");
            messBox.ShowDialog();
            if (messBox.isOK)
                Application.Exit();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            if (activeForm != null)
                activeForm.Close();
            activeForm = null;
            activeBtn = null;
            pnlBar.Visible = false;
            fNewGame.MainGame.Show();
            UpdateState(true, true, true, true);
        }
        #endregion

        #region Open Child Form
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlRightSide.Controls.Add(childForm);
            pnlRightSide.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void lbLogo_Click(object sender, EventArgs e)
        {
            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            if (activeForm != null)
                activeForm.Close();
            activeForm = null;
            activeBtn = null;
            pnlBar.Visible = false;
            fMusic.SendToBack();
            fNewGame.SendToBack();
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn == btn)
            {
                btn.FlatAppearance.MouseOverBackColor = ThemeColor.PrimaryColor;
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
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.PrimaryColor;
            }
            else
            {
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.PrimarySupLightColor;
            }
        }
    }
}
