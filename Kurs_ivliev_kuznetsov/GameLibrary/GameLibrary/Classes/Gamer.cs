using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Gamer : User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Country Country { get; set; }

        public GameLibrary GameLibrary { get; set; }
        public decimal Balance { get; set; }


        public Gamer(string name, string email, string password, DateTime registrationDate,
             Country country, decimal balance, GameLibrary gameLibrary)
        {
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            Country = country;
            Balance = balance;
            GameLibrary = gameLibrary;
        }


        public void CreateReview(Game game, string text, float rating)
        {
            var review = new Review(game.Name, Name, rating, text, DateTime.Now);
            game.Reviews.Add(review);
            MessageBox.Show($"Review added for game {game.Name}: {text}");
        }

        public void DeleteReview(Game game, Review review)
        {
            game.Reviews.Remove(review);
        }

        public bool PurchaseGame(Game game)
        {
            if (Balance >= (decimal)game.Price)
            {
                if (GameLibrary.AddGame(game))
                {
                    Balance -= (decimal)game.Price;
                    MessageBox.Show($"Purchased game: {game.Name}");
                    return true;
                }
                return false;
            }
            else
            {
                MessageBox.Show("No money.");
                return false;
            }
        }

        public void ReturnGame(Game game)
        {
            GameLibrary.RemoveGame(game);
            Balance += (decimal)game.Price;
            MessageBox.Show($"Returned game: {game.Name}. Refunded {game.Price:C}");
        }
    }
}
