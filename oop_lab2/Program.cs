
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1) Test Program with default user`s accounts");

        UserAccount u1 = new UserAccount("player1");
        UserAccount u2 = new UserAccount("player2");

        Game g1 = GamesFabric.getTrainingGame(u1, u2); //traning game doesn't have rating
        Game g2 = GamesFabric.getDefaultGame(u1, u2, 400); //default game is when winner add rating and loser loses rating
        Game g3 = GamesFabric.getAsymmetricGame(u1, u2, 800); //assymmetric game is when only winner add rating and loser doen's lose rating

        g1.play();
        g2.play();
        g3.play();

        Console.WriteLine();
        u1.GetStats();
        Console.WriteLine();
        u2.GetStats();


        Console.WriteLine("\n2) Test Program with user`s accounts plus");

        /* if player has account plus, he get rating multiplay on number of his victories suborder*/
        u1 = new UserAccountPlus("player1");
        u2 = new UserAccountPlus("player2");

        g1 = GamesFabric.getTrainingGame(u1, u2);
        g2 = GamesFabric.getDefaultGame(u1, u2, 400);
        g3 = GamesFabric.getAsymmetricGame(u1, u2, 800);

        g1.play();
        g2.play();
        g3.play();

        Console.WriteLine();
        u1.GetStats();
        Console.WriteLine();
        u2.GetStats();

        Console.WriteLine("\n3) Test Program with user`s accounts premium");

        /* if player has premium account, he doesn't lose own ration when he loses a game*/
        u1 = new UserAccountPlus("player1");
        u2 = new UserAccountPlus("player2");

        g1 = GamesFabric.getTrainingGame(u1, u2);
        g2 = GamesFabric.getDefaultGame(u1, u2, 400);
        g3 = GamesFabric.getAsymmetricGame(u1, u2, 800);

        g1.play();
        g2.play();
        g3.play();

        Console.WriteLine();
        u1.GetStats();
        Console.WriteLine();
        u2.GetStats();

    }

}






