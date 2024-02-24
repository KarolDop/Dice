﻿namespace Dice
{
    public class NewDice
    {
        private int howManyWall;
        private int id;
        private static int howManyDice = 0;

        public int HowManyWall
        {
            get { return howManyWall; }
        }
        public int Id
        {
            get { return id; }
        }

        public NewDice(int howManyWall)
        {
            howManyWall = this.howManyWall;
            id = ++howManyDice;
        }

        public int NewRoll()
        {
            return Roll.DiceRoll(howManyWall);
        }
    }
}