class RockPaperScissorsGame
{
    private Player player1;
    private Player player2;
    public RockPaperScissorsGame(string player1Name, string player2Name)
    {
        if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
        {
            throw new ArgumentException("Player names cannot be empty or null.");
        }
        player1 = new Player(player1Name);
        player2 = new Player(player2Name);
    }
    public void StartGame()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
        do
        {
            Console.WriteLine($"{player1.Name} score: {player1.Score} | {player2.Name} score: {player2.Score}\n\n");
            player1.MakeChoice();
            player2.MakeChoice();
            DetermineWinner();
            Thread.Sleep(1500);
            Console.Clear();
        } while(player1.Score!=3 && player2.Score != 3);
        Console.WriteLine("Game Over!");
        Console.WriteLine($"Final Scores:\n {player1.Name} : {player1.Score}\n {player2.Name} : {player2.Score}\n");
        if (player1.Score > player2.Score)
        {
            Console.WriteLine($"{player1.Name} is the overall winner!");
        }
        else if (player2.Score > player1.Score)
        {
            Console.WriteLine($"{player2.Name} is the overall winner!");
        }
    }
    private void DetermineWinner()
    {
        if (player1.Choice == player2.Choice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((player1.Choice == "rock" && player2.Choice == "scissors") ||
                 (player1.Choice == "paper" && player2.Choice == "rock") ||
                 (player1.Choice == "scissors" && player2.Choice == "paper"))
        {
            Console.WriteLine($"{player1.Name} wins!");
            player1.Score++;
        }
        else
        {
            Console.WriteLine($"{player2.Name} wins!");
            player2.Score++;
        }
    }
}

class Player(string name)
{
    public string Name { get; set; } = name;
    public string Choice { get; set; } = string.Empty;
    public int Score { get; set; } = 0;

    public void MakeChoice()
    {
        Console.WriteLine($"{this.Name}, please enter your choice (rock, paper, or scissors):");
        Choice = Console.ReadLine() ?? string.Empty;
        if (Choice.ToLower() != "rock" && Choice.ToLower() != "paper" && Choice.ToLower() != "scissors")
        {
            Console.WriteLine("Invalid choice! Please choose rock, paper, or scissors.");
            MakeChoice(); // Recursive call to get a valid choice
        }
        else
        {
            Choice = Choice.ToLower();
        }
    }
}