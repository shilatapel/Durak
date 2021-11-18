using System;

namespace Durak
{
    internal class DeckOfCards : Card
    {
        private const int NumOfCards = 36;  // number of all cards
        private Card[] deck;  //array of all playing cards
        public SUIT trump;      //last card in the deck that is trump suit

        public DeckOfCards()
        {
            deck = new Card[NumOfCards];
        }

        public Card[] GetDeck
        { get { return deck; } }  //get current Deck

        //create deck of 36 cards : 9 values each, with 4 suits

        public void setUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { Csuit = s, Cvalue = v };
                    i++;
                }
            }
            ShuffleCards();
            trump = deck[NumOfCards - 1].Csuit;  //last card in the deck
        }

        // Shuffle the Deck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //run the Shuffle 1000 times

            for(int ShuffleTimes = 0; ShuffleTimes < 1000; ShuffleTimes++)
            {
                for(int i = 0; i < NumOfCards; i++)
                {
                    //swap the cards

                    int secondCardIndex = rand.Next(9);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}