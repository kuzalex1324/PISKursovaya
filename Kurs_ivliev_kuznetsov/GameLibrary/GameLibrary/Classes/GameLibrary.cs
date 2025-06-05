using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class GameLibrary
    {
        public List<Game> Games { get; set; } = new List<Game>();
        public Game CurrentGame { get; set; }

        public GameLibrary(List<Game> games, Game currentGame) 
        {
            Games = games;
            CurrentGame = currentGame;
        }

        public void DownloadGame()
        {
            if (CurrentGame != null)
            {
                CurrentGame.DownloadGame();
                MessageBox.Show($"Downloading game: {CurrentGame.Name}");
            }
            else
            {
                MessageBox.Show("Game not found!");
            }
        }

        public void DeleteGame()
        {
            if (CurrentGame != null)
            {
                CurrentGame.DeleteGame();
                MessageBox.Show($"Game {CurrentGame.Name} deleted.");
            }
            else
            {
                MessageBox.Show("Game not found!");
            }
        }

        public bool AddGame(Game game)
        {
            if (Games.Any(g => g.Name == game.Name))
            {
                MessageBox.Show("Уже есть эта игра");
                return false;
            }
            else
            {
                Games.Add(game);
                MessageBox.Show($"Game {game.Name} added to library.");
                return true;
            }

        }

        public void RemoveGame(Game game)
        {
            if (game != null)
            {
                Games.Remove(game);
                MessageBox.Show($"Game {game.Name} removed from library.");
            }
            else
            {
                MessageBox.Show("Game not found!");
            }
        }

        public void RunGame(Game game)
        {
            if (game != null)
            {
                CurrentGame = game;
                MessageBox.Show($"Running game: {game.Name}");
            }
            else
            {
                MessageBox.Show("Game not found!");
            }
        }

        public void StopGame(Game game)
        {
            if (CurrentGame != null && CurrentGame != null)
            {
                MessageBox.Show($"Stopping game: {CurrentGame.Name}");
            }
            else
            {
                MessageBox.Show("No game is currently running or the game id doesn't match.");
            }
        }
    }
}
