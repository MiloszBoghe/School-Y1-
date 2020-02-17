namespace PlayingCards
{
    public enum SuitType { Clubs, Spades, Diamonds, Hearts }
    public enum RankType
    {
        Ace = 1,
        two, three, four, five, six, seven, eight, nine, ten,
        Jack, Queen, King
    }

    public class Card
    {
        public int Value { get; set; }
        public SuitType Suit { get; set; }
    }
}
