using System;
using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{
    internal class Deck : Card
    {
        private const int NumOfCards = 36; // number of all cards
        public Card GetTrump { get; private set; }
        protected List<Card> GetDeck { get; }
        public Deck()
        {
            GetDeck = new List<Card>(NumOfCards);
        }

        protected void SetUpDeck()
        {
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                GetDeck.Add(new Card
                {
                    Csuit = s,
                    Cvalue = v
                });

            ShuffleCards();
            GetTrump = new Card
            {
                Csuit = GetDeck.Last().Csuit,
                Cvalue = GetDeck.Last().Cvalue,
                InHand = false
            };
        }

        // Shuffle the Deck
        private void ShuffleCards()
        {
            var rand = new Random();

            //run the Shuffle 1000 times

            for (var shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            for (var i = 0; i < NumOfCards; i++)
            {
                //swap the cards

                var secondCardIndex = rand.Next(9);
                (GetDeck[i], GetDeck[secondCardIndex]) = (GetDeck[secondCardIndex], GetDeck[i]);
            }
        }
    }
}