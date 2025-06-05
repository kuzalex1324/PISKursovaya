using System;
using System.Collections.Generic;
using GameLibraryDA.Classes;

namespace GameLibraryDA
{
    public class Administrator : User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Country Country { get; set; }

        public Administrator(string name, string email, string password,
                             DateTime registrationDate, Country country)
        {
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            Country = country;
        }

        public void BanGamer(Gamer gamer)
        {
            Console.WriteLine($"Gamer '{gamer.Name}' has been banned.");
        }

        public void DeleteReview(Game game, Review review)
        {
            Console.WriteLine($"Review {game.Reviews.Remove(review)} deleted.");
        }

        public void ApproveApplication(Applicationn application)
        {
            Console.WriteLine("Application approved.");
            application.IsChecked = true;
        }

        public void DeclineApplication(Applicationn application, string reason)
        {
            application.Reason = reason;
            application.IsChecked = true;
            Console.WriteLine($"Application declined. Reason: {reason}");
        }
    }
}
