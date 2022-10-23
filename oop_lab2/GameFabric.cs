
class GamesFabric {

    public static Game getDefaultGame(UserAccount player1, UserAccount player2, int rating) 
    {
        return new DefaultGame(player1, player2, rating);  
    }

    public static Game getTrainingGame(UserAccount player1, UserAccount player2)
    {
        return new TrainingGame(player1, player2);
    }

    public static Game getAsymmetricGame(UserAccount player1, UserAccount player2, int rating)
    {
        return new AsymmetricGame(player1, player2, rating);
    }

    private class DefaultGame : Game
    {
        public DefaultGame(UserAccount player1, UserAccount player2, int rating) : base(player1, player2, rating, "default")
        {
        }

        public override void play()
        {
            Random random = new Random();
            int value = random.Next(Gamers.Length);
            if (0 == value)
            {
                Gamers[0].WinGame(this);
                Gamers[1].LostGame(this);
                Winner = Gamers[0].UserName;
                Loser = Gamers[1].UserName;
            }
            else
            {
                Gamers[1].WinGame(this);
                Gamers[0].LostGame(this);
                Winner = Gamers[1].UserName;
                Loser = Gamers[0].UserName;
            }
        }
    }

    private class TrainingGame : Game
    {
        public TrainingGame(UserAccount player1, UserAccount player2) : base(player1, player2, 0, "training")
        {
        }

        public override void play()
        {
            Random random = new Random();
            int value = random.Next(Gamers.Length);
            if (0 == value)
            {
                Gamers[0].WinGame(this);
                Gamers[1].LostGame(this);
                Winner = Gamers[0].UserName;
                Loser = Gamers[1].UserName;
            }
            else
            {
                Gamers[1].WinGame(this);
                Gamers[0].LostGame(this);
                Winner = Gamers[1].UserName;
                Loser = Gamers[0].UserName;
            }
        }
    }

    private class AsymmetricGame : Game
    {

        public AsymmetricGame(UserAccount player1, UserAccount player2, int rating) : base(player1, player2, rating, "asymmetric")
        {
            base.RatingLoser = 0;
        }

        public override void play()
        {
            Random random = new Random();
            int value = random.Next(Gamers.Length);
            if (0 == value)
            {
                Gamers[0].WinGame(this);
                Gamers[1].LostGame(this);
                Winner = Gamers[0].UserName;
                Loser = Gamers[1].UserName;
            }
            else
            {
                Gamers[1].WinGame(this);
                Gamers[0].LostGame(this);
                Winner = Gamers[1].UserName;
                Loser = Gamers[0].UserName;
            }
        }
    }

}

