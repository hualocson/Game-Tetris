
namespace FinalGameTetris
{
    partial class FGame
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
            this.lbNext = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctNextShape = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FinalGameTetris.CTButton();
            this.pctGameBoard = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNextShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.lbNext.Font = new System.Drawing.Font("Mangabey", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbNext.Location = new System.Drawing.Point(304, 172);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(63, 48);
            this.lbNext.TabIndex = 2;
            this.lbNext.Text = "Next";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.lbScore.Font = new System.Drawing.Font("Mangabey", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbScore.Location = new System.Drawing.Point(264, 369);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(103, 48);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "Score: 0";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.lbLevel.Font = new System.Drawing.Font("Mangabey", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbLevel.Location = new System.Drawing.Point(264, 417);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(97, 48);
            this.lbLevel.TabIndex = 4;
            this.lbLevel.Text = "Level: 0";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnExit.Location = new System.Drawing.Point(393, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Controls.Add(this.pctNextShape);
            this.pnlContainer.Controls.Add(this.lbNext);
            this.pnlContainer.Controls.Add(this.lbScore);
            this.pnlContainer.Controls.Add(this.lbLevel);
            this.pnlContainer.Controls.Add(this.btnMenu);
            this.pnlContainer.Controls.Add(this.btnExit);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(418, 546);
            this.pnlContainer.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalGameTetris.Properties.Resources.TetrisLogo;
            this.pictureBox1.Location = new System.Drawing.Point(262, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pctNextShape
            // 
            this.pctNextShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pctNextShape.Location = new System.Drawing.Point(262, 217);
            this.pctNextShape.Name = "pctNextShape";
            this.pctNextShape.Size = new System.Drawing.Size(144, 144);
            this.pctNextShape.TabIndex = 1;
            this.pctNextShape.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.BorderRadius = 40;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Astrojets Demo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnMenu.Location = new System.Drawing.Point(262, 476);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(144, 40);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pctGameBoard
            // 
            this.pctGameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pctGameBoard.Location = new System.Drawing.Point(12, 34);
            this.pctGameBoard.Name = "pctGameBoard";
            this.pctGameBoard.Size = new System.Drawing.Size(240, 482);
            this.pctGameBoard.TabIndex = 0;
            this.pctGameBoard.TabStop = false;
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 546);
            this.Controls.Add(this.pctGameBoard);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGame";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNextShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGameBoard;
        private System.Windows.Forms.PictureBox pctNextShape;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlContainer;
        private CTButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}