using System;

namespace Durak.Classes
{
       //card class 
    [Serializable] public class Card
    {
        public enum SUIT
        {
            HEARTS,
            DIAMONDS,
            SPADES,
            CLUBS
        }

        public enum VALUE
        {
            SIX = 6,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        }

        public SUIT Csuit { get; set; }
        public VALUE Cvalue { get; set; }
        public bool InHand { get; set; }

        //get name of cards
        public string GetName()
        {
            return Csuit.ToString().Substring(0, 1).ToLower() + ((int) Cvalue);
        }

        //card to string
        public override string ToString()
        {
            return Cvalue + " of " + Csuit;
        }
    }
}