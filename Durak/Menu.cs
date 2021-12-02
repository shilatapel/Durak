using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using Durak.Classes;
using Durak.Properties;

namespace Durak
{
    public partial class Menu : Form
    {
        Deck fullDeck= new Deck(); // full deck of cards
        Deal deal = new Deal(); // dealed hands
        Card trumpCard = new Card(); // trump card
        List<Card> playerCards = new List<Card>(); // player 1 cards on the table
        List<Card> computerCards = new List<Card>(); // player 2 cards on the table
        List<Card> restCards = new List<Card>(); // rest cards above the trump card
        List<Card> discardPileCards = new List<Card>(); // discard pile cards
        List<Card> riverCards = new List<Card>(); // deck cards
        Player player; // player 1 
        Computer computer; // player 2
        
        
        public Menu()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            deal.DealCards();
            
            playerCards = deal.SortedPlayerHand;
            computerCards = deal.SortedComputerHand;
            trumpCard = deal.GetTrump;
            restCards = deal.Deck;

            ShowAllCards();
            
            //real conditions
            /*bool step = FirstStepPlayer(playerCards, computerCards, trumpCard);
            label1.Text = $@" {(step ? "Player " : "Ai")} starts";
            player = new Player("Player", playerCards, step);
            computer = new Computer("Ai", computerCards, !step); // class Computer not class Player */ 
            
            
            //test conditions for testing
            player = new Player("Player", playerCards, true);
            computer = new Computer("Player2", computerCards, false); // same class for test
            
            


        }

        //choose who starts the game by searching the lowest trump card or if not found the will be random
        private bool FirstStepPlayer(List<Card> player1Cards, List<Card> player2Card, Card trump)
        {

            var tempList = player1Cards.ToList();
            tempList.AddRange(player2Card); // add player 2 cards to player 1 cards
            var lowestTrumpCard = tempList.Where(x => x.Csuit == trump.Csuit).Select(x => x).OrderBy(x => x.Cvalue).FirstOrDefault(); // search for the lowest trump card
            
            /*if(lowestTrumpCard == null) // if card not found, so by random 
            {
                var rnd = new Random();
                var rndNumber = rnd.Next(0, 2);
                return rndNumber == 0; // if 0 then player 1 starts the game
            }*/
            return lowestTrumpCard != null ? player1Cards.Contains(lowestTrumpCard) : new Random().Next(0, 2) == 0 ; // if lowest TrumpCard not null(it means, card was found), so by the lowest card else by random

        }

        
        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripTextBoxHi.Text = @"hi" + logIn.NickName;
        }

        private void CardClick(object sender, EventArgs e)
        {
            var card = (CustomCardControl)sender;

            if (player.GetIsAttacked())
            {
                player.Attack(card,riverCards);
                computer.Defend(card,riverCards,trumpCard);
                ShowAllCards();
            }
            var list = riverCards.Select(x => x.Cvalue).ToList();
            label1.Text = $"PC\n{string.Join("\n", computerCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
            label1.Text += $"\n==========\n{string.Join("\n", riverCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
            label1.Text += $"\n==========\nPlayer\n{string.Join("\n", playerCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
            
            
            //ShowAllCards();
            
            
        }

        
        
        
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // StartGame();
        }
        
        private void ShowAllCards()
        {
            ShowTrump(trumpCard);
            ShowPlayerCards(playerCards);
            ShowAiCards(computerCards);
            ShowDeckAboveTrumpCard(restCards);
            ShowDeckCards(riverCards);
        }
        
        
        private void ShowTrump(Card trump)
        {
            
            pnlTrump.Controls.Clear();
            
            // TODO: When trump will be given to any player, need to change "trump.InHand" = false
            if (restCards.Count > 0)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(trump.GetName()) as Image;
                myCard.Size = new Size(100, 71);
                myCard.Card = trump;
                myCard.RotateFlipImage(myCard.Image);
                pnlTrump.Controls.Add(myCard);
                pnlTrump.SendToBack();
            }
            else
                pnlTrump.Visible = false;
            
        }

        private void ShowDeckAboveTrumpCard(List<Card> cards)
        {
            pnlAboveTrump.Controls.Clear();
            var count = cards.Count;
            if (count > 1)
            {
                for (var i = count-2; i >= 0; i--)
                {
                    var myCard = new CustomCardControl();
                    myCard.Size = new Size(71, 100);
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
                myCard.Size = new Size(71, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                myCard.Left = i * ((int)((pnlPlayer.Width - 55) / cards.Count));
                myCard.Card = cards[i];
                myCard.CardClick += CardClick;
                pnlPlayer.GetType().GetMethod("SetStyle",BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlPlayer, new object[]
                    {
                        ControlStyles.UserPaint | 
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer, true
                    });
                pnlPlayer.Controls.Add(myCard);
                
            }
        }



        private void ShowAiCards(List<Card> cards)
        {
            pnlAi.Controls.Clear();
            for (var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                
                //for check - later remove 
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.CardClick += CardClick;
                myCard.Card = cards[i];
                myCard.Name = cards[i].GetName();
                //
                
                myCard.Size = new Size(71, 100);
                myCard.Left = i * ((int)((pnlAi.Width - 55) / cards.Count));
                pnlAi.Controls.Add(myCard);
            }
        }

        private void ShowDeckCards(List<Card> cards)
        {
            pnlDeck.Controls.Clear();
            for (var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.Size = new Size(71, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                myCard.Left = i * 90;
                myCard.Card = cards[i];
                myCard.CardClick -= CardClick;
                pnlDeck.GetType().GetMethod("SetStyle",BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlPlayer, new object[]
                    {
                        ControlStyles.UserPaint | 
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer, true
                    });
                pnlDeck.Controls.Add(myCard);
            }
        }
    }
}