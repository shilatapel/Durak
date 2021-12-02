using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{
    //create class Player
    public class Player
    {
        //create properties
        private string Name { get; }
        private List<Card> PlayerCards { get; }
        private bool IsAttacked { get; set; }
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
        public void RemoveCard(Card card)
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
        public void Attack(CustomCardControl card, List<Card> riverCards)
        {
            var attackedCard = card.Card;
            var listOfValues = riverCards.Select(x => x.Cvalue).ToList();
            if (riverCards.Count == 0)
            {
                riverCards.Add(attackedCard);
                RemoveCard(attackedCard);
            }
            else if (riverCards.Count is > 0 and < 12)
            {
                if (listOfValues.Contains(attackedCard.Cvalue))
                {
                    riverCards.Add(attackedCard);
                    RemoveCard(attackedCard);
                }
                
            }
            
        }

        public void Defend(CustomCardControl card, List<Card> riverCards, Card trumpCard)
        {
            var attackedCard = riverCards.Last();
            var defendCard = card.Card;
            // if attacked card is not trump and defend card is higher than attacked card or defend card is trump
            if (attackedCard.Csuit != trumpCard.Csuit && 
                defendCard.Cvalue > attackedCard.Cvalue && 
                defendCard.Csuit == attackedCard.Csuit || 
                defendCard.Csuit == trumpCard.Csuit)  
            {
                    riverCards.Add(defendCard);
                    RemoveCard(defendCard);
            }
            // if attacked card is trump and defend card is higher than attacked card
            else if (attackedCard.Csuit == trumpCard.Csuit && attackedCard.Cvalue > defendCard.Cvalue) //
            {
                riverCards.Add(defendCard);
                RemoveCard(defendCard);
            }
        }
    }
}