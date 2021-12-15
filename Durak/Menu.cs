using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using Durak.Classes;
using Durak.Properties;

namespace Durak
{
    public partial class Menu : Form
    {
        Deck fullDeck; // full deck of cards
        Deal deal; // dealed hands
        Card trumpCard; // trump card
        List<Card> playerCards; // player 1 cards on the table
        List<Card> computerCards; // player 2 cards on the table
        List<Card> restCards; // rest cards above the trump card
        List<Card> discardPileCards; // discard pile cards
        List<Card> riverCards ; // deck cards
        Player player; // player 1 
        Computer computer; // player 2
        int MaxThrownCards = 0; // max cards that can be thrown
        
        
        public Menu()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            fullDeck = new Deck(); // full deck of cards
            deal = new Deal(); // dealed hands
            trumpCard = new Card(); // trump card
            playerCards = new List<Card>(); // player 1 cards on the table
            computerCards = new List<Card>(); // player 2 cards on the table
            restCards = new List<Card>(); // rest cards above the trump card
            discardPileCards = new List<Card>(); // discard pile cards
            riverCards = new List<Card>(); // deck cards
            
            ClearPanels();
            deal.DealCards();
            
            playerCards = deal.SortedPlayerHand;
            computerCards = deal.SortedComputerHand;
            trumpCard = deal.GetTrump;
            restCards = deal.Deck;

            //check
            /*computerCards = new List<Card>()
            {
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.HEARTS,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.DIAMONDS,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.ACE
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.ACE
                },
            };*/
            
            
            //real conditions
            /*bool step = FirstStepPlayer(playerCards, computerCards, trumpCard);
            label1.Text = $@" {(step ? "Player " : "Ai")} starts";
            player = new Player("Player", playerCards, step);
            computer = new Computer("Ai", computerCards, !step); // class Computer not class Player */ 
            
            
            //test conditions for testing
            player = new Player("Player", playerCards, false);
            computer = new Computer("Player2", computerCards, true); // same class for test
            
            if (computer.GetIsAttacked())
            {
                computer.Attack(riverCards,trumpCard);
                btnZabirai.Enabled = true;
                MaxThrownCards++;
            }
            ShowAllCards();


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
            //Player attack
            if (MaxThrownCards < 6 )
            {
                if (player.GetIsAttacked())
                {
                    btnOtboi.Enabled = true;
                    if (computer.GetFalseDefend()) // we are check if computer defend successful if he falsed, so we only attacking him
                    {
                        player.Attack(card, riverCards);
                    }
                    else // if he still not falsed, he continue to attack and he defend
                    {
                        player.Attack(card, riverCards); // player attack
                        if (player.GetFalseAttack() == false) // if player's card was thrown to the river - FalsedAttack == false and computer continue to defend
                        {
                            computer.Defend(card, riverCards, trumpCard);
                            if (computer.GetFalseDefend()) // only check for label message
                            {
                                label2.Text = "False defend";
                            }
                        }
                    }
                }

                

                //Player defend
                else if (computer.GetIsAttacked())
                {
                    if (!player.GetFalseDefend())
                    {
                        player.Defend(card, riverCards, trumpCard);
                        computer.Attack(riverCards, trumpCard);
                        if (computer.GetFalseAttack() && !player.GetFalseDefend())
                        {
                            btnZabirai.Enabled = false;
                            btnOtboi.Enabled = true;
                        }
                        else
                        {
                            btnZabirai.Enabled = true;
                            btnOtboi.Enabled = false;
                        }
                    }
                    
                    
                    
                    
                }
                if (riverCards.Count == 12)
                {
                    StartNextDeal();
                    player.SetIsAttacked(!player.GetIsAttacked());
                    //player.SetFalseDefend(!player.GetFalseDefend());
                    computer.SetIsAttacked(!computer.GetIsAttacked());
                }

                MaxThrownCards++;
            }

            ShowAllCards();
            var list = riverCards.Select(x => x.Cvalue).ToList();
            label1.Text = $"PC\n{string.Join("\n", computerCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
            label1.Text += $"\n==========\n{string.Join("\n", riverCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
            label1.Text += $"\n==========\nPlayer\n{string.Join("\n", playerCards.Select(x => x.Cvalue.ToString() + " " + x.Csuit.ToString()[0]))}";
             
        }
        private void btnZabirai_Click(object sender, EventArgs e)
        {
            label2.Text = "False defend Player";
            player.SetFalseDefend(!player.GetFalseDefend());
            if (btnZabirai.Text == "Take all")
            {
                playerCards.AddRange(riverCards);
                btnZabirai.Text = "Take";
                
                StartNextDeal();
                computer.SetFalseAttack(!computer.GetFalseAttack());
                computer.Attack(riverCards, trumpCard);
                ShowDiscardPileCard(); // show discard pile card   
                ShowAllCards(); // show all cards
            }
            else
            {
                var temp = riverCards.Count;
                //while (computer.CountOfAttackedCards > 0 && MaxThrownCards < 6)
                while (!computer.GetFalseAttack() && MaxThrownCards < 6)
                {
                    computer.Attack(riverCards, trumpCard);
                    MaxThrownCards++;
                }
                
                if (temp != riverCards.Count)
                {
                    ShowAllCards();
                    btnZabirai.Text = "Take all";
                }
                else
                {
                    playerCards.AddRange(riverCards);
                    StartNextDeal();
                    computer.SetFalseAttack(!computer.GetFalseAttack());
                    computer.Attack(riverCards, trumpCard);
                }
                MaxThrownCards = 0;
                ShowDiscardPileCard(); // show discard pile card   
                ShowAllCards(); // show all cards
            }
            
            
            // make Time delay  five seconds for next round
            //Thread.Sleep(5000);

        }

        private void btnOtboi_Click(object sender, EventArgs e)
        {
            StartNextDeal(); 
            if (!computer.GetFalseDefend() && player.GetIsAttacked())
            {
                player.SetIsAttacked(!player.GetIsAttacked()); 
                computer.SetIsAttacked(!computer.GetIsAttacked()); 
            }
            else if (computer.GetFalseAttack())
            {
                player.SetIsAttacked(true);
                computer.SetIsAttacked(false);
            }
            //TODO add condition if computer.GetFalseAttack() == false but player took cards and next attack is computer's
            ShowDiscardPileCard(); // show discard pile card   
            ShowAllCards(); // show all cards
            MaxThrownCards = 0;
            btnOtboi.Enabled = false;
        }

        private void StartNextDeal()
        {
            ClearRiver(); // remove cards from river
            
            if (player.GetIsAttacked())
            {
                DealCardsToPlayers(playerCards);
                DealCardsToPlayers(computerCards);
                //check
                computer.Attack(riverCards,trumpCard);
            }
            else
            {
                DealCardsToPlayers(computerCards);
                DealCardsToPlayers(playerCards);
            }
            
            
            
            
            void DealCardsToPlayers(List<Card> restCards)
            {
                var temp = restCards.Count;
                for (int i = 0; i < 6 - temp && this.restCards.Count > 0; i++)
                {
                    restCards.Add(this.restCards[0]);
                    this.restCards.RemoveAt(0);
                }
            }
            
        }

        private void ClearRiver()
        {
            discardPileCards.AddRange(riverCards);
            riverCards.Clear();
            pnlDeck.Controls.Clear();
        }


        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ClearPanels()
        {
            label1.Text = "";
            label2.Text = "";
            btnOtboi.Enabled = false;
            pnlAi.Controls.Clear();
            pnlDeck.Controls.Clear();
            pnlPlayer.Controls.Clear();
            pnlTrump.Controls.Clear();
            pnlAboveTrump.Controls.Clear();
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

        private void ShowDiscardPileCard()
        {
            var myCard = new CustomCardControl();
            myCard.Size = new Size(71, 100);
            myCard.BorderStyle = BorderStyle.None;
            myCard.Left = 0;
            pnlDiscardPile.Controls.Add(myCard);
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