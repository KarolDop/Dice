namespace Dice
{
    public class Player
    {
        private static int _howManyPlayer = 0;
        private int _playerId;
        private string _name;
        private List<NewDice>? _playerDicesForThrow;
        private List<NewDice>? _playerDicesToNotThrow;

        public int PlayerId
        {
            get { return _playerId; }
        }

        public string Name
        {
            get { return _name; }
        }

        public List<NewDice> PlayerDices
        {
            get { return _playerDicesForThrow; }
        }

        public Player(string name)
        {
            _name = name;
            _playerId = ++_howManyPlayer;
        }

        public Player(string name, int howManyDice, int wall)
        {
            _name = name;
            for(int i = 1; i <= howManyDice; i++)
            {
                _playerDicesForThrow.Add(new NewDice(wall));
            }
            _playerId = ++_howManyPlayer;
        }

        public void AddNewDiceForThrow(int wall)
        {
            _playerDicesForThrow.Add(new NewDice(wall));
        }

        public void MoveFromThrowToNotThrow(int indexRemove)
        {
            NewDice diceToMove = _playerDicesForThrow[indexRemove];
            _playerDicesForThrow.RemoveAt(indexRemove);
            _playerDicesToNotThrow.Add(diceToMove);
        }

        public void MoveFromNotThrowToThrow(int indexRemove)
        {
            NewDice diceToMove = _playerDicesToNotThrow[indexRemove];
            _playerDicesToNotThrow.RemoveAt(indexRemove);
            _playerDicesForThrow.Add(diceToMove);
        }
    }
}