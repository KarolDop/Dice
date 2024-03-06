using Dice;
using NUnit.Framework;

namespace DiceTest
{
    [TestFixture]
    class NewDiceTest
    {
        private NewDice _dice;
        
        [SetUp]
        public void SetUp()
        {
            _dice = new NewDice(6);
        }

        [Test, Order(0)]
        public void NewDice_CheckIfObjectAreCreatedWithCorrectID_returnCorrectID()
        {
            //Arrange
            var dice2 = new NewDice(2);
            var dice3 = new NewDice(3);
            var dice4 = new NewDice(4);

            //Act
            int idDice1 = _dice.Id;
            int idDice2 = dice2.Id;
            int idDice3 = dice3.Id;
            int idDice4 = dice4.Id;

            //Assert
            Assert.AreEqual(1, idDice1);
            Assert.AreEqual(2, idDice2);
            Assert.AreEqual(3, idDice3);
            Assert.AreEqual(4, idDice4);
        }

        [Test]
        public void NewDice_CheckIfConstructorCreateCorrectObject_ReturnWallNo()
        {
            //Act
            int noOfWall = _dice.HowManyWall;

            //Assert
            Assert.AreEqual(6, noOfWall);
        }
    }
}