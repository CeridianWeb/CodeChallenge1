namespace Challenge1
{
    public interface IPileOfCards
    {
        Card CardAtPosition(int fromTop);
        Card TopCard();
    }
}