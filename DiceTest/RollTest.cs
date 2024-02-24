using NUnit.Framework;
using Dice;


namespace DiceTest
{
    [TestFixture]
    public class RollTest
    {
        [Test]
        public void DiceRoll_CheckIfRollAreInRangeFrom0to1()
        {
            //Arrange
            int number;

            //Act
            number = Roll.DiceRoll(1);

            //Assert
            Assert.That(number, Is.InRange(0,1));
        }

        [Test]
        public void DiceRoll_CheckIfRollAreInRangeFrom0to10()
        {
            //Arrange
            int number;

            //Act
            number = Roll.DiceRoll(10);

            //Assert
            Assert.That(number, Is.InRange(0, 10));
        }
    }
}