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
    public partial class FNotify : Form
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
        public bool isOK;
        public FNotify(string mess, string leftText, string rightText)
        {
            InitializeComponent();
            isOK = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            lbMessage.Text  = mess;
            btnOK.Text  = leftText;
            btnCancel.Text = rightText;

            if (mess == "Game Over")
            {
                pcbEndGame.Visible = true;
                pcbOther.Visible = false;
            }
            else
            {
                pcbEndGame.Visible = false;
                pcbOther.Visible = true;
            }

            lbMessage.Font = new Font(Cons.newFont.Families[1], 20, FontStyle.Regular);
            btnOK.Font = btnCancel.Font = new Font(Cons.newFont.Families[1], 16, FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isOK = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            isOK = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOK = false;
            this.Close();
        }
    }
}
