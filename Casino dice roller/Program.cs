using System;

namespace Casino_dice_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomnum1;
            int playerRandomnum2;

            Random rando = new Random();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Press any key the roll the pair of dice");

                Console.ReadKey();

                playerRandomnum1 = rando.Next(1, 7);
                playerRandomnum2 = rando.Next(1, 7);
                Console.WriteLine($"You rolled a {playerRandomnum1} and {playerRandomnum2} ");

                int total;
                total = playerRandomnum1 + playerRandomnum2;

            }
            
        }
    }
}
