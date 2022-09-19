namespace Challenge1
{
    public interface IPackOfCards
    {
        int CardsRemaining { get; }

        ICard Deal();
    }
}