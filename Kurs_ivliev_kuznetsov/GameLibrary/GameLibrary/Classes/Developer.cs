using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Developer : User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Country Country { get; set; }

        public List<Applicationn> ActiveApplications { get; set; }
        public List<Game> Games { get; set; }


        public Developer(string name, string email, string password,
                         DateTime registrationDate, Country country, List<Applicationn> applications, List<Game> games)
        {
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            Country = country;
            ActiveApplications = applications;
            Games = games;
        }

        public void CreateApplication(string gameName, in string gameGenre)
        {
            Applicationn application = new Applicationn(DateTime.Now, false, null, "");
            ActiveApplications.Add(application);
            Console.WriteLine($"Application created for game: {gameName} [{gameGenre}]");
        }

        public void DeleteApplication(Applicationn application)
        {
            ActiveApplications.Remove(application);
        }

        public void GetGameStatistic(Game game)
        {
            Console.WriteLine($"Statistics for game '{game.Name}':");
        }
    }
}
