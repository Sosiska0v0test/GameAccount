using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public class GameHistory
    {
        private GameAccount FirstPlayer;
        private GameAccount SecondPlayer;
        private static int Games = 0;
        private int GameID; 
        private bool IsFirstPlayerWon;
        private int RatingForGame;

        public GameHistory(GameAccount firstPlayer, GameAccount secondPlayer, bool isFirstPlayerWon, int ratingForGame)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            IsFirstPlayerWon = isFirstPlayerWon;
            RatingForGame = ratingForGame;
            GameID = Games;
            Games++;
        }
        
        public void ShowPlayerHistory()
        {
            Console.WriteLine("Game ID: " + GameID + "| Opponent is " + SecondPlayer.GetPlayerName() +
            ". Winner of the game is " + (IsFirstPlayerWon ? FirstPlayer.GetPlayerName() : SecondPlayer.GetPlayerName()) + 
            ". Played for " + RatingForGame + " points");
        }
    }
}
