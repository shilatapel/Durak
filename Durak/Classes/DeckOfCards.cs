using System;
using System.Collections.Generic;
using System.Linq;

namespace Durak
{
    class DeckOfCards : Card
    {
        private const int NumOfCards = 36;  // number of all cards
        private List<Card> deck;
        private Card trump;

        public Card GetTrump { get => trump; }
        public List<Card> GetDeck { get => deck; }

        public DeckOfCards()
        {
            deck = new List<Card>(NumOfCards);
        }

        //create deck of 36 cards : 9 values each, with 4 suits

        public void setUpDeck()
        {
            //int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck.Add(new Card { Csuit = s, Cvalue = v });
                    //i++;
                }
            }
            ShuffleCards();
            trump = new Card
            {
                Csuit = deck.Last().Csuit,
                Cvalue = deck.Last().Cvalue
            };  //last card in the deck
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