namespace PokerKata
{
    public enum CardFace
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2
    }

    public enum CardColor
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum HandValue
    {
        HighCard = 1,
        Pair = 2,
        TwoPairs = 3,
        ThreeOfKind = 4,
        Straight = 5,
        Flush = 6,
        FullHouse = 7,
        FourOfKind = 8,
        StraightFlush = 9
    }
}