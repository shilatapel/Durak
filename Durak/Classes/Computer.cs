using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{
    public class Computer 
    {
        

        //create properties
        private string Name { get; }
        private List<Card> ComputerCards { get; }
        private bool IsAttacked { get; set; }
        public Computer(string name, List<Card> computerCards, bool isAttacked)
        {
            Name = name;
            ComputerCards = computerCards;
            IsAttacked = isAttacked;
        }

        //create method to add card to Computer's hand
        public void AddCard(Card card)
        {
            ComputerCards.Add(card);
        }
        //create method to add List<Card> to Computer's hand
        public void AddCards(List<Card> cards)
        {
            ComputerCards.AddRange(cards);
        }
        //create method to remove card from Computer's hand
        public void RemoveCard(Card card)
        {
            ComputerCards.Remove(card);
        }
        public void SetAttack(bool value)
        {
            IsAttacked = value;
        }
        public void Attack(CustomCardControl card, List<Card> riverCards)
        {
            //without checks for now
            riverCards.Add(card.Card);
            ComputerCards.Remove(card.Card);
        }

        public void Defend(CustomCardControl card, List<Card> riverCards, Card trump)
        {
            
            var attackedCard = card.Card;
            if (attackedCard.Csuit != trump.Csuit)
            {
                if (ComputerCards.Any(x => x.Csuit == attackedCard.Csuit && x.Cvalue > attackedCard.Cvalue))
                {
                    var cardToRemove = ComputerCards.First(x => x.Csuit == attackedCard.Csuit && x.Cvalue > attackedCard.Cvalue);
                    riverCards.Add(cardToRemove);
                    ComputerCards.Remove(cardToRemove);
                }
                else if (ComputerCards.Any(x => x.Csuit == trump.Csuit))
                {
                    var cardToRemove = ComputerCards.First(x => x.Csuit == trump.Csuit);
                    riverCards.Add(cardToRemove);
                    ComputerCards.Remove(cardToRemove);
                    
                }
                else
                {
                    ComputerCards.AddRange(riverCards);
                    riverCards.Clear();
                    //ComputerCards.Clear();
                }
            }

            else if (attackedCard.Csuit == trump.Csuit)
            {
                if(ComputerCards.Any(x => x.Csuit == trump.Csuit && x.Cvalue > attackedCard.Cvalue))
                {
                    var cardToRemove = ComputerCards.First(x => x.Csuit == trump.Csuit && x.Cvalue > attackedCard.Cvalue);
                    riverCards.Add(cardToRemove);
                    ComputerCards.Remove(cardToRemove);
                }
                else
                {
                    ComputerCards.AddRange(riverCards);
                    riverCards.Clear();
                }
            }
            else
            {
                riverCards.Add(card.Card);
                ComputerCards.Remove(card.Card);
            }
        }
    }
}