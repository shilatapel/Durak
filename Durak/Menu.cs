using System;
using System.Windows.Forms;

namespace Durak
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DealCards dealCards = new DealCards();
            dealCards.setUpDeck();
            dealCards.getHand();
            foreach(var item in dealCards.PlayerHand)
            {
                label1.Text += item.Cvalue + " " + item.Csuit + "\n";
            }
            label1.Text += "\n============\n";
            foreach(var item in dealCards.ComputerHand)
            {
                label2.Text += item.Cvalue + " " + item.Csuit + "\n";
            }
            label2.Text += "\n============\n";
            dealCards.sortHand();
            foreach(var item in dealCards.SortedPlayerHand)
            {
                label1.Text += item.Cvalue + " " + item.Csuit + "\n";
            }
            foreach(var item in dealCards.SortedComputerHand)
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
