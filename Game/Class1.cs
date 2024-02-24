using Dice;

namespace Game
{
    internal class Class1
    {
        public static void Main()
        {
            var dice1 = new NewDice(6);
            var dice2 = new NewDice(6);

            Console.WriteLine(dice1.Id);
            Console.WriteLine(dice2.Id);
            Console.ReadLine();
            int i = dice1.NewRoll();
            Console.Write(i);
            i = dice1.NewRoll();
            Console.Write(i);
        }
    }
}
