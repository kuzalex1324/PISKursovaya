using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Game
    {
        public string Name { get; set; }
        public float Size { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; }
        public List<Review> Reviews { get; set; }

        private bool IsDownloaded { get; set; } = false;
        private bool IsRunning { get; set; } = false;

        public Game(string name, float size, float price, string genre, List<Review> reviews)
        {
            Name = name;
            Size = size;
            Price = price;
            Genre = genre;
            Reviews = reviews;
        }

        public void DownloadGame()
        {
            if (IsDownloaded)
            {
                Console.WriteLine($"Game '{Name}' is already downloaded.");
                return;
            }

            IsDownloaded = true;
            Console.WriteLine($"Downloading game '{Name}' ({Size} MB)...");
        }

        public void DeleteGame()
        {

            if (IsDownloaded)
            {
                Console.WriteLine($"Game '{Name}' is already downloaded.");
                return;
            }

            IsDownloaded = true;
            Console.WriteLine($"Downloading game '{Name}' ({Size} MB)...");
        }

        public void RunGame()
        {
            if (IsRunning)
            {
                Console.WriteLine($"Game '{Name}' is already running.");
                return;
            }

            IsRunning = true;
            Console.WriteLine($"Game '{Name}' is now running.");
        }

        public void StopGame()
        {

            IsRunning = false;
            Console.WriteLine($"Game '{Name}' has been stopped.");
        }
    }
}
