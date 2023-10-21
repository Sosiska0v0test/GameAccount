using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public class GameAccount
    {
        private string playerName;
        private int rating;
        private int gamesCount;

        public string GetPlayerName()
        {
             return playerName;
        }
        public GameAccount(string playerName, int rating, int gamesCount)
        {
            this.playerName = playerName;
            this.rating = rating;
            this.gamesCount = gamesCount;
        }

        private List<GameHistory> GameResults = new List<GameHistory>();
        
        public void WinGame(GameAccount opponentName, int ratingForGame)
        {
            if(ratingForGame < 0)
            {
                Console.WriteLine("Game " + gamesCount + ". " + "Rating for game must be less then 0");
                return;
            }
            rating += ratingForGame;
            if (opponentName.rating - ratingForGame < 1)
            {
                opponentName.rating = 1;
            }
            else
            {
                opponentName.rating -= ratingForGame;
            }
            Console.WriteLine("Game " + (gamesCount + opponentName.gamesCount) + ". " + playerName + " won game against " + opponentName.playerName);
            gamesCount++;
            GameResults.Add(new GameHistory(this, opponentName, true, ratingForGame));
        }
                
        public void LoseGame(GameAccount opponentName, int ratingForGame)
        {
            if (ratingForGame < 0)
            {
                Console.WriteLine("Game " + gamesCount + ". " + "Rating for game must be less then 0");
                return;
            }
            if (rating - ratingForGame < 1)
            {
                rating = 1;
            }
            else
            {
                rating -= ratingForGame;
            }
            opponentName.rating += ratingForGame;
            Console.WriteLine("Game " + (gamesCount + opponentName.gamesCount) + ". " + playerName + " lose game against " + opponentName.playerName);
            gamesCount++;
            GameResults.Add(new GameHistory(this, opponentName, false, ratingForGame));
        }
                      
        public void GetStats()
        {
            Console.WriteLine("\n" + playerName + "'s current score:\t" + rating);
            Console.WriteLine("Game history of " + playerName + ": ");
            foreach (GameHistory PlayerHistory in GameResults)
            {
                PlayerHistory.ShowPlayerHistory();
            }
        }

               
    }
}
