
namespace FinalGameTetris
{
    partial class FMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMusic));
            this.prcTimeMusic = new System.Windows.Forms.ProgressBar();
            this.lbTimeRun = new System.Windows.Forms.Label();
            this.lbTimeDuration = new System.Windows.Forms.Label();
            this.pnlPlayList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnPlay = new FinalGameTetris.CTButton();
            this.btnPause = new FinalGameTetris.CTButton();
            this.lbPlayingSong = new System.Windows.Forms.Label();
            this.cbTurnOffMusic = new System.Windows.Forms.CheckBox();
            this.btnOpen = new FinalGameTetris.CTButton();
            this.btnNext = new FinalGameTetris.CTButton();
            this.btnPrev = new FinalGameTetris.CTButton();
            this.btnSongName = new FinalGameTetris.CTButton();
            this.btnLogo = new FinalGameTetris.CTButton();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // prcTimeMusic
            // 
            this.prcTimeMusic.Location = new System.Drawing.Point(10, 120);
            this.prcTimeMusic.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.prcTimeMusic.Name = "prcTimeMusic";
            this.prcTimeMusic.Size = new System.Drawing.Size(380, 14);
            this.prcTimeMusic.TabIndex = 2;
            // 
            // lbTimeRun
            // 
            this.lbTimeRun.AutoSize = true;
            this.lbTimeRun.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbTimeRun.Location = new System.Drawing.Point(7, 139);
            this.lbTimeRun.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.lbTimeRun.Name = "lbTimeRun";
            this.lbTimeRun.Size = new System.Drawing.Size(42, 14);
            this.lbTimeRun.TabIndex = 3;
            this.lbTimeRun.Text = "00:00";
            // 
            // lbTimeDuration
            // 
            this.lbTimeDuration.AutoSize = true;
            this.lbTimeDuration.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbTimeDuration.Location = new System.Drawing.Point(352, 139);
            this.lbTimeDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.lbTimeDuration.Name = "lbTimeDuration";
            this.lbTimeDuration.Size = new System.Drawing.Size(42, 14);
            this.lbTimeDuration.TabIndex = 4;
            this.lbTimeDuration.Text = "00:00";
            // 
            // pnlPlayList
            // 
            this.pnlPlayList.AutoScroll = true;
            this.pnlPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlPlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlayList.Location = new System.Drawing.Point(0, 250);
            this.pnlPlayList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlayList.Name = "pnlPlayList";
            this.pnlPlayList.Size = new System.Drawing.Size(400, 120);
            this.pnlPlayList.TabIndex = 5;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnPlay);
            this.pnlContainer.Controls.Add(this.btnPause);
            this.pnlContainer.Controls.Add(this.lbPlayingSong);
            this.pnlContainer.Controls.Add(this.cbTurnOffMusic);
            this.pnlContainer.Controls.Add(this.btnOpen);
            this.pnlContainer.Controls.Add(this.lbTimeDuration);
            this.pnlContainer.Controls.Add(this.btnNext);
            this.pnlContainer.Controls.Add(this.lbTimeRun);
            this.pnlContainer.Controls.Add(this.btnPrev);
            this.pnlContainer.Controls.Add(this.prcTimeMusic);
            this.pnlContainer.Controls.Add(this.btnSongName);
            this.pnlContainer.Controls.Add(this.btnLogo);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(400, 370);
            this.pnlContainer.TabIndex = 6;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnPlay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlay.BorderRadius = 60;
            this.btnPlay.BorderSize = 0;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(166, 142);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.TextColor = System.Drawing.Color.White;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnPause.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnPause.BackgroundImage = global::FinalGameTetris.Properties.Resources.btnPause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPause.BorderRadius = 60;
            this.btnPause.BorderSize = 0;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(166, 142);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 8;
            this.btnPause.TextColor = System.Drawing.Color.White;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lbPlayingSong
            // 
            this.lbPlayingSong.AllowDrop = true;
            this.lbPlayingSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.lbPlayingSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPlayingSong.Font = new System.Drawing.Font("Mangabey", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayingSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.lbPlayingSong.Location = new System.Drawing.Point(135, 25);
            this.lbPlayingSong.Name = "lbPlayingSong";
            this.lbPlayingSong.Size = new System.Drawing.Size(245, 73);
            this.lbPlayingSong.TabIndex = 7;
            this.lbPlayingSong.Text = "Name";
            this.lbPlayingSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPlayingSong.UseCompatibleTextRendering = true;
            // 
            // cbTurnOffMusic
            // 
            this.cbTurnOffMusic.AutoSize = true;
            this.cbTurnOffMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbTurnOffMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnOffMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbTurnOffMusic.Location = new System.Drawing.Point(17, 219);
            this.cbTurnOffMusic.Name = "cbTurnOffMusic";
            this.cbTurnOffMusic.Size = new System.Drawing.Size(103, 19);
            this.cbTurnOffMusic.TabIndex = 6;
            this.cbTurnOffMusic.Text = "Turn off music";
            this.cbTurnOffMusic.UseVisualStyleBackColor = true;
            this.cbTurnOffMusic.Click += new System.EventHandler(this.cbTurnOffMusic_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnOpen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnOpen.BackgroundImage = global::FinalGameTetris.Properties.Resources.btnOpen;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpen.BorderRadius = 40;
            this.btnOpen.BorderSize = 0;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(278, 152);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 40);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.TextColor = System.Drawing.Color.White;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnNext.BackgroundImage = global::FinalGameTetris.Properties.Resources.btnNext;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 40;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(232, 152);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnPrev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnPrev.BackgroundImage = global::FinalGameTetris.Properties.Resources.btnPrev;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 40;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(120, 152);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 40);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.TextColor = System.Drawing.Color.White;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSongName
            // 
            this.btnSongName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnSongName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnSongName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSongName.BorderRadius = 40;
            this.btnSongName.BorderSize = 0;
            this.btnSongName.Enabled = false;
            this.btnSongName.FlatAppearance.BorderSize = 0;
            this.btnSongName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongName.Font = new System.Drawing.Font("Hack Nerd Font", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongName.ForeColor = System.Drawing.Color.White;
            this.btnSongName.Location = new System.Drawing.Point(125, 10);
            this.btnSongName.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.btnSongName.Name = "btnSongName";
            this.btnSongName.Size = new System.Drawing.Size(265, 100);
            this.btnSongName.TabIndex = 1;
            this.btnSongName.TextColor = System.Drawing.Color.White;
            this.btnSongName.UseVisualStyleBackColor = false;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLogo.BackgroundImage = global::FinalGameTetris.Properties.Resources.Music;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogo.BorderRadius = 40;
            this.btnLogo.BorderSize = 0;
            this.btnLogo.Enabled = false;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Location = new System.Drawing.Point(10, 10);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(10, 10, 0, 5);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(110, 100);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TextColor = System.Drawing.Color.White;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // timerMusic
            // 
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // FMusic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.pnlPlayList);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMusic";
            this.Text = "FMusic";
            this.Load += new System.EventHandler(this.FMusic_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTButton btnLogo;
        private CTButton btnSongName;
        private System.Windows.Forms.ProgressBar prcTimeMusic;
        private System.Windows.Forms.Label lbTimeRun;
        private System.Windows.Forms.Label lbTimeDuration;
        private System.Windows.Forms.FlowLayoutPanel pnlPlayList;
        private System.Windows.Forms.Panel pnlContainer;
        private CTButton btnPrev;
        private CTButton btnPlay;
        private CTButton btnNext;
        private CTButton btnOpen;
        private System.Windows.Forms.Label lbPlayingSong;
        private CTButton btnPause;
        private System.Windows.Forms.Timer timerMusic;
        public System.Windows.Forms.CheckBox cbTurnOffMusic;
    }
}