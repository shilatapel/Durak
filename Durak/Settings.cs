using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Durak.Properties;

namespace Durak
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            picBoxSuit.Image = Resources.ResourceManager.GetObject("back1") as Image;
            picBoxSuit.SizeMode = PictureBoxSizeMode.StretchImage;

            

        }
        private void btnTableLeft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuitLeft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuitRight_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTableRight_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}