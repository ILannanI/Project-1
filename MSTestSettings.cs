using System;

public class Player
{
    private string initials;
    private int score;

    public string Initials
    {
        get { return initials; }
        set { initials = value; }
    }

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public Player(string initials, int score)
    {
        this.initials = initials;
        this.score = score;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("AB", 100);
        Console.WriteLine($"Player Initials: {player1.Initials}");
        Console.WriteLine($"Player Score: {player1.Score}");
    }
}

