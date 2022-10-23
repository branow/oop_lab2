
public class UserAccountPlus : UserAccount
{

    private byte victories;

    public UserAccountPlus(string UserName) : base(UserName)
    {
    }

    public override void WinGame(Game game)
    {
        victories++;
        CurrentRating = CurrentRating + game.RatingWinner*victories;
        Games.Add(game);
        GamesCount++;
    }

    public override void LostGame(Game game)
    {
        victories = 0;
        CurrentRating = CurrentRating - game.RatingLoser;
        Games.Add(game);
        GamesCount++;
    }
} 