using Challenge1;
using System;
using Xunit;

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
            var card1 = pack.Deal();
            var cardsRemaining = pack.CardsRemaining;
            //Assert
            Assert.Equal(51, cardsRemaining);
        }

        [Fact]
        public void CardsRemaining_AfterTwoDeals_Has50()
        {
            //Arange
            var pack = new PackOfCards();
            //Act
            var card1 = pack.Deal();
            var card2 = pack.Deal();
            var cardsRemaining = pack.CardsRemaining;
            //Assert
            Assert.Equal(50, cardsRemaining);
        }
    }
}
