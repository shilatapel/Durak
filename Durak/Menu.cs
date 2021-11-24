using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Durak.Classes;
using Durak.Properties;

namespace Durak
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            var deckOfCards = new DeckOfCards();
            var dealCards = new DealCards();
            dealCards.Deal();
            //ShowTrump(dealCards.GetTrump);
            ShowTrump(dealCards.Deck);
            ShowPlayerCards(dealCards.SortedPlayerHand);
            ShowAiCards(dealCards.SortedComputerHand);
            ShowDeckAboveTrumpCard(dealCards.Deck.Count);
        }

        //private void ShowTrump(Card trump)
        private void ShowTrump(List<Card> cards)
        {
            
            pnlTrump.Controls.Clear();
            
            // TODO: When trump will be given to any player, need to change "trump.InHand" = false
            if (cards.Count > 0)
            {
                var trump = cards.Last();
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(trump.GetName()) as Image;
                myCard.Size = new Size(100, 80);
                myCard.Card = trump;
                myCard.RotateFlipImage(myCard.Image);
                pnlTrump.Controls.Add(myCard);
                pnlTrump.SendToBack();
            }
            else
                pnlTrump.Visible = false;
            
        }

        private void ShowDeckAboveTrumpCard(int count)
        {
            pnlAboveTrump.Controls.Clear();
            if (count > 1)
            {
                for (var i = count-2; i >= 0; i--)
                {
                    var myCard = new CustomCardControl();
                    myCard.Size = new Size(80, 100);
                    myCard.BorderStyle = BorderStyle.None;
                    myCard.Left = i;
                    pnlAboveTrump.Size = new Size(70+count, 100);
                    pnlAboveTrump.Controls.Add(myCard);
                } 
            }
            else
                pnlAboveTrump.Visible = false;
            
        }

        private void ShowPlayerCards(List<Card> cards)
        {
            pnlPlayer.Controls.Clear();
            for (var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.Size = new Size(80, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                myCard.Left = i * 80;
                myCard.Card = cards[i];
                myCard.CardClick += CardClick;
                pnlPlayer.Controls.Add(myCard);
                
            }
        }


        private void ShowAiCards(List<Card> cards)
        {
            pnlAi.Controls.Clear();
            for (var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Size = new Size(80, 100);
                myCard.Left = i * 20;
                pnlAi.Controls.Add(myCard);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripTextBoxHi.Text = @"hi" + logIn.NickName;
        }

        private void CardClick(object sender, EventArgs e)
        {
            MessageBox.Show(((CustomCardControl) sender).Name);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}