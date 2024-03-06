namespace Dice
{
    public class Player
    {
        private static int _howManyPlayer = 0;
        private int _playerId;
        private string _name;
        private int _noDice;
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

        public int NoDice
        {
            get { return _noDice; }
        }

        public List<NewDice> PlayerDicesForThrow
        {
            get { return _playerDicesForThrow; }
        }

        public List<NewDice?> PlayerDicesToNotThrow
        {
            get { return _playerDicesToNotThrow; }
        }

        public Player(string name)
        {
            _playerDicesForThrow = new List<NewDice>();
            _playerDicesToNotThrow = new List<NewDice>();
            _name = name;
            _playerId = ++_howManyPlayer;
        }

        public Player(string name, int howManyDice, int wall)
        {
            _playerDicesForThrow = new List<NewDice>();
            _playerDicesToNotThrow = new List<NewDice>();
            _name = name;
            for(int i = 1; i <= howManyDice; i++)
            {
                _playerDicesForThrow.Add(new NewDice(wall));
            }
            _playerId = ++_howManyPlayer;
            _noDice = howManyDice;
        }

        public void AddNewDiceForThrow(int wall)
        {
            _playerDicesForThrow.Add(new NewDice(wall));
            _noDice++;
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