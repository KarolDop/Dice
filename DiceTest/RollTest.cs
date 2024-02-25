using NUnit.Framework;
using Dice;
using System.Collections.Generic;

namespace DiceTest
{
    [TestFixture]
    public class RollTest
    {
        [Test]
        public void DiceRoll_RetrunIntValueAfterRoll_InRange1To2()
        {
            //Arrange
            int number;

            //Act
            number = Roll.DiceRoll(2);

            //Assert
            Assert.That(number, Is.InRange(1,2));
        }

        [Test]
        public void Throw_ReturnIntValueAfterRollFewDiceInOneTime_InRange1To2()
        {
            //Arrange
            List<NewDice> forThrow = new List<NewDice>();
            for(int i = 0; i < 6; i++)
            {
                var dice = new NewDice(2);
                forThrow.Add(dice);
            }

            //Act
            Roll.Throw(forThrow);

            //Assert
            foreach(NewDice dice in forThrow)
            {
                Assert.That(dice.Count, Is.InRange(1,2));
            }
        }
    }
}