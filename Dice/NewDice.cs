namespace Dice
{
    public class NewDice
    {
        private int _howManyWall;
        private int _id;
        private static int _howManyDice = 0;
        private int count;

        public int HowManyWall
        {
            get { return _howManyWall; }
        }
        public int Id
        {
            get { return _id; }
        }

        public int Count 
        { 
            get { return count; } 
        }

        public NewDice(int howManyWall)
        {
            this._howManyWall = howManyWall;
            _howManyDice++;
            this._id = _howManyDice;
        }

        public void NewRoll()
        {
            count = Roll.DiceRoll(_howManyWall);
        }
    }
}