﻿using System;
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
    public partial class HelpGuide : Form
    {
        public HelpGuide()
        {     //The function shows a user guide
            InitializeComponent();
          
            lbltext.Text = "Welcome to the game Durak Here is an explanation of how to play\n\n" +
                                        "1. Deck of 36 cards – 6, 7, 8, 9, 10, J, Q, K, A (Deck is shuffled)\n" +
                                        "2. Players are dealt six cards in their hand.\n" +
                                        "3. The bottom card of the deck is removed from the deck and flipped face up.\n" +
                                        "     a. This card is removed from play and is shown to all players.\n" +
                                        "     b. The suit of this card is the trump suit for this match (The value does not matter much)\n" +
                                        "4. The player with the lowest trump card in their hand is the first attacker.\n" +
                                        "5. The attacker begins the round by playing a card from their hand to begin the attack.\n " +
                                        "6. The defender can defend against the card by playing a card from their hand that is: " +
                                        "\n   a. either of the same suit but of a higher value " +
                                        "\n   b. card from the trump suit to continue the round. " +
                                        "(If the attacker attacks with a card of the trump suit, the defender must defend with a card of the trump suit but of a higher value) " +
                                        "7. If the defender defends the attack, the attacker may choose to chain another attack by playing a card that is" +
                                        " if one of the values on the field. (EG: if the attacker plays a 7 of hearts to attack, and defender defends with a " +
                                        "9 of hearts. The attacker can attack again this round using either a 7 or an 9) This can go up to 6 attacks in a round. " +
                                        "(The game does not end even if the attack uses up their entire hand unless the deck has been exhausted)\n" +
                                        "8. If the defender cannot defend against the attack, or if they choose to pass on defending, they must pickup all the " +
                                        "cards involved in the attack.(the attacker may to add cards with the values in the river)\n" +
                                        "9. Both players draw from the deck back up to a minimum of 6 cards if necessary. \n" +
                                        "10. If the defender successfully defends against the attack (attack cannot chain anymore attacks or 6 attacks have been made) then all " +
                                        "the cards involved in the attack is discarded and the next round begins.\n" +
                                        "11. If the attacker is successful in attacking, they continue as attacker in the next round. If they are not, the defender " +
                                        "becomes the new attacker.\n" +
                                        "12. Rounds continue until the deck runs out of cards.\n" +
                                        "13. When the deck runs out of cards, the rounds continue but players no longer draw cards.\n " +
                                        "14. Players leave the game when they run out of cards and the deck is exhausted. (can be attacker or defender) The last person with " +
                                        "cards remaining loses the game.(There is a situation of this draw when both players are left with one card and the attacker responds to the attack)\n\n" +
                                        "In the game panel there is an options to save the game and open it from the point where you stop or play a new game.\n" +
                                        "You can also change the settings of the background of the cards and the background of the game board\n"+
                                        "You can view game Statistics and Score \n\n"; //" and  log file to watch the moves that have been made and plan a better strategy for next time  ";


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
