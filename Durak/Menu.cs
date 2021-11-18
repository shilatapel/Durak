using System;
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
            toolStripTextBoxHi.Text = "hi" + logIn.NickName;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
