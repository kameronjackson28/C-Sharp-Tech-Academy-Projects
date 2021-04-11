using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace TwentyOne
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Suit, Face);
        }
    }
    public enum Suit
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two, 
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight, 
        Nine,
        Ten, 
        Jack,
        Queen,
        King,
        Ace
    }
}
