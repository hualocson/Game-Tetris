using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FinalGameTetris
{
    public partial class FMusic : Form
    {
        #region Properties
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        List<string> playList;
        int cur = 0;
        DateTime curretTime;

        public WindowsMediaPlayer Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }
        #endregion
        public FMusic()
        {
            InitializeComponent();

            //Set Font
            lbPlayingSong.Font = new Font(Cons.newFont.Families[1], 22, FontStyle.Regular);
            cbTurnOffMusic.Font= lbTimeDuration.Font = lbTimeRun.Font = new Font(Cons.newFont.Families[1], 12, FontStyle.Regular);
        }

        private void highlightPlayingSong()
        {
            int index = 0;
            foreach (var song in pnlPlayList.Controls)
            {
                CTButton btn = song as CTButton;
                if (index == cur)
                {
                    btn.TextColor = ThemeColor.SecondaryColor;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                else
                {
                    btn.TextColor = ThemeColor.AccentLightColor;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);
                }
                index++;
            }
        }

        private void addSongToPlaylist(string path)
        {
            CTButton btn = new CTButton();
            btn.Height = 50;
            btn.Width = pnlPlayList.Width - 40;
            btn.BorderRadius = 20;
            btn.TextColor = ThemeColor.AccentLightColor;
            btn.BackColor = ThemeColor.PrimaryLightColor;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 108, 126);
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.Font = new Font(Cons.newFont.Families[1], 14, FontStyle.Regular); ;
            btn.Margin = new Padding(10,0,0,10);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Text = Path.GetFileNameWithoutExtension(path);
            btn.Click += new EventHandler(SongClick);
            pnlPlayList.Controls.Add(btn);
        }
        private void SongClick(object sender, EventArgs e)
        {
            CTButton btn = sender as CTButton;
            if (!cbTurnOffMusic.Checked)
            {
                try
                {
                    prcTimeMusic.Value = 0;
                    curretTime = new DateTime(1, 1, 1, 0, 0, 0);
                    cur = pnlPlayList.Controls.IndexOf(btn);
                    lbPlayingSong.Text = Path.GetFileNameWithoutExtension(playList[cur]);
                    highlightPlayingSong();
                    player.URL = playList[cur];
                    if (btnPlay.Visible == true)
                    {
                        btnPlay.Visible = false;
                        btnPause.Visible = true;
                    }
                    //fMainMenu.isPlayingMusic = true;
                }
                catch { }
            }
        }

        private void FMusic_Load(object sender, EventArgs e)
        {
            string pathMusic = Cons.getPath(@"..\..\..\Music");
            playList = Directory.GetFiles(pathMusic, "*.mp3", SearchOption.TopDirectoryOnly).ToList();

            for (int i = 0; i < playList.Count; i++)
            {
                addSongToPlaylist(playList[i]);
            }
            lbPlayingSong.Text = Path.GetFileNameWithoutExtension(playList[cur]);
            highlightPlayingSong();

            player.URL = playList[0];
            player.controls.stop();

            curretTime = new DateTime(1, 1, 1, 0, 0, 0);

            prcTimeMusic.Step = 10;
            prcTimeMusic.Value = 0;
            timerMusic.Interval = 1000;
            timerMusic.Start();
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            lbTimeDuration.Text = player.controls.currentItem.durationString;
            lbTimeRun.Text = curretTime.ToString("mm:ss");
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                if (prcTimeMusic.Value >= prcTimeMusic.Maximum)
                {
                    prcTimeMusic.Value = 0;
                    curretTime = new DateTime(1, 1, 1, 0, 0, 0);

                    cur++;
                    if (cur == playList.Count)
                        cur = 0;
                    player.URL = playList[cur];
                    lbPlayingSong.Text = Path.GetFileNameWithoutExtension(playList[cur]);
                    highlightPlayingSong();
                    player.controls.play();
                }
                prcTimeMusic.Maximum = (int)player.controls.currentItem.duration * 10;
                prcTimeMusic.PerformStep();
                curretTime = curretTime.AddSeconds(1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!cbTurnOffMusic.Checked)
            {
                prcTimeMusic.Value = 0;
                curretTime = new DateTime(1, 1, 1, 0, 0, 0);

                cur++;
                if (cur == playList.Count)
                    cur = 0;
                player.URL = playList[cur];
                if (btnPlay.Visible == true)
                {
                    btnPlay.Visible = false;
                    btnPause.Visible = true;
                }
                lbPlayingSong.Text = Path.GetFileNameWithoutExtension(playList[cur]);
                highlightPlayingSong();
                //fMainMenu.isPlayingMusic = true;
                player.controls.play();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (!cbTurnOffMusic.Checked)
            {
                prcTimeMusic.Value = 0;
                curretTime = new DateTime(1, 1, 1, 0, 0, 0);

                cur--;
                if (cur <= 0)
                    cur = playList.Count - 1;
                player.URL = playList[cur];
                if (btnPlay.Visible == true)
                {
                    btnPlay.Visible = false;
                    btnPause.Visible = true;
                }
                lbPlayingSong.Text = Path.GetFileNameWithoutExtension(playList[cur]);
                highlightPlayingSong();
                //fMainMenu.isPlayingMusic = true;
                player.controls.play();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!cbTurnOffMusic.Checked)
            {
                CTButton btn = sender as CTButton;
                btn.Visible = false;
                btnPause.Visible = true;
                //fMainMenu.isPlayingMusic = true;
                player.controls.play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!cbTurnOffMusic.Checked)
            {
                CTButton btn = sender as CTButton;
                btn.Visible = false;
                btnPlay.Visible = true;
                //fMainMenu.isPlayingMusic = false;
                player.controls.pause();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Mp3 Files| *.mp3|Wav Files | *.wav ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.Length; i++)
                {
                    playList.Add(open.FileNames[i]);
                    addSongToPlaylist(open.SafeFileNames[i]);
                }
            }
        }

        private void cbTurnOffMusic_Click(object sender, EventArgs e)
        {
            if (cbTurnOffMusic.Checked)
            {
                btnPause.Visible = false;
                btnPlay.Visible = true;
                player.controls.pause();
            }
        }
    }
}
