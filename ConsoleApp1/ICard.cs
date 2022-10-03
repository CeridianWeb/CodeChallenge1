namespace Challenge1
{
    public interface ICard
    {
        Rank Rank { get; set; }
        bool ShortName { get; set; }
        Suit Suit { get; set; }

        string ToString();
    }
}