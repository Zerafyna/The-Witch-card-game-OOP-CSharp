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
    public class Deck
    {
        public Deck() { MakeDeck(); }

        private List<Card> deck = new List<Card>();

        #region Methods
        
        public Hand DealHand(int number)
        {
            if (deck.Count == 0)
            {
                throw new ConstraintException("There are no cards in the deck.");
            }

            Hand hand = new Hand();

            int countTo = deck.Count >= number ? number : deck.Count;

            for (int handIndex = 0; handIndex < countTo; handIndex++)
            {
                hand.AddCard(deck[0]);
                deck.RemoveAt(0);
            }

            return hand;
        }

        public List<Hand> DealTwoHands()
        {
            if(deck.Count == 0)
            {
                throw new ConstraintException("There are no cards in the deck.");
            }
            
            Hand hand1 = new Hand();
            Hand hand2 = new Hand();

            int count = deck.Count;
            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 0)  hand1.AddCard(deck[0]); 
                else  hand2.AddCard(deck[0]); 

                deck.RemoveAt(0);
            }
            
            List<Hand> hands = new List<Hand>
            {
                hand1,
                hand2
            };
            return hands;
        }
        
        public Card DrawOnecard()
        {
            Card topCard;

            if (deck.Count > 0)
            {
                topCard = deck[0];
                deck.RemoveAt(0);
            }
            else { throw new ArgumentException("No more cards in the deck"); }

            return topCard;
        }

        private void MakeDeck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int face = 0; face < 9; face++) // 36 card deck
                {
                    Card newCard = new Card((Suit)suit, (FaceValue)face);
                    deck.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            Random rGen = new Random();
            List<Card> newDeck = new List<Card>();

            while(deck.Count > 0)
            {
                int removeIndex = rGen.Next(0, deck.Count);
                Card removedCard = deck[removeIndex];

                deck.RemoveAt(removeIndex);
                newDeck.Add(removedCard);
            }
            deck = newDeck;
        }

        public void RemoveACard(FaceValue fv, Suit s)
        {
            Card c = deck.Where(d => d.FaceValue == fv && d.Suit == s).FirstOrDefault();
            deck.Remove(c);
        }

        #endregion
    }
}
