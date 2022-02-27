using System;
using System.Windows.Forms;

namespace Durak
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        //func Show Welcome screen with image and progress bar
        private void Welcome_Load(object sender, EventArgs e)
        {
            prgBar.Value = 0;
            timer1.Interval = 45;
            timer1.Enabled = true;
        }

        //show title in progress bar according the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBar.Visible = true;
            prgBar.Increment(1);
            if (prgBar.Value <= 35)
            {
                prgBar.CustomText = "Initializing...........";
            }
            else if (prgBar.Value <= 55)
            {
                prgBar.CustomText = "Loading .......";
            }
            else if (prgBar.Value <= 80)
            {
                prgBar.CustomText = "Getting Ready To Use...";
            }
            else
            {
                if (prgBar.Value == 100)
                {
                    timer1.Enabled = false;
                    prgBar.Visible = false;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}