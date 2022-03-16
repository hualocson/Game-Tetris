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
    public partial class FHelp : Form
    {
        public FHelp()
        {
            InitializeComponent();
            //Set Font
            lbHeader.Font = new Font(Cons.newFont.Families[0], 24, FontStyle.Regular);
            foreach (var control in pnlInfo.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    var lb = control as Label;
                    lb.Font = new Font(Cons.newFont.Families[1], 18, FontStyle.Regular); ;
                }
            }
        }
    }
}
