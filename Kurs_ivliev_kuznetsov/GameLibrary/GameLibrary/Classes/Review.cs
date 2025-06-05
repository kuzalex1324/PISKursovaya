using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Review
    {
        public string GameName { get; set; }
        public string GamerName { get; set; }
        public float Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review(string gameName, string gamerName, float rating, string comment, DateTime reviewsDate)
        {
            GameName = gameName;
            GamerName = gamerName;
            Rating = rating;
            Comment = comment;
            ReviewDate = reviewsDate;
        }

        public void Edit(in string comment, in float rating)
        {
            if (rating < 0.0f || rating > 10.0f)
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 0 and 10.");

            Comment = comment;
            Rating = rating;
            ReviewDate = DateTime.Now;
        }
    }
}
