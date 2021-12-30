using System;
using System.Collections.Generic;
using System.Linq;

namespace Durak.Classes
{

    //class  Computer  
    public class Computer 
    {
        

        //create properties
        private string Name { get; }
        private List<Card> ComputerCards { get; }
        private bool IsAttacked { get; set; }
        
        private bool IsWinner { get; set; }
        private bool FalseDefend { get; set; }
        
          //public int CountOfAttackedCards { get; private set; }
        
        
          //gettesr and setters
        public bool GetIsWinner()
        {
            return IsWinner;
        }
        public void SetIsWinner(bool value)
        {
            IsWinner = value;
        }
      
       
        public bool GetIsAttacked()
        {
            return IsAttacked;
        }
       public void SetIsAttacked(bool value)
        {
            IsAttacked = value;
        }
        private bool FalseAttack { get; set; }
        public bool GetFalseAttack()
        {
            return FalseAttack;
        }
        public void SetFalseAttack(bool value)
        {
            FalseAttack = value;
        }
     
        public bool GetFalseDefend()
        {
            return FalseDefend;
        }
        public void SetFalseDefend(bool value)
        {
            FalseDefend = value;
        }


        //constructor  initializ
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
        private void RemoveCard(Card card)
        {
            ComputerCards.Remove(card);
        }



        //computer  Attack 
        public void Attack(List<Card> riverCards, Card trump)
        {
            
            if (riverCards.Count == 0)
            {
                if (ComputerCards.Any(x => x.Csuit != trump.Csuit))
                {
                    // TODO: change logic of throwing first card
                    var cardToAttack = ComputerCards.First(x => x.Csuit != trump.Csuit);
                    riverCards.Add(cardToAttack);
                    RemoveCard(cardToAttack);
                    FalseAttack = false;
                }
                else
                {
                    var cardToAttack = ComputerCards.First();
                    riverCards.Add(cardToAttack);
                    RemoveCard(cardToAttack);
                    FalseAttack = false;
                }
            }
            else
            {
                // TODO: change logic of throwing cards when river is not empty
                if (riverCards.Count is > 0 and <= 12) // if we have already thrown cards
                {
                    var intersectList = riverCards.Select(x => x.Cvalue)
                        .Intersect(ComputerCards.Where(x => x.Csuit != trump.Csuit)
                                                .Select(x => x.Cvalue)).ToList(); 
                    // making list of computer's cards that there are not trump and also with the same values like on the table
                    if (intersectList.Count > 0) // if list not empty, it means that we have cards to attack
                    {
                        var cardToAttack = ComputerCards.First(x => x.Cvalue == intersectList.First() && x.Csuit != trump.Csuit); // get first card from list to attack
                        riverCards.Add(cardToAttack); // add card to river
                        RemoveCard(cardToAttack); // remove card from computer's hand
                        FalseAttack = false; // set FalseAttack to false
                    }
                    else
                        FalseAttack = true;
                }
            }
        }

        //computer    Defend
        public void Defend(CustomCardControl card, List<Card> riverCards, Card trump)
        {
            // TODO : to sort cards candidates to throw before step. (to throw the lowest candidate)
            
            var attackedCard = card.Card;
            if (attackedCard.Csuit != trump.Csuit) // if card is not trump
            {
                if (FalseDefend != true)
                {
                    if (ComputerCards.Any(x => x.Csuit == attackedCard.Csuit && x.Cvalue > attackedCard.Cvalue)) // first case iF PC has card with same suit and higher value
                    {
                        var cardToRemove = ComputerCards.First(x => x.Csuit == attackedCard.Csuit && x.Cvalue > attackedCard.Cvalue); // get the first card of the same suit with higher value 
                        riverCards.Add(cardToRemove); // add it to river
                        RemoveCard(cardToRemove); // remove it from computer's hand
                    }
                    else if (ComputerCards.Any(x => x.Csuit == trump.Csuit)) // second case (first case is false) if pc has trump
                    {
                        var cardToRemove = ComputerCards.First(x => x.Csuit == trump.Csuit);
                        riverCards.Add(cardToRemove);
                        RemoveCard(cardToRemove);
                        
                    }
                    else
                    {
                        FalseDefend = true;
                    }
                }
            }

            else if (attackedCard.Csuit == trump.Csuit) // if card is trump
            {
                if(ComputerCards.Any(x => x.Csuit == trump.Csuit && x.Cvalue > attackedCard.Cvalue)) // if pc has trump with higher value
                {
                    var cardToRemove = ComputerCards.First(x => x.Csuit == trump.Csuit && x.Cvalue > attackedCard.Cvalue);
                    riverCards.Add(cardToRemove);
                    RemoveCard(cardToRemove);
                }
                else
                {
                    FalseDefend = true;
                }
            }
        }
    }
}