using System.ComponentModel;

namespace Challenge1
{
    public enum Suit
    {
        [Description("H")]
        Hearts = 1,

        [Description("C")]
        Clubs = 2,

        [Description("D")]
        Diamonds = 3,

        [Description("S")]
        Spades = 4
    }
}