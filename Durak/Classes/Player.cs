using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{
    //create class Player
    public class Player
    {
        //create properties
        private string Name { get; }
        private List<Card> PlayerCards { get; set; }
        
        private bool IsWinner { get; set; }
        private bool IsAttacked { get; set; }
        
        private bool FalseDefend { get; set; }
        private bool FalseAttack { get; set; }



        //getters and setters
        public bool GetIsWinner()
        {
            return IsWinner;
        }
        public void SetIsWinner(bool value)
        {
            IsWinner = value;
        }
        public bool GetFalseDefend()
        {
            return FalseDefend;
        }
        public void SetFalseDefend(bool value)
        {
            FalseDefend = value;
        }

        public bool GetFalseAttack()
        {
            return FalseAttack;
        }
        public void SetFalseAttack(bool value)
        {
            FalseAttack = value;
        }

        
        
        //constructor with ready hand
        public Player(string name, List<Card> playerCards, bool isAttacked)
        {
            Name = name;
            PlayerCards = playerCards;
            IsAttacked = isAttacked;
        }
        
        //create method to add card to player's hand
        public void AddCard(Card card)
        {
            PlayerCards.Add(card);
        }
        //create method to add List<Card> to player's hand
        public void AddCards(List<Card> cards)
        {
            PlayerCards.AddRange(cards);
        }
        //create method to remove card from player's hand
        private void RemoveCard(Card card)
        {
            PlayerCards.Remove(card);
        }
        public void SetIsAttacked(bool value)
        {
            IsAttacked = value;
        }
        // GetAttack getter
        public bool GetIsAttacked()
        {
            return IsAttacked;
        }

        // player Attack 
        public void Attack(CustomCardControl card, List<Card> riverCards)
        {
            var attackedCard = card.Card;
            var listOfValues = riverCards.Select(x => x.Cvalue).ToList(); // get list of values from river cards
            if (riverCards.Count == 0) // if river is empty, not need any checks
            {
                riverCards.Add(attackedCard); // add attacked card to river
                RemoveCard(attackedCard); // remove attacked card from player's hand
                FalseAttack = false; // set falsed attack to false
            }
            else if (riverCards.Count is > 0 and <= 12) // if have cards already
            {
                if (listOfValues.Contains(attackedCard.Cvalue)) // if attacked card is in river
                {
                    riverCards.Add(attackedCard); // add attacked card to river
                    RemoveCard(attackedCard); // remove attacked card from player's hand
                    FalseAttack = false; // set falsed attack to false
                }
                else
                    FalseAttack = true;
            }
            
        }




        // player Defend 
        public void Defend(CustomCardControl card, List<Card> riverCards, Card trumpCard)
        {
            var attackedCard = riverCards.Last();
            var defendCard = card.Card;
            // if attacked card is not trump and defend card is higher than attacked card or defend card is trump
            if (attackedCard.Csuit != trumpCard.Csuit && 
                defendCard.Csuit == attackedCard.Csuit && 
                defendCard.Cvalue > attackedCard.Cvalue || 
                attackedCard.Csuit != trumpCard.Csuit && 
                defendCard.Csuit == trumpCard.Csuit)
            {
                    riverCards.Add(defendCard);
                    RemoveCard(defendCard);
                    FalseDefend = false;
            }
            // if attacked card is trump and defend card is higher than attacked card
            else if (attackedCard.Csuit == trumpCard.Csuit &&
                     attackedCard.Cvalue < defendCard.Cvalue &&
                     defendCard.Csuit == trumpCard.Csuit) //
            {
                riverCards.Add(defendCard);
                RemoveCard(defendCard);
                FalseDefend = false;
            }
            
            else
                FalseDefend = true;
        }

        
    }
}