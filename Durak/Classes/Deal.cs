﻿using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{
    //CLASS FOR DEAL
    internal class Deal : Deck
    {
        //creat list of cards hands
       
        private List<Card> _computerHand;
        private List<Card> _playerHand;
        public List<Card> Deck;
        
        
        public List<Card> SortedPlayerHand { get; }

        public List<Card> SortedComputerHand { get; }


        //constructor lists hands 
        public Deal()
        {
            _playerHand = new List<Card>(6);
            _computerHand = new List<Card>(6);
            SortedPlayerHand = new List<Card>(6);
            SortedComputerHand = new List<Card>(6);
        }



        //func for  Deal Cards
        public void DealCards()
        {
            SetUpDeck(); //create the deck of cards and shuffle them
            GetHand(); // deal hands to player and computer
            SortHand(); // sort hands by value
        }



        //  Get Hand 
        private void GetHand()
        {
            //6 cards for player and for ai
            for (var i = 0; i < 6; i++)
            {
                _playerHand.Add(GetDeck.First());
                GetDeck.RemoveAt(0);
                _computerHand.Add(GetDeck.First());
                GetDeck.RemoveAt(0);
            }
            Deck = new List<Card>();
            foreach (var card in GetDeck) Deck.Add(card);
        }

        //Sort Hand order by suit and value
        public void SortHand()
        {
            var queryPlayer = _playerHand.GroupBy(x => x.Csuit).Select(x => new
            {
                card = x.OrderBy(c => c.Cvalue),
                suit = x.Key
            }).OrderBy(x => x.suit).SelectMany(x => x.card);

            var queryComputer = _computerHand.GroupBy(x => x.Csuit).Select(x => new
            {
                card = x.OrderBy(c => c.Cvalue),
                suit = x.Key
            }).OrderBy(x => x.suit).SelectMany(x => x.card);
            foreach (var e in queryPlayer.ToList()) SortedPlayerHand.Add(e);
            foreach (var e in queryComputer.ToList()) SortedComputerHand.Add(e);
        }
    }
}