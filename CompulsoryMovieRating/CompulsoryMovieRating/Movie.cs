using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompulsoryMovieRating
{
    class Movie
    {
        public List<Review> reviews;
        public Movie()
        {
            using (StreamReader r = new StreamReader("C:/Users/bonde/GitHub/Compulsory-Movie-Rating/CompulsoryMovieRating/TempRatings.json"))
            {
                string json = r.ReadToEnd();
                reviews = JsonConvert.DeserializeObject<List<Review>>(json);
            }
        }
    }

    public class Review
    {
        public int Reviewer;
        public int Movie;
        public int Grade;
        public DateTime Date;
    }
}
