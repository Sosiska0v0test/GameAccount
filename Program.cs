using LR1;

namespace Lab1
{
    public class LR1
    {
        private static int startPoints = 1000;

        public static void Main(String[] args)
        {
            //players start game with 1000 points
            GameAccount Player1 = new GameAccount("Sofia", startPoints, 0);
            GameAccount Player2 = new GameAccount("Liza", startPoints, 0);

            Player1.WinGame(Player2, 100);

            Player2.WinGame(Player1, 250);

            Player1.LoseGame(Player2, 150);

            Player2.LoseGame(Player1, 200);

            Player1.WinGame(Player2, 500);

            Player1.GetStats();
            Player2.GetStats();
        }
    }
}


