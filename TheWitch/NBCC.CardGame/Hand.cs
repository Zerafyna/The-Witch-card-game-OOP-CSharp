using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Author: Erica Moisei
* Date: June 3/2019
* Card Game: The Witch
* Notes: OOP Project
*/

namespace NBCC.CardGame
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public int Count { get { return cards.Count(); } }

        #region Methods

        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }
        
        internal List<Card> ReturnCards()
        {
            return cards;
        }

        internal Card GetCard(FaceValue theFaceValue, Suit theSuit)
        {
            return cards.Where(c => c.FaceValue == theFaceValue && c.Suit == theSuit).FirstOrDefault();
        }

        internal List<Card> FindCards(FaceValue theFaceValue)
        {
            return cards.Where(c => c.FaceValue == theFaceValue).ToList();
        }

        public void AddCard(Card newCard)
        {
            if (ContainsCard(newCard))
            {
                throw new ConstraintException(newCard.FaceValue.ToString() + " of " + newCard.Suit.ToString() + 
                    " already exists in the Hands");
            }
            cards.Add(newCard);
        }

        private bool ContainsCard(Card cardToCheck)
        {
            return cards.Where(c => c.FaceValue == cardToCheck.FaceValue &&
                                c.Suit == cardToCheck.Suit).Count() > 0;
        }

        public bool ContainsCard(FaceValue theFaceValue)
        {
            return cards.Where(c => c.FaceValue == theFaceValue).Count() > 0;
        }

        public void RemoveCard(Card theCard)
        {
            if (cards.Contains(theCard))
            {
                cards.Remove(theCard);
            }
            else throw new ConstraintException("The car does not exists in the hand.");
        }

        public void RemoveCard(int index)
        {
            if (index < cards.Count)
            {
                cards.RemoveAt(index);
            }
            else throw new ConstraintException("The car does not exists in the hand.");
        }

        public void RemoveCard(FaceValue theFaceValue)
        {
            foreach (Card card in cards)
            {
                if (card.FaceValue == theFaceValue)
                {
                    cards.Remove(card);
                    return;
                }
            }
            throw new ConstraintException($"{theFaceValue.ToString()} is not in the hand");
        }

        public void RemoveCard(Suit theSuit, FaceValue theFaceValue)
        {
            foreach (Card card in cards)
            {
                if(card.Suit == theSuit && card.FaceValue == theFaceValue)
                {
                    cards.Remove(card);
                    return;
                }
            }
            throw new ConstraintException($"{theFaceValue.ToString()} of {theSuit.ToString()} is not in the hand");
        }

        public void ShuffleHand()
        {
            Random rGen = new Random();
            List<Card> newHand = new List<Card>();

            while (cards.Count > 0)
            {
                int removeIndex = rGen.Next(0, cards.Count);
                Card removedCard = cards[removeIndex];
                cards.RemoveAt(removeIndex);
                newHand.Add(removedCard);
            }
            cards = newHand;
        }

        #endregion
    }
}
