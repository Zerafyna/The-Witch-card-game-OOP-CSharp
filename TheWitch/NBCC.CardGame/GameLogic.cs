using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Author: Erica Moisei
* Date: June 5/2019
* Card Game: The Witch
* Notes: OOP Project
*/

namespace NBCC.CardGame
{
    public class GameLogic
    {
        #region Private Properties

        private bool computerTurn = false;

        #endregion

        #region Public Properties
        /// <summary>
        /// Keep tracking the turns
        /// </summary>
        public bool ComputerTurn
        {
            get
            {
                return computerTurn;
            }
            set
            {
                computerTurn = value;

                if (value)
                {
                    IsComputerTurn.Invoke(this, EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Events

        public EventHandler IsComputerTurn;

        #endregion


        #region Methods

        /// <summary>
        /// Checking if the card is the witch
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool IsWitch(Card card)
        {
            if (card.FaceValue == FaceValue.Queen && card.Suit == Suit.Spades) return true;
            return false;
        }

        /// <summary>
        /// Removes one queen from the deck
        /// </summary>
        /// <param name="deck"></param>
        public void RemoveQueen(Deck deck)
        {
            deck.RemoveACard(FaceValue.Queen, Suit.Clubs);
        }

        /// <summary>
        /// Find a pair for the payed card by Face Value
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public Card PairChosenCard(Hand hand, Card card)
        {
            List<Card> cards = hand.FindCards(card.FaceValue);
            Card pair; 
            
            if (card.FaceValue != FaceValue.Queen) // Making sure to not pair with the Witch card another Queen
                pair = cards.Where(c => c.FaceValue == card.FaceValue).FirstOrDefault();
            else
                pair = cards.Where(c => c.FaceValue == card.FaceValue && c.Suit != Suit.Spades).FirstOrDefault();
            
            hand.RemoveCard(pair);
            return pair;
        }

        /// <summary>
        /// Taking all the pair cards by Face Valueout off hand except when it is a witch
        /// </summary>
        /// <param name="hand"></param>
        public void FilterPairs(Hand hand)
        {
            List<Card> cards = hand.ReturnCards(); // Getting the cards
            List<Card> pairs = new List<Card>();

            Card witch = hand.GetCard(FaceValue.Queen, Suit.Spades); // Getting the Witch

            foreach (Card card in cards)
            {
                List<Card> cardsFound = cards.Where(c => c.FaceValue == card.FaceValue).ToList();

                if (cardsFound.Count > 1)
                {
                    if (!cardsFound.Contains(witch))
                    {
                        pairs.Add(cardsFound[0]);
                        pairs.Add(cardsFound[1]);

                        if (cardsFound.Count == 4)
                        {
                            pairs.Add(cardsFound[2]);
                            pairs.Add(cardsFound[3]);
                        }
                    }
                    else if (cardsFound.Contains(witch) && cardsFound.Count == 3)
                    {
                        pairs.Add(cardsFound[0]);
                        pairs.Add(cardsFound[1]);
                        pairs.Add(cardsFound[2]);
                    }
                }
            }

            foreach (Card c in pairs)
            {
                if (cards.Contains(c) && c != witch)
                {
                    cards.Remove(c);
                }
            }

        }
        
    }

    #endregion
}
