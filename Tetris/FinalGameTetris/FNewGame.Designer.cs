
namespace FinalGameTetris
{
    partial class FNewGame
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnHeader = new FinalGameTetris.CTButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnLV5 = new FinalGameTetris.CTButton();
            this.btnLV3 = new FinalGameTetris.CTButton();
            this.btnLV2 = new FinalGameTetris.CTButton();
            this.btnLV4 = new FinalGameTetris.CTButton();
            this.btnLV0 = new FinalGameTetris.CTButton();
            this.btnLV1 = new FinalGameTetris.CTButton();
            this.btnContainer = new FinalGameTetris.CTButton();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlContainer.Controls.Add(this.pnlHeader);
            this.pnlContainer.Controls.Add(this.pnlBody);
            this.pnlContainer.Controls.Add(this.pnlBar);
            this.pnlContainer.Controls.Add(this.btnStartGame);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(400, 370);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Controls.Add(this.btnHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnlHeader.Size = new System.Drawing.Size(400, 90);
            this.pnlHeader.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.pictureBox1.Image = global::FinalGameTetris.Properties.Resources.ChoiceLevel;
            this.pictureBox1.Location = new System.Drawing.Point(54, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.lbHeader.Location = new System.Drawing.Point(138, 13);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(221, 74);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Choice Level";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeader
            // 
            this.btnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnHeader.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHeader.BorderRadius = 40;
            this.btnHeader.BorderSize = 0;
            this.btnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeader.Enabled = false;
            this.btnHeader.FlatAppearance.BorderSize = 0;
            this.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeader.ForeColor = System.Drawing.Color.White;
            this.btnHeader.Location = new System.Drawing.Point(10, 10);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(380, 80);
            this.btnHeader.TabIndex = 0;
            this.btnHeader.TextColor = System.Drawing.Color.White;
            this.btnHeader.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlBody.Controls.Add(this.btnLV5);
            this.pnlBody.Controls.Add(this.btnLV3);
            this.pnlBody.Controls.Add(this.btnLV2);
            this.pnlBody.Controls.Add(this.btnLV4);
            this.pnlBody.Controls.Add(this.btnLV0);
            this.pnlBody.Controls.Add(this.btnLV1);
            this.pnlBody.Controls.Add(this.btnContainer);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBody.Location = new System.Drawing.Point(0, 90);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBody.Size = new System.Drawing.Size(400, 225);
            this.pnlBody.TabIndex = 9;
            // 
            // btnLV5
            // 
            this.btnLV5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV5.BorderRadius = 40;
            this.btnLV5.BorderSize = 0;
            this.btnLV5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV5.FlatAppearance.BorderSize = 0;
            this.btnLV5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV5.Location = new System.Drawing.Point(217, 156);
            this.btnLV5.Name = "btnLV5";
            this.btnLV5.Size = new System.Drawing.Size(140, 40);
            this.btnLV5.TabIndex = 6;
            this.btnLV5.Text = "Level 5";
            this.btnLV5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV5.UseVisualStyleBackColor = false;
            this.btnLV5.Click += new System.EventHandler(this.btnLV5_Click);
            this.btnLV5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnLV3
            // 
            this.btnLV3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV3.BorderRadius = 40;
            this.btnLV3.BorderSize = 0;
            this.btnLV3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV3.FlatAppearance.BorderSize = 0;
            this.btnLV3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV3.Location = new System.Drawing.Point(217, 90);
            this.btnLV3.Name = "btnLV3";
            this.btnLV3.Size = new System.Drawing.Size(140, 40);
            this.btnLV3.TabIndex = 4;
            this.btnLV3.Text = "Level 3";
            this.btnLV3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV3.UseVisualStyleBackColor = false;
            this.btnLV3.Click += new System.EventHandler(this.btnLV3_Click);
            this.btnLV3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnLV2
            // 
            this.btnLV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV2.BorderRadius = 40;
            this.btnLV2.BorderSize = 0;
            this.btnLV2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV2.FlatAppearance.BorderSize = 0;
            this.btnLV2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV2.Location = new System.Drawing.Point(36, 90);
            this.btnLV2.Name = "btnLV2";
            this.btnLV2.Size = new System.Drawing.Size(140, 40);
            this.btnLV2.TabIndex = 3;
            this.btnLV2.Text = "Level 2";
            this.btnLV2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV2.UseVisualStyleBackColor = false;
            this.btnLV2.Click += new System.EventHandler(this.btnLV2_Click);
            this.btnLV2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnLV4
            // 
            this.btnLV4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV4.BorderRadius = 40;
            this.btnLV4.BorderSize = 0;
            this.btnLV4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV4.FlatAppearance.BorderSize = 0;
            this.btnLV4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV4.Location = new System.Drawing.Point(36, 156);
            this.btnLV4.Name = "btnLV4";
            this.btnLV4.Size = new System.Drawing.Size(140, 40);
            this.btnLV4.TabIndex = 5;
            this.btnLV4.Text = "Level 4";
            this.btnLV4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV4.UseVisualStyleBackColor = false;
            this.btnLV4.Click += new System.EventHandler(this.btnLV4_Click);
            this.btnLV4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnLV0
            // 
            this.btnLV0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV0.BorderRadius = 40;
            this.btnLV0.BorderSize = 0;
            this.btnLV0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV0.FlatAppearance.BorderSize = 0;
            this.btnLV0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV0.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV0.Location = new System.Drawing.Point(36, 25);
            this.btnLV0.Name = "btnLV0";
            this.btnLV0.Size = new System.Drawing.Size(140, 40);
            this.btnLV0.TabIndex = 1;
            this.btnLV0.Text = "Level 0";
            this.btnLV0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV0.UseVisualStyleBackColor = false;
            this.btnLV0.Click += new System.EventHandler(this.btnLV0_Click);
            this.btnLV0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnLV1
            // 
            this.btnLV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV1.BorderRadius = 40;
            this.btnLV1.BorderSize = 0;
            this.btnLV1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLV1.FlatAppearance.BorderSize = 0;
            this.btnLV1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnLV1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnLV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV1.Location = new System.Drawing.Point(217, 25);
            this.btnLV1.Name = "btnLV1";
            this.btnLV1.Size = new System.Drawing.Size(140, 40);
            this.btnLV1.TabIndex = 2;
            this.btnLV1.Text = "Level 1";
            this.btnLV1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnLV1.UseVisualStyleBackColor = false;
            this.btnLV1.Click += new System.EventHandler(this.btnLV1_Click);
            this.btnLV1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnLV1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnContainer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContainer.BorderRadius = 40;
            this.btnContainer.BorderSize = 0;
            this.btnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContainer.Enabled = false;
            this.btnContainer.FlatAppearance.BorderSize = 0;
            this.btnContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContainer.ForeColor = System.Drawing.Color.White;
            this.btnContainer.Location = new System.Drawing.Point(10, 10);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(380, 205);
            this.btnContainer.TabIndex = 0;
            this.btnContainer.TextColor = System.Drawing.Color.White;
            this.btnContainer.UseVisualStyleBackColor = false;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBar.Location = new System.Drawing.Point(0, 315);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(400, 5);
            this.pnlBar.TabIndex = 8;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnStartGame.Location = new System.Drawing.Point(0, 320);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(400, 50);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // FNewGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNewGame";
            this.Text = "FNewGame";
            this.pnlContainer.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnStartGame;
        private CTButton btnLV5;
        private CTButton btnLV4;
        private CTButton btnLV3;
        private CTButton btnLV2;
        private CTButton btnLV1;
        private CTButton btnLV0;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlBody;
        private CTButton btnContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private CTButton btnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}