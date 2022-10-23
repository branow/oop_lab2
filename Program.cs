

    public static void Main(string[] args) {
        UserAccount u1 = new UserAccount("player1");
        UserAccount u2 = new UserAccount("player2");
        Game g1 = new Game(u1, u2, 1000);
        Game g2 = new Game(u1, u2, 800);
        Game g3 = new Game(u1, u2, 400);
        Game g4 = new Game(u1, u2, 300);
        try {
            Game g5 = new Game(u1, u2, -100);
        } catch (ArgumentOutOfRangeException e) {
            Console.WriteLine(e);
        }
        g1.play();
        g2.play();
        g3.play();
        g4.play();
        Console.WriteLine();
        u1.GetStats();
        Console.WriteLine();
        u2.GetStats();
    }




