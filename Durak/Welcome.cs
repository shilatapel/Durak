using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            prgBar.Value = 0;
            timer1.Interval = 45;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBar.Visible = true;
            prgBar.Increment(1);
            if (prgBar.Value <= 35)
            {
                lbl1.Text = "Initializing...........";

            }
            else if (prgBar.Value <= 55)
            {
                lbl1.Text = "Loading .......";

            }
            else if (prgBar.Value <= 80)
            {
                lbl1.Text = "Getting Ready To Use...";

            }
            else
            {
                if (prgBar.Value == 100)
                {

                    timer1.Enabled = false;
                    prgBar.Visible = false;
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
