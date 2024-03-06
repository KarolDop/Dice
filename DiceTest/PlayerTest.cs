using Dice;
using NUnit.Framework;

namespace DiceTest.UnitTest
{
    [TestFixture]
    public class PlayerTest
    {
        private Player _player;

        [SetUp]
        public void SetUp()
        { 
            _player = new Player("Karol", 2, 6); 
        }

        [Test, Order(0)]
        public void Player_CheckIfObjectAreCreatedWithCorrectID_returnCorrectID()
        {
            //Arange
            var player2 = new Player("Adam");
            var player3 = new Player("Ola");

            //Act
            var idPlayer1 = _player.PlayerId;
            var idPlayer2 = player2.PlayerId;
            var idPlayer3 = player3.PlayerId;

            //Assert

            Assert.AreEqual(1, idPlayer1);
            Assert.AreEqual(2, idPlayer2);
            Assert.AreEqual(3, idPlayer3);
        }

        [Test, Order(1)]
        public void Player_CheckConstructorMethodWith3Atrubutes_CorrectNameAndDiceNo()
        {
            //Arrange

            //Act
            var name = _player.Name;
            var diceNo = _player.NoDice;
            var diceThrowNo = _player.PlayerDicesForThrow.Count;
            var wallNo = _player.PlayerDicesForThrow[0].HowManyWall;

            //Assert
            Assert.AreEqual(2, diceNo);
            Assert.AreEqual(2, diceThrowNo);
            Assert.AreEqual(6, wallNo);
            Assert.AreEqual("Karol", name);
        }

        [Test, Order(2)]
        public void Player_CheckAddDiceMethod_OneDiceAdded()
        {
            //Arrange
            _player.AddNewDiceForThrow(6);
            //Act
            var diceNo = _player.NoDice;
            var diceThrowNo = _player.PlayerDicesForThrow.Count;
            //Asserr
            Assert.AreEqual(3, diceNo);
            Assert.AreEqual(3, diceThrowNo);
        }

        [Test, Order(3)]
        public void Player_CheckMoveDiceToNotThrow_OneDiceLessInThrowAndOneMoreInNotThrow()
        {
            //Arrange
            var diceToThrowBefore = _player.PlayerDicesForThrow.Count;
            var diceToNotThrowBefore = _player.PlayerDicesToNotThrow.Count;
            _player.MoveFromThrowToNotThrow(0);
            //Act
            var diceToThrow = diceToThrowBefore - _player.PlayerDicesForThrow.Count;
            var diceThrowNo = diceToNotThrowBefore - _player.PlayerDicesToNotThrow.Count;
            //Arrange
            Assert.AreEqual(1, diceToThrow);
            Assert.AreEqual(-1, diceThrowNo);
        }

        [Test, Order(4)]
        public void Player_CheckMoveDiceToThrow_OneDiceLessInNotThrowAndOneMoreInThrow()
        {
            //Arrange
            _player.MoveFromThrowToNotThrow(0);
            var diceToThrowBefore = _player.PlayerDicesForThrow.Count;
            var diceToNotThrowBefore = _player.PlayerDicesToNotThrow.Count;
            _player.MoveFromNotThrowToThrow(0);
            //Act
            var diceToThrow = diceToThrowBefore - _player.PlayerDicesForThrow.Count;
            var diceThrowNo = diceToNotThrowBefore - _player.PlayerDicesToNotThrow.Count;
            //Arrange
            Assert.AreEqual(-1, diceToThrow);
            Assert.AreEqual(1, diceThrowNo);
        }

    }
}
