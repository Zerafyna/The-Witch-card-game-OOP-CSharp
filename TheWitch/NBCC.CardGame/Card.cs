using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.CardGame
{
    public class Card
    {
        public Card(Suit newSuit, FaceValue newValue)
        {
            Suit = newSuit;
            FaceValue = newValue;
        }

        public FaceValue FaceValue { get; }
        public Suit Suit { get; }

    }
}
