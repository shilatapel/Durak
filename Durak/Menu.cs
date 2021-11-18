using System;
using System.Windows.Forms;

namespace Durak
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DealCards deal = new DealCards();
            deal.setUpDeck();
            deal.getHand();
            
            string a = "";
            foreach(var item in deal.PlayerHand)
            {
                a += item.Cvalue + " " + item.Csuit + "\n";
            }
            label1.Text = a + "\n============\n";
            string b = "";
            foreach(var item in deal.ComputerHand)
            {
                b += item.Cvalue + " " + item.Csuit + "\n";
            }
            label2.Text = b + "\n============\n";
            deal.sortHand();
            foreach(var item in deal.SortedPlayerHand)
            {
                label1.Text += item.Cvalue + " " + item.Csuit + "\n";
            }
            foreach(var item in deal.SortedComputerHand)
            {
                label2.Text += item.Cvalue + " " + item.Csuit + "\n";
            }

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
