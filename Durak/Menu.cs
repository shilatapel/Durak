using Durak.Classes;
using Durak.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Durak
{
    public partial class Menu : Form
    {
        private Computer computer; // player 2
        private List<Card> computerCards; // player 2 cards on the table
        private Deal deal; // dealed hands
        private List<Card> discardPileCards; // discard pile cards
        private Deck fullDeck; // full deck of cards
        private int MaxThrownCards; // max cards that can be thrown
        private Player player; // player 1 
        private List<Card> playerCards; // player 1 cards on the table
        private List<Card> restCards; // rest cards above the trump card
        private List<Card> riverCards; // deck cards
        private Card trumpCard; // trump card
        private bool btnTakeIsPressed; // if the button take is pressed

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
            MaxThrownCards = 0; // counter of max thrown cards
            btnTakeIsPressed = false; // if the button take is pressed
            btnTake.Text = "Take"; // button take text
            ClearPanels();
            deal.DealCards();

            //playerCards = deal.SortedPlayerHand;
            //computerCards = deal.SortedComputerHand;
            trumpCard = deal.GetTrump;
            restCards = deal.Deck;

            //check
            trumpCard = new Card()
            {
                Csuit = Card.SUIT.CLUBS,
                Cvalue = Card.VALUE.SEVEN
            };
            computerCards = new List<Card>()
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
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.SEVEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.SEVEN
                },
            };
            playerCards = new List<Card>()
            {
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.EIGHT
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.EIGHT
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.EIGHT
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.EIGHT
                },
                new Card()
                {
                    Csuit = Card.SUIT.SPADES,
                    Cvalue = Card.VALUE.EIGHT
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.EIGHT
                },
            };


            //real conditions
            var step = FirstStepPlayer(playerCards, computerCards, trumpCard);
            label1.Text = $@" {(step ? "Player " : "Ai")} starts";
            /*player = new Player("Player", playerCards, step);
            computer = new Computer("Ai", computerCards, !step); // class Computer not class Player 
            */


            //test conditions for testing
            player = new Player("Player", playerCards, false);
            computer = new Computer("Player2", computerCards, true); // same class for test

            if(computer.GetIsAttacked())
            {
                computer.Attack(riverCards, trumpCard);
                btnTake.Enabled = true;
                MaxThrownCards++;
            }

            ShowAllCards();
        }

        //choose who starts the game by searching the lowest trump card or if not found the will be random
        private bool FirstStepPlayer(List<Card> player1Cards, List<Card> player2Card, Card trump)
        {
            var tempList = player1Cards.ToList();
            tempList.AddRange(player2Card); // add player 2 cards to player 1 cards
            var lowestTrumpCard = tempList.Where(x => x.Csuit == trump.Csuit).Select(x => x).OrderBy(x => x.Cvalue)
                .FirstOrDefault(); // search for the lowest trump card

            return lowestTrumpCard != null
                ? player1Cards.Contains(lowestTrumpCard)
                : new Random().Next(0, 2) == 0; // if lowest TrumpCard not null(it means, card was found), so by the lowest card else by random
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripTextBoxHi.Text = @"hi" + logIn.NickName;
        }
        //TODO: check every time if any hand already empty and declare a winner
        private void CardClick(object sender, EventArgs e)
        {
            var card = (CustomCardControl)sender;
            //Player attack
            if(player.GetIsAttacked() && MaxThrownCards < 6)
            {
                btnDone.Enabled = true;
                if(computer.GetFalseDefend()) // we are check if computer defend successful if he falsed, so we only attacking him
                {
                    var length = riverCards.Count;
                    player.Attack(card, riverCards);
                    if(riverCards.Count > length)
                        MaxThrownCards++;
                }
                else // if he still not falsed, he continue to attack and he defend
                {
                    player.Attack(card, riverCards); // player attack
                    if(player.GetFalseAttack() == false) // if player's card was thrown to the river - FalsedAttack == false and computer continue to defend
                    {
                        MaxThrownCards++;
                        computer.Defend(card, riverCards, trumpCard);
                    }
                }
            }

            //Player defend
            else if(computer.GetIsAttacked())
            {
                player.Defend(card, riverCards, trumpCard); // player defend last card
                if(!player.GetFalseDefend()) // if player answered right computer continue to attack
                {
                    if (MaxThrownCards < 6)
                    {
                        computer.Attack(riverCards, trumpCard);
                        if(computer.GetFalseAttack()) // if computer can't attack and player defended well last card
                        {
                            computer.SetIsAttacked(false);
                            btnTake.Enabled = false;
                            btnDone.Enabled = true;
                        }
                        else if(!computer.GetFalseAttack()) // if computer can attack and player defended well previous card
                        {
                            MaxThrownCards++;
                            btnTake.Enabled = true;
                            btnDone.Enabled = false;
                        }
                    }
                    else // if computer already throw 6 cards
                    {
                        btnDone.Enabled = true;
                        btnTake.Enabled = false;
                    }
                }
                else // if player answered wrong computer continue to defend
                {
                    btnTake.Enabled = true;
                    btnDone.Enabled = false;
                }
            }
            
            //label1.Text = MaxThrownCards.ToString();
            ShowAllCards();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            btnTakeIsPressed = true;
            if(btnTake.Text == "Take all")
            {
                btnTake.Text = "Take";
                StartNextDeal();
            }
            else if(btnTake.Text == "Take")
            {
                var temp = riverCards.Count;
                var countOfMaxDrawnCards = playerCards.Count - 1;
                while(!computer.GetFalseAttack() && MaxThrownCards < 6 && countOfMaxDrawnCards != 0) //check < 6
                {
                    computer.Attack(riverCards, trumpCard);
                    if (!computer.GetFalseAttack())
                    {
                        countOfMaxDrawnCards--;
                        MaxThrownCards++;
                    }
                    
                }

                if(temp != riverCards.Count)
                {
                    ShowAllCards();
                    btnTake.Text = "Take all";
                }
                else
                {
                    StartNextDeal();
                }

            }
            //label1.Text = MaxThrownCards.ToString();
            //ShowDiscardPileCard(); // show discard pile card   
            ShowAllCards(); // show all cards
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            discardPileCards.AddRange(riverCards);
            StartNextDeal();
            //ShowDiscardPileCard(); // show discard pile card 
            
            ShowAllCards(); // show all cards
            //MaxThrownCards = 0;
            btnDone.Enabled = false;
        }

        private void StartNextDeal()
        {
            if(!btnTakeIsPressed)
            {
                if(!computer.GetFalseDefend() && player.GetIsAttacked() || riverCards.Count == 12 && player.GetIsAttacked())
                //  if computer defended well and we pressing button Done (end of player's attack) or 12 cards on the river when player attacks
                {
                    DealCardsToPlayers(playerCards);
                    DealCardsToPlayers(computerCards);
                    player.SetFalseAttack(false);
                    player.SetIsAttacked(false);
                    computer.SetIsAttacked(true);
                    ClearRiver();
                    computer.Attack(riverCards, trumpCard);
                    MaxThrownCards = 1;
                    btnTake.Enabled = true;

                }
                else if(computer.GetFalseAttack() || riverCards.Count == 12 && computer.GetIsAttacked())
                // if player defended well and we pressing button Done (end of computer's attack) or 12 cards on the river when computer attacks
                {
                    DealCardsToPlayers(computerCards);
                    DealCardsToPlayers(playerCards);
                    computer.SetFalseAttack(false);
                    computer.SetIsAttacked(false);
                    player.SetFalseAttack(false);
                    player.SetIsAttacked(true);
                    MaxThrownCards = 0;
                    ClearRiver();
                }
                else if(computer.GetFalseDefend() && player.GetIsAttacked())
                // if we attacking and computer taking cards from table
                {
                    computerCards.AddRange(riverCards);
                    DealCardsToPlayers(playerCards);
                    DealCardsToPlayers(computerCards);
                    computer.SetFalseDefend(false);
                    MaxThrownCards = 0;
                    ClearRiver();
                }
            }
            else if (btnTakeIsPressed) // in case in btnTakeIsPressed == true
            {
                playerCards.AddRange(riverCards);
                DealCardsToPlayers(computerCards);
                DealCardsToPlayers(playerCards);
                btnTakeIsPressed = false;
                player.SetFalseDefend(false);
                computer.SetFalseAttack(false);
                ClearRiver();
                computer.Attack(riverCards, trumpCard);
                MaxThrownCards = 1;
                btnTake.Enabled = true;
            }

            label1.Text =
            $"PC\nFDefend = {computer.GetFalseDefend()}\nFAttack = {computer.GetFalseAttack()}\nAttacked = {computer.GetIsAttacked()}\n" +
            $"\nPlayer\nFDefend = {player.GetFalseDefend()}\nFAttack = {player.GetFalseAttack()}\nAttacked = {player.GetIsAttacked()}";



            void DealCardsToPlayers(List<Card> restCards)
            {
                var temp = restCards.Count;
                for(var i = 0; i < 6 - temp && this.restCards.Count > 0; i++)
                {
                    restCards.Add(this.restCards[0]);
                    this.restCards.RemoveAt(0);
                }
                var query = restCards.GroupBy(x => x.Csuit).Select(x => new
                {
                    card = x.OrderBy(c => c.Cvalue),
                    suit = x.Key
                }).OrderBy(x => x.suit).SelectMany(x => x.card).ToList();
                restCards.Clear();
                restCards.AddRange(query);
            }
        }

        private void ClearRiver()
        {
            
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
            btnDone.Enabled = false;
            pnlAi.Controls.Clear();
            pnlDeck.Controls.Clear();
            pnlPlayer.Controls.Clear();
            pnlTrump.Controls.Clear();
            pnlAboveTrump.Controls.Clear();
            pnlDiscardPile.Controls.Clear();
        }

        private void ShowAllCards()
        {
            ShowTrump(trumpCard);
            //playerCards = player.SortHand(playerCards);
            //player.SortHand(playerCards);
            ShowPlayerCards(playerCards);
            ShowAiCards(computerCards);
            ShowDeckAboveTrumpCard(restCards);
            ShowDeckCards(riverCards);
            if(discardPileCards.Count > 0)
            {
                ShowDiscardPileCard();
            }
        }


        private void ShowTrump(Card trump)
        {
            pnlTrump.Controls.Clear();

            // TODO: When trump will be given to any player, need to change "trump.InHand" = false and leave visibility of trump card on table
            if(restCards.Count > 0)
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
            {
                pnlTrump.Visible = false;
            }
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
            if(count > 1)
                for(var i = count - 2; i >= 0; i--)
                {
                    var myCard = new CustomCardControl();
                    myCard.Size = new Size(71, 100);
                    myCard.BorderStyle = BorderStyle.None;
                    myCard.Left = i;
                    pnlAboveTrump.Size = new Size(70 + count, 100);
                    pnlAboveTrump.Controls.Add(myCard);
                }
            else
                pnlAboveTrump.Visible = false;
        }

        private void ShowPlayerCards(List<Card> cards)
        {
            pnlPlayer.Controls.Clear();
            
            for(var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.Size = new Size(71, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                myCard.Left = i * ((pnlPlayer.Width - 55) / cards.Count);
                myCard.Card = cards[i];
                myCard.CardClick += CardClick;
                pnlPlayer.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlPlayer, new object[]
                    {
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer,
                        true
                    });
                pnlPlayer.Controls.Add(myCard);
            }
        }


        private void ShowAiCards(List<Card> cards)
        {
            pnlAi.Controls.Clear();
            for(var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();

                //for check - later remove 
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.CardClick -= CardClick;
                myCard.Card = cards[i];
                myCard.Name = cards[i].GetName();
                //

                myCard.Size = new Size(71, 100);
                myCard.Left = i * ((pnlAi.Width - 55) / cards.Count);
                pnlAi.Controls.Add(myCard);
            }
        }

        private void ShowDeckCards(List<Card> cards)
        {
            //TODO: change location of covered cards
            pnlDeck.Controls.Clear();
            for(var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.Size = new Size(71, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                //myCard.Left = i * 90;
                myCard.Left = i * ((int)((pnlDeck.Width - 55) / cards.Count));
                myCard.Card = cards[i];
                myCard.CardClick -= CardClick;
                pnlDeck.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlPlayer, new object[]
                    {
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer,
                        true
                    });
                pnlDeck.Controls.Add(myCard);
            }
        }
    }
}