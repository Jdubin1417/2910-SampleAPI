using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherSampleAPI
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public Card()
        {
            Suit = Suit.Spades;
            Face = Face.Ace;
        }

        public Card(Card existingCard)
        {
            this.Suit = existingCard.Suit;
            this.Face = existingCard.Face;

        }

        public Card(int n)
        {
            Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);

        }

        public override string ToString()
        {
            return $"the {Face} of {Suit}";
        }
    }
}