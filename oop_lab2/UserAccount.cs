public class UserAccount
{

    public string UserName { get; }
    private int currentRating;
    public int CurrentRating
    {
        get { return currentRating; }
        set
        {
            currentRating = value;
            if (currentRating < 1)
            {
                currentRating = 1;
            }
        }
    }
    public int GamesCount { get; set; }
    public List<Game> Games { get; }

    public UserAccount(string UserName)
    {
        this.UserName = UserName;
        CurrentRating = 1;
        GamesCount = 0;
        Games = new List<Game>();
    }

    public virtual void WinGame(Game game)
    {
        CurrentRating = CurrentRating + game.RatingWinner;
        Games.Add(game);
        GamesCount++;
    }

    public virtual void LostGame(Game game)
    {
        CurrentRating = CurrentRating - game.RatingLoser;
        Games.Add(game);
        GamesCount++;
    }

    public void GetStats()
    {
        Console.WriteLine(UserName + " played: " + GamesCount + " games, " + CurrentRating + " rating");
        foreach (Game g in Games)
        {
            bool win = g.Winner.Equals(UserName) ? true : false;
            if (win)
            {
                Console.WriteLine("Won: " + g.Type + " game -> " + g.Id + ", rating -> +" + g.RatingWinner + ", opponent -> " + g.Loser);
            }
            else
            {
                Console.WriteLine("Lost: " + g.Type + " game -> " + g.Id + ", rating -> -" + g.RatingLoser + ", opponent -> " + g.Winner);
            }
        }
    }

}