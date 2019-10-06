using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompulsoryMovieRating
{
    public class Movie
    {
        Review review = new Review();

        public List<Review> reviews;

        public void  LoadData(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                reviews = JsonConvert.DeserializeObject<List<Review>>(json);
            }
        }

        //opgave 1
        public int GetReviewsFromReviewer(int reviewerId)
        {
            int count = 0;
            foreach (var review in reviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    count++;
                }
            }
            return count;
        }

        //opgave 2
        public int GetAverageGradeFromReviewer(int reviewerId)
        {
            int count = 0;
            int totalGrade = 0;
            foreach (var review in reviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    count++;
                    totalGrade = totalGrade + review.Grade;
                }
            }
            if (totalGrade == 0)
            {
                throw new Exception("This reviewer has not graded any movies.");
            }
            int averageGrade = (totalGrade / count);
            return averageGrade;
        }

        //opgave 3
        public int GetReviewersExactGrade(int reviewerId, int grade)
        {
            int numberOfGrades = 0;

            foreach (var review in reviews)
            {
                if (review.Reviewer == reviewerId && review.Grade == grade)
                {
                    numberOfGrades++;
                }
            }
            return numberOfGrades;

        }

        //opgave 4
        public int GetNumberOfReviewsByMovie(int movieId)
        {
            int numberOfReviews = 0;

            foreach (var review in reviews)
            {
                if (review.Movie == movieId)
                {
                    numberOfReviews++;
                }
            }
            return numberOfReviews;

        }

        //opgave 5
        public int GetAverageMovieRating(int movieId)
        {
            int count = 0;
            int totalRating = 0;
            foreach (var review in reviews)
            {
                if (review.Movie == movieId)
                {
                    count++;
                    totalRating = totalRating + review.Grade;
                }
            }
            if (totalRating == 0)
            {
                throw new Exception("This Movie has no ratings");
            }
            int averageRating = (totalRating / count);
            return averageRating;
        }

        //opgave 6
        public int GetSpecificRatingOfMovie(int movieId, int grade)
        {
            int numberOfRatings = 0;

            foreach (var review in reviews)
            {
                if (review.Movie == movieId && review.Grade == grade)
                {
                    numberOfRatings++;
                }
            }
            return numberOfRatings;
        }

        //opgave 7
        public int GetMoviesWithHighestReview()
        {
            IEnumerable<Review> TopRtdMovies = reviews.Where(r => r.Grade == 5);
            TopRtdMovies.GroupBy(r => r.Movie).OrderByDescending(gru => gru.Count());
            var bestMovie = TopRtdMovies.First().Movie;
            return bestMovie;
        }

        //opgave 8
        public int GetTopReviewer()
        {
            var topReviwer = reviews.GroupBy(r => r.Reviewer)
                .OrderByDescending(gru => gru.Count()).Select(gru => gru.Key)
                .First();
            return topReviwer;
        }


        //opgave 9
        public int GetTopAverageMovie()
        {
            throw new NotImplementedException();
        }

        //opgave 10
        public List<int> GetReviewedMoviesByReviewer(int reviewerId)
        {
            var revList = reviews.Where(r => r.Reviewer == reviewerId)
                .OrderByDescending(r => r.Grade)
                .ThenBy(r => r.Date).ToArray();

            List<int> movies = new List<int>();
            foreach (var movie in revList)
            {
                movies.Add(movie.Movie);
            }

            return movies;
        }

        //Opgave 11
        public List<int> GetReviewersByMovie(int movieId)
        {
            var revList = reviews.Where(r => r.Movie == movieId)
                .OrderByDescending(r => r.Grade)
                .ThenBy(r => r.Date).ToList();


            List<int> reviewers = new List<int>();
            foreach (var reviewer in revList)
            {
                reviewers.Add(reviewer.Reviewer);
            }

            return reviewers;
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
