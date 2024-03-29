﻿using Durak.Classes;
using Durak.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace Durak
{
    public partial class Menu : Form
    {
        //Creating variables
        private Computer computer; // player 2
        private List<Card> computerCards; // player 2 cards on the table
        private Deal deal; // dealed hands
        private List<Card> discardPileCards; // discard pile cards
        private Deck fullDeck; // full deck of cards
        private int maxThrownCards; // max cards that can be thrown
        private Player player; // player 1 
        private List<Card> playerCards; // player 1 cards on the table
        private List<Card> restCards; // rest cards above the trump card
        private List<Card> riverCards; // deck cards
        private Card trumpCard; // trump card
        private bool btnTakeIsPressed; // if the button take is pressed
        
        /// <summary>
        ///  Initialize form and starting main function
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            StartGame();
        }
        
        //Function writes hi and the player name in the menu bar
        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripTextBoxHi.Text = @"Hi " + logIn.NickName + @" ";
        }

        // A function that starts the game, initialize all variables and determines who will play first and deals and shows the cards
        private void StartGame()
        { 

            //  Initializ variables
            fullDeck = new Deck(); // full deck of cards
            deal = new Deal(); // dealed hands
            trumpCard = new Card(); // trump card
            playerCards = new List<Card>(); // player 1 cards on the table
            computerCards = new List<Card>(); // player 2 cards on the table
            restCards = new List<Card>(); // rest cards above the trump card
            discardPileCards = new List<Card>(); // discard pile cards
            riverCards = new List<Card>(); // deck cards
            maxThrownCards = 0; // counter of max thrown cards
            btnTakeIsPressed = false; // if the button take is pressed
            btnTake.Text = @"Take"; // button take text
            pnlAboveTrump.Visible = true;
            ClearPanels();
            deal.DealCards();
            playerCards = deal.SortedPlayerHand;
            computerCards = deal.SortedComputerHand;
            trumpCard = deal.GetTrump;
            restCards = deal.Deck;

            //check test
            /*trumpCard = new Card()
            {
                Csuit = Card.SUIT.HEARTS,
                Cvalue = Card.VALUE.SIX
            };
            computerCards = new List<Card>()
            {
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.TEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.TEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.KING
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.QUEEN
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.JACK
                },
                new Card()
                {
                    Csuit = Card.SUIT.CLUBS,
                    Cvalue = Card.VALUE.ACE
                },
            };
            playerCards = new List<Card>()
            {
                new Card()
                {
                    Csuit = Card.SUIT.HEARTS,
                    Cvalue = Card.VALUE.TEN
                }
            };*/

            //real conditions
            var step = FirstStepPlayer(playerCards, computerCards, trumpCard);
            //label1.Text = $@" {(step ? "Player " : "Ai")} starts"; //test
            player = new Player("Player", playerCards, step);
            computer = new Computer("Ai", computerCards, !step); // class Computer not class Player 
            
            


            //test conditions for testing
            /*player = new Player("Player", playerCards, true);
            computer = new Computer("Player2", computerCards, false); // same class for test*/
            
            player.SetIsWinner(false);
            computer.SetIsWinner(false);
            // if computer's turn first, he starting attack
            if(computer.GetIsAttacked())
            {
                computer.Attack(riverCards, trumpCard);
                btnTake.Enabled = true;
                maxThrownCards++;
            }

            ShowAllCards();
        }

        
        //The function choose who starts the game by searching the lowest trump card or if not found the will be random
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


        /// <summary>
        ///  Processing click  on the card by player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClick(object sender, EventArgs e)
        {
            var card = (CustomCardControl)sender;
            //Player attack
            if(player.GetIsAttacked() && maxThrownCards < 6)
            {
                btnDone.Enabled = true;
                var length = riverCards.Count;
                player.Attack(card, riverCards);
                if(computer.GetFalseDefend()) // we are check if computer defend successful if he falsed, so we only attacking him
                {
                    if(riverCards.Count > length)
                        maxThrownCards++;
                }
                else if(!computer.GetFalseDefend())// if computer still not false, player continue to attack and computer defend
                {
                    if(player.GetFalseAttack() == false) // if player's card was thrown to the river - FalsedAttack == false and computer continue to defend
                    {
                        maxThrownCards++;
                        computer.Defend(card, riverCards, trumpCard);
                        if(computerCards.Count == 0 && restCards.Count == 0) // if player attacked and has no cards and rest cards is empty, so he is winner
                        {
                            computer.SetIsWinner(true);
                        }
                    }
                }
                if(playerCards.Count == 0 && restCards.Count == 0) // if player attacked and has no cards and rest cards is empty, so he is winner
                {
                    player.SetIsWinner(true);
                }
            }

            //Player defend
            else if(computer.GetIsAttacked())
            {
                // case if player answered right computer continue to attack and also checking if computer throwing not last card from hand (and his state isWinner = false)
                if(!player.GetFalseDefend() && !computer.GetIsWinner()) 
                {
                    player.Defend(card, riverCards, trumpCard); // player defending last card
                    if (!player.GetFalseDefend()) // if defended last card
                    {
                        switch (playerCards.Count)
                        {
                            // if player has no cards and rest cards is empty and computer has no cards, so them states are IsWinner = true
                            case 0 when (restCards.Count == 0 && computerCards.Count == 0):
                                player.SetIsWinner(true);
                                computer.SetIsWinner(true);
                                break;
                            // if player has no cards and rest cards is empty and previous condition didn't happen,
                            // it means that computer has cards and player's state isWinner = true
                            case 0 when restCards.Count == 0:
                                player.SetIsWinner(true);
                                break;
                        }
                        
                        if (maxThrownCards < 6) // if from computer was thrown less than 6 cards he continue to attack
                        {
                            computer.Attack(riverCards, trumpCard);
                            if(computer.GetFalseAttack()) // if computer don't have card to attack
                            {
                                computer.SetIsAttacked(false);
                                btnTake.Enabled = false;
                                btnDone.Enabled = true;
                            }
                            else if(!computer.GetFalseAttack()) // if computer attacked well 
                            {
                                maxThrownCards++;
                                btnTake.Enabled = true;
                                btnDone.Enabled = false;
                            }
                            if(computerCards.Count == 0 && restCards.Count == 0 && playerCards.Count > 1) // if computer attacked and it was his last card his state IsWinner = true
                            {
                                computer.SetIsWinner(true);
                            }
                        
                        }
                        else // if computer already throw 6 cards
                        {
                            btnDone.Enabled = true;
                            btnTake.Enabled = false;
                        }
                    }
                    
                }
                // case if player answered on computer's last card and he still has cards and computer already with state isWinner = true
                else if (!player.GetFalseDefend() && computer.GetIsWinner()) 
                {
                    //statement can be empty, cause outside of this if statement executes same functions
                    ShowAllCards();
                    CheckResultGame();
                }
                // any another case are -  player answering with wrong card and he continue to defend.
                else
                {
                    player.SetFalseDefend(false);
                    btnTake.Enabled = true;
                    btnDone.Enabled = false;
                }
            }
            ShowAllCards();
            CheckResultGame();
            
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            btnTakeIsPressed = true;
            player.SetFalseDefend(true);
            switch (btnTake.Text)
            {
                case "Take":
                {
                    var temp = riverCards.Count; // count of cards in river if player decided to take card
                    var countOfMaxDrawnCards = playerCards.Count - 1; // max count of cards that player can take in hand from river
                    
                    // till computer has cards to attack and count of thrown cards less then 6 and count of cards that player can take(on each step) not equal 0 
                    while(!computer.GetFalseAttack() && maxThrownCards < 6 && countOfMaxDrawnCards != 0) //check < 6
                    {
                        computer.Attack(riverCards, trumpCard);
                        if (!computer.GetFalseAttack()) // case if computer attacked well
                        {
                            countOfMaxDrawnCards--; // count of cards that player can take in hand from river became less 1
                            maxThrownCards++; // count of cards that player already throw in river became more 1
                            
                            // case if computer attacked and it was his last card his state IsWinner = true
                            if(computerCards.Count == 0 && restCards.Count == 0) 
                            {
                                computer.SetIsWinner(true);
                            }
                        } 
                    }
                    // here we are checking if computer thrown cards as button "Take" was pressed 
                    if(temp != riverCards.Count)
                    {
                        btnTake.Text = @"Take all";
                    }
                    // if not happened nothing 
                    else
                    {
                        StartNextDeal();
                    }

                    break;
                }
                // case if computer thrown more cards after player pressed button "Take" 
                case "Take all":
                    btnTake.Text = @"Take";
                    StartNextDeal();
                    break;
            }
            // showing  results after button in any state was pressed
            ShowAllCards(); 
            CheckResultGame();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!(player.GetIsAttacked() && computer.GetFalseDefend() ||
                computer.GetIsAttacked() && player.GetFalseDefend())) // case if we need to throw cards to discard pile and after display it
            {
                discardPileCards.AddRange(riverCards);
            }
            
            StartNextDeal();
            ShowAllCards(); 
            btnDone.Enabled = false;
        }

        /// <summary>
        /// Function that start next deal and reset all variables and buttons
        /// </summary>
        private void StartNextDeal()
        {
            //case if computer's state IsWinner = true same as if(computer.IsWinner)
            if(computerCards.Count == 0 && restCards.Count == 0) 
            {
                playerCards.AddRange(riverCards);
                ClearRiver();
                computer.SetIsWinner(true);
            }
            switch (btnTakeIsPressed)
            {
                //  if computer defended well and we pressing button Done (end of player's attack) or 12 cards on the river when player attacks
                case false when !computer.GetFalseDefend() && player.GetIsAttacked() || riverCards.Count == 12 && player.GetIsAttacked():
                    DealCardsToPlayers(playerCards);
                    DealCardsToPlayers(computerCards);
                    player.SetFalseAttack(false);
                    player.SetIsAttacked(false);
                    computer.SetIsAttacked(true);
                    ClearRiver();
                    computer.Attack(riverCards, trumpCard);
                    maxThrownCards = 1;
                    btnTake.Enabled = true;
                    break;
                // if player defended well and we pressing button Done (end of computer's attack) or 12 cards on the river when computer attacks
                case false when computer.GetFalseAttack() || riverCards.Count == 12 && computer.GetIsAttacked():
                    DealCardsToPlayers(computerCards);
                    DealCardsToPlayers(playerCards);
                    computer.SetFalseAttack(false);
                    computer.SetIsAttacked(false);
                    player.SetFalseAttack(false);
                    player.SetIsAttacked(true);
                    maxThrownCards = 0;
                    ClearRiver();
                    break;
                case false:
                {
                    if(computer.GetFalseDefend() && player.GetIsAttacked())
                        // if we attacking and computer taking cards from table
                    {
                        computerCards.AddRange(riverCards);
                        DealCardsToPlayers(playerCards);
                        DealCardsToPlayers(computerCards);
                        computer.SetFalseDefend(false);
                        maxThrownCards = 0;
                        ClearRiver();
                    }

                    break;
                }
                // in case in btnTakeIsPressed == true
                case true when !computer.GetIsWinner():
                    playerCards.AddRange(riverCards);
                    DealCardsToPlayers(computerCards);
                    DealCardsToPlayers(playerCards);
                    btnTakeIsPressed = false;
                    player.SetFalseDefend(false);
                    computer.SetFalseAttack(false);
                    ClearRiver();
                    computer.Attack(riverCards, trumpCard);
                    maxThrownCards = 1;
                    btnTake.Enabled = true;
                    break;
            }


            //Check Test
            /*label1.Text =
            $"PC\nFDefend = {computer.GetFalseDefend()}\nFAttack = {computer.GetFalseAttack()}\nAttacked = {computer.GetIsAttacked()}\n" +
            $"\nPlayer\nFDefend = {player.GetFalseDefend()}\nFAttack = {player.GetFalseAttack()}\nAttacked = {player.GetIsAttacked()}\nCountDeck = {riverCards.Count}";   */


            //function deal to player and computer cards to complete 6 cards on hand. the cards sort
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

        //Clear River from cards
        private void ClearRiver()
        {
            riverCards.Clear();
            pnlDeck.Controls.Clear();
        }

       //Clear all Panels
        private void ClearPanels()
        {
            //label1.Text = "";
           
            btnDone.Enabled = false;
            pnlAi.Controls.Clear();
            pnlDeck.Controls.Clear();
            pnlPlayer.Controls.Clear();
            pnlTrump.Controls.Clear();
            pnlAboveTrump.Controls.Clear();
            pnlDiscardPile.Controls.Clear();
        }


         //The function checks the results of a draw, player win ,computer win  and update score
        private void CheckResultGame()
        {
            if (player.GetIsWinner() && computer.GetIsWinner())
            {
                logIn.drawPoints++;
                //Score.drawPoint++;
                MessageBox.Show(@"Draw");
                
                btnDone.Enabled = false;
                btnTake.Enabled = false;
            }
            else if (player.GetIsWinner())
            {
                logIn.playerPoints++;
                MessageBox.Show(@"You win!");
                btnDone.Enabled = false;
                btnTake.Enabled = false;
            }
            else if (computer.GetIsWinner())
            {
                logIn.computerPoints++;
                MessageBox.Show(@"You lose!");
                foreach (var card in pnlPlayer.Controls)
                {
                    ((CustomCardControl)card).CardClick -= CardClick;
                } 
                btnDone.Enabled = false;
                btnTake.Enabled = false;
            }
  
        }


        // Show All image Cards in the game
        private void ShowAllCards()
        {
            ShowTrump(trumpCard);
            ShowPlayerCards(playerCards);
            ShowAiCards(computerCards);
            ShowDeckAboveTrumpCard(restCards);
            ShowDeckCards(riverCards);
            if(discardPileCards.Count > 0)
            {
                ShowDiscardPileCard();
            }
        }

         //show trump card image
        private void ShowTrump(Card trump)
        {
            pnlTrump.Controls.Clear();
            var myCard = new CustomCardControl();
            myCard.Image = Resources.ResourceManager.GetObject(trump.GetName()) as Image;
            myCard.Size = new Size(100, 71);
            myCard.Card = trump;
            myCard.RotateFlipImage(myCard.Image);
            pnlTrump.Controls.Add(myCard);
            pnlTrump.SendToBack();
            pnlTrump.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                ?.Invoke(pnlTrump, new object[]
                {
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.DoubleBuffer,
                    true
                });
        }

        //  show  Discard PileCard image
        private void ShowDiscardPileCard()
        {
            var myCard = new CustomCardControl();
            myCard.Size = new Size(71, 100);
            myCard.BorderStyle = BorderStyle.None;
            myCard.Left = 0;
            pnlDiscardPile.Controls.Add(myCard);
            pnlDiscardPile.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                ?.Invoke(pnlDiscardPile, new object[]
                {
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.DoubleBuffer,
                    true
                });
        }

        //  Show Deck Above Trump Card   image
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
                    pnlAboveTrump.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                        ?.Invoke(pnlAboveTrump, new object[]
                        {
                            ControlStyles.UserPaint |
                            ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.DoubleBuffer,
                            true
                        });
                }
            else
                pnlAboveTrump.Visible = false;
            
        }


        //Show Player Cards images
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

        //Show computer Cards images
        private void ShowAiCards(List<Card> cards)  
        {
            pnlAi.Controls.Clear();
            for(var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();

                //for check - later remove 
                //myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.CardClick -= CardClick;
                //myCard.Card = cards[i];
                myCard.Name = cards[i].GetName();
                myCard.Size = new Size(71, 100);
                myCard.Left = i * ((pnlAi.Width - 55) / cards.Count);
                pnlAi.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlAi, new object[]
                    {
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer,
                        true
                    });
                pnlAi.Controls.Add(myCard);
            }
            
        }

       //Show Deck Cards
        private void ShowDeckCards(List<Card> cards)
        {
            pnlDeck.Controls.Clear();
            for(var i = cards.Count - 1; i >= 0; i--)
            {
                var myCard = new CustomCardControl();
                myCard.Image = Resources.ResourceManager.GetObject(cards[i].GetName()) as Image;
                myCard.Size = new Size(71, 100);
                myCard.Name = cards[i].GetName();
                myCard.AutoSizeMode = AutoSizeMode;
                //myCard.Left = i * 90;
                myCard.Left = i * ((pnlDeck.Width - 55) / cards.Count);
                myCard.Card = cards[i];
                myCard.CardClick -= CardClick;
                pnlDeck.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.Invoke(pnlDeck, new object[]
                    {
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.DoubleBuffer,
                        true
                    });
                pnlDeck.Controls.Add(myCard);
                
            }
            
        }


        //The function start a new game 
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        //The function save the game in a binary file
        private void SaveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //possible to save game only if winner is still unknown
            if (!player.GetIsWinner() && !computer.GetIsWinner())
            {
                try
                {        

                        FileStream fs = new FileStream("saveGame.bin", FileMode.Create); //create new binary file to save data
                        BinaryFormatter bf = new BinaryFormatter();  //pointer that write in binary file
                        fs.Position = 0; 
                        bf.Serialize(fs,trumpCard);
                        bf.Serialize(fs, playerCards);
                        bf.Serialize(fs, computerCards); 
                        bf.Serialize(fs,restCards);
                        bf.Serialize(fs, discardPileCards);
                        bf.Serialize(fs, riverCards);
                        bf.Serialize(fs, btnTakeIsPressed);
                        bf.Serialize(fs, maxThrownCards);
                        bf.Serialize(fs, btnTake.Text);
                        bf.Serialize(fs, btnTake.Enabled);
                        bf.Serialize(fs, btnDone.Enabled);
                        
                        bf.Serialize(fs, computer.GetIsAttacked());
                        bf.Serialize(fs, player.GetIsAttacked());
                        bf.Serialize(fs, computer.GetFalseDefend());
                        bf.Serialize(fs, player.GetFalseDefend());
                        bf.Serialize(fs, computer.GetFalseAttack());
                        bf.Serialize(fs, player.GetFalseAttack());

                    fs.Close();
                        
                        MessageBox.Show(@"GAME SAVED !");

                }
                catch (Exception err) {

                    MessageBox.Show(err.Message);
                } 
            }
        
            else
            {
                MessageBox.Show(@"You can't save game after game is over");
            }

        }
        
        //The function uploads from a binary file the game from the last point where it was stopped and saved
        private void LoadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            try
            { 
                bool computerisAttcked;
                bool playerisAttcked;

                if (!File.Exists("saveGame.bin"))
                    MessageBox.Show(@"No game saved!");



                //List<Card> check = new List<Card>();    //only for test
                FileStream fs = new FileStream("saveGame.bin", FileMode.Open); //open file to read 
                BinaryFormatter bf = new BinaryFormatter();  //pointer that read from binary file
                //check = (List<Card>)bf.Deserialize(fs); //only for test
                
                trumpCard = (Card)bf.Deserialize(fs);
                playerCards=(List<Card>)bf.Deserialize(fs);
                computerCards = (List<Card>)bf.Deserialize(fs);
                restCards = (List<Card>)bf.Deserialize(fs);
                discardPileCards = (List<Card>)bf.Deserialize(fs);
                riverCards = (List<Card>)bf.Deserialize(fs); 
                btnTakeIsPressed =  (bool)bf.Deserialize(fs);
                maxThrownCards = (int)bf.Deserialize(fs);
                btnTake.Text = (string)bf.Deserialize(fs);
                btnTake.Enabled = (bool)bf.Deserialize(fs);
                btnDone.Enabled = (bool)bf.Deserialize(fs);
                
                computerisAttcked = (bool)bf.Deserialize(fs);
                playerisAttcked = (bool)bf.Deserialize(fs);
                
                computer.SetIsAttacked(computerisAttcked);
                player.SetIsAttacked(playerisAttcked);
                player = new Player("Player", playerCards, player.GetIsAttacked());
                computer = new Computer("Ai", computerCards, computer.GetIsAttacked());  

                computer.SetFalseDefend((bool)bf.Deserialize(fs));
                player.SetFalseDefend((bool)bf.Deserialize(fs));
                computer.SetFalseAttack((bool)bf.Deserialize(fs));
                player.SetFalseAttack((bool)bf.Deserialize(fs));
                
                fs.Close();

                ClearPanels();
                
                if(computer.GetIsAttacked() && riverCards.Count == 0)
                {
                    computer.Attack(riverCards, trumpCard);
                    btnTake.Enabled = true;
                    maxThrownCards++;
                }

                ShowAllCards();
                MessageBox.Show(@"THE LAST SAVED GAME SUCCESSFULLY LOADED!");
            }
          

            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
            }

        }
        
       
        //The function Saves game points to a binary file checks if the player has logged in previously and shows the statistics of all games
        private void ScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ScoreAndStatistics scoreAndStatistics = new ScoreAndStatistics();
            if (scoreAndStatistics.ShowDialog(this) == DialogResult.OK)
                scoreAndStatistics.Show();

        }

         //show setting :chang background of card or table 
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Settings settings = new Settings();
            if (settings.ShowDialog(this) == DialogResult.OK)
            {
                settings.Show();
            }  
            BackgroundImage = logIn.tableImage;
            ShowAiCards(computerCards);
            ShowDeckAboveTrumpCard(restCards);
            if(discardPileCards.Count > 0)
            {
                ShowDiscardPileCard();
            }
        }
        //show guide help
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpGuide help = new HelpGuide();
            if (help.ShowDialog(this) == DialogResult.OK)
            {
               help.Show();
            }
        }

        /// <summary>
        ///  Form Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "DURAK APP", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                e.Cancel = true;
            else
            {
                SaveStatistics();
                e.Cancel = false;
               //Application.Exit();
            }
                
        }

        // Save Score
        private void SaveStatistics()
        {
            var filename = logIn.NickName + "Score.txt";
            try
            {
                using (var stream = File.Open(filename, FileMode.Create))
                {
                    using (var bw = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        bw.Write(logIn.drawPoints);
                        bw.Write(logIn.playerPoints);
                        bw.Write(logIn.computerPoints);

                    }
                }
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message + @"\n Cannot create file.");
            }
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}




