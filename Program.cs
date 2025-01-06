using System;
class Program
{
    public static int roundNumber = 0;

    public static int playerScore = 0;

    public static int rivalScore = 0;
    public static void Main(string[] args)
    {
        StartGame();
        DiceRoll();
        EndGame();
    }

    public static void StartGame()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press any key to start...");

        Console.ReadKey();
    }

    public static void DiceRoll()
    {
        for(int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 7);

            roundNumber = roundNumber + 1;
            Console.WriteLine();
            Console.WriteLine("Round " + roundNumber);
            Console.WriteLine("Rival rolled a " + num);
            Console.WriteLine("Press any key to roll the dice...");

            Console.ReadKey();

            Random rand = new Random();
            int num1 = rnd.Next(1, 7);

            Console.WriteLine("You rolled a " + num1);

            if(num1 > num)
            {
                playerScore = playerScore + 1;
                Console.WriteLine("You won this round.");
                Console.WriteLine("The score is now - You: " + playerScore + ". Rival: " + rivalScore + ".");
                Console.WriteLine("Press any key to continue...");
            }

            if(num1 < num)
            {
                rivalScore = rivalScore + 1;
                Console.WriteLine("The Rival won this round.");
                Console.WriteLine("The score is now - You: " + playerScore + ". Rival: " + rivalScore + ".");
                Console.WriteLine("Press any key to continue...");
            }

            if(num1 == num)
            {
                Console.WriteLine("This round is a draw!");
                Console.WriteLine("The score is now - You: " + playerScore + ". Rival: " + rivalScore + ".");
                Console.WriteLine("Press any key to continue...");
            }

            Console.ReadKey();
        }

        EndGame();
    }

    public static void EndGame()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.");
        Console.WriteLine("The score is now - You: " + playerScore + ". Rival: " + rivalScore + ".");

        if(playerScore > rivalScore)
        {
            Console.WriteLine("You won!");
        }

        if(playerScore < rivalScore)
        {
            Console.WriteLine("You lost!");
        }

        if(playerScore == rivalScore)
        {
            Console.WriteLine("The game was a draw!");
        }

        Console.WriteLine("Press any key to exit...");

        Console.ReadKey();
    }
}
