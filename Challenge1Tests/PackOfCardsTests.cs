using Challenge1;
using Xunit;
using Humanizer;

namespace Challenge1Tests
{
    public class PackOfCardsTests
    {
        [Fact]
        public void CardsRemaining_TotalCardsOnConstruct_Has52()
        {
            //Arange
            var pack = new PackOfCards();
            //Act
            var cardsRemaining = pack.CardsRemaining;
            //Assert
            Assert.Equal(52, cardsRemaining);
        }

        [Fact]
        public void CardsRemaining_AfterOneDeal_Has51()
        {
            //Arange
            var pack = new PackOfCards();
            //Act
            pack.Deal();

            //Assert
            var cardsRemaining = pack.CardsRemaining;
            Assert.Equal(51, cardsRemaining);
        }

        [Fact]
        public void CardsRemaining_AfterTwoDeals_Has50()
        {
            //Arange
            var pack = new PackOfCards();
            //Act
            pack.Deal();
            pack.Deal();

            //Assert
            var cardsRemaining = pack.CardsRemaining;
            Assert.Equal(50, cardsRemaining);
        }

        [Theory]
        [InlineData(1, "A", "H")]
        [InlineData(2, "2", "H")]
        [InlineData(3, "3", "H")]
        [InlineData(4, "4", "H")]
        [InlineData(5, "5", "H")]
        [InlineData(15, "2", "C")]
        [InlineData(22, "9", "C")]
        [InlineData(25, "Q", "C")]
        [InlineData(29, "3", "D")]
        [InlineData(36, "10", "D")]
        [InlineData(41, "2", "S")]
        [InlineData(48, "9", "S")]
        [InlineData(51, "Q", "S")]
        public void CardsRemaining_AllCardsInOrder_CorrectOrder(int dealCards, string rankExpected, string suitExpected)
        {
            //Arange
            var pack = new PackOfCards();
            //Act
            var card = pack.Deal();
           
            for (int i = 0; i < dealCards - 1; i++)
            {
                card = pack.Deal();
                 card.ShortName = true;
            }
            if (card != null)
            {
                //Assert
                Assert.Equal(rankExpected, card.Rank.Humanize());
                Assert.Equal(suitExpected, card.Suit.Humanize());
            }
        }
    }
}