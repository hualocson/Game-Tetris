
namespace FinalGameTetris
{
    partial class FNotify
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
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pcbOther = new System.Windows.Forms.PictureBox();
            this.pcbEndGame = new System.Windows.Forms.PictureBox();
            this.btnOK = new FinalGameTetris.CTButton();
            this.btnCancel = new FinalGameTetris.CTButton();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEndGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.lbMessage.Font = new System.Drawing.Font("Mangabey", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.lbMessage.Location = new System.Drawing.Point(14, 64);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(252, 41);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Do you want to quit Game?";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(128)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnExit.Location = new System.Drawing.Point(257, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.pnlContainer.Controls.Add(this.pcbOther);
            this.pnlContainer.Controls.Add(this.pcbEndGame);
            this.pnlContainer.Controls.Add(this.lbMessage);
            this.pnlContainer.Controls.Add(this.btnExit);
            this.pnlContainer.Controls.Add(this.btnOK);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(280, 160);
            this.pnlContainer.TabIndex = 9;
            // 
            // pcbOther
            // 
            this.pcbOther.Image = global::FinalGameTetris.Properties.Resources.Other;
            this.pcbOther.Location = new System.Drawing.Point(68, 0);
            this.pcbOther.Name = "pcbOther";
            this.pcbOther.Size = new System.Drawing.Size(139, 61);
            this.pcbOther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOther.TabIndex = 10;
            this.pcbOther.TabStop = false;
            // 
            // pcbEndGame
            // 
            this.pcbEndGame.Image = global::FinalGameTetris.Properties.Resources.GameOver;
            this.pcbEndGame.Location = new System.Drawing.Point(68, 0);
            this.pcbEndGame.Name = "pcbEndGame";
            this.pcbEndGame.Size = new System.Drawing.Size(139, 61);
            this.pcbEndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEndGame.TabIndex = 9;
            this.pcbEndGame.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 15;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(123)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Mangabey", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnOK.Location = new System.Drawing.Point(14, 108);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(123)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Mangabey", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnCancel.Location = new System.Drawing.Point(146, 108);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(235)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNotify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNotify";
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEndGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlContainer;
        private CTButton btnOK;
        private System.Windows.Forms.PictureBox pcbEndGame;
        private System.Windows.Forms.PictureBox pcbOther;
        private CTButton btnCancel;
    }
}