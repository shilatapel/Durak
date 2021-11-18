using System.Collections.Generic;
using System.Linq;

namespace Durak
{
    class DealCards : DeckOfCards
    {
        private List<Card> playerHand;
        private List<Card> computerHand;
        private List<Card> sortedPlayerHand;
        private List<Card> sortedComputerHand;

        public DealCards()
        {
            playerHand = new List<Card>(6);
            sortedPlayerHand = new List<Card>(6);
            computerHand = new List<Card>(6);
            sortedComputerHand = new List<Card>(6);
        }

        public List<Card> PlayerHand { get => playerHand; set => playerHand = value; }
        public List<Card> ComputerHand { get => computerHand; set => computerHand = value; }
        public List<Card> SortedPlayerHand { get => sortedPlayerHand; set => sortedPlayerHand = value; }
        public List<Card> SortedComputerHand { get => sortedComputerHand; set => sortedComputerHand = value; }

        public void Deal()
        {
            setUpDeck();  //create the deck of cards and shuffle them
            getHand();  // deal hands to player and comuter
            sortHand(); // sort hands by value
            //displayCards();
        }

        public void getHand()
        {
            //6 cards for player
            for(int i = 0; i < 6; i++)
            {
                playerHand.Add(GetDeck.First());
                GetDeck.RemoveAt(0);
            }

            //6 cards for computer
            for(int i = 0; i < 6; i++)
            {
                computerHand.Add(GetDeck.First());     //  index of computer hand start from 0
                GetDeck.RemoveAt(0);
            }

        }

        public void sortHand()
        {
            //var queryPlayer = from hand in playerHand
            //                  orderby hand.Cvalue
            //                  select hand;

            var queryPlayer = playerHand.GroupBy(x => x.Csuit).Select(x => new
            {
                card = x.OrderBy(c => c.Cvalue),
                suit = x.Key
            }).OrderBy(x => x.suit).SelectMany(x => x.card);

            //var queryComputer = from hand in computerHand
            //                    orderby hand.Cvalue
            //                    select hand;

            var queryComputer = computerHand.GroupBy(x => x.Csuit).Select(x => new
            {
                card = x.OrderBy(c => c.Cvalue),
                suit = x.Key
            }).OrderBy(x => x.suit).SelectMany(x => x.card);
            foreach(var e in queryPlayer.ToList())
            {
                sortedPlayerHand.Add(e);
            }
            foreach(var e in queryComputer.ToList())
            {
                sortedComputerHand.Add(e);
            }
        }

        public void SetRiver()
        {
        }

        // public void displayCards() {
    }
}