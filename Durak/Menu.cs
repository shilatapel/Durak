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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormClosed += Menu_FormClosed;
            toolStripTextBoxHi.Text = "hi" + logIn.NickName;

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


    }
}
