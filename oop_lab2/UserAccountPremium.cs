
public class UserAccountPremium : UserAccount
{


    public UserAccountPremium(string UserName) : base(UserName)
    {
    }

    public override void WinGame(Game game)
    {
        CurrentRating = CurrentRating + game.RatingWinner;
        Games.Add(game);
        GamesCount++;
    }

    public override void LostGame(Game game)
    {   
        Games.Add(game);
        GamesCount++;
    }
}