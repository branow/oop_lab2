public abstract class Game { 

    public static List<Game> history = new List<Game>();
    public int Id { get; }
    public UserAccount[] Gamers { get; }
    public int RatingWinner { get; set; }
    public int RatingLoser { get; set; }
    public string Winner { get; set; }
    public string Loser { get; set; }
    public string Type { get; }

    public Game(UserAccount player1, UserAccount player2, int rating, string type)
    {
        this.Gamers = new UserAccount[2] { player1, player2 };
        if (rating < 0) throw new ArgumentOutOfRangeException(nameof(rating), "Must be > 0");
        this.RatingWinner = rating;
        this.RatingLoser = rating;
        Type = type;
        Id = history.Count;
        history.Add(this);
    }

    public abstract void play();
    

}