using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompulsoryMovieRating
{
    public class Movie
    {
        Review review = new Review();

        public List<Review> reviews;

        public void  loadData(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                reviews = JsonConvert.DeserializeObject<List<Review>>(json);
            }
        }

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

        public int getReviewersExactGrade(int reviewerId, int grade)
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

        public int getNumberOfReviewsByMovie(int movieId)
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
        public int getAverageMovieRating(int movieId)
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

        public int getSpecificRatingOfMovie(int movieId, int grade)
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

        /*
        public int getMoviesWithHighestReview()
        {
            List<int>

            foreach (var review in reviews)
            {
                
            }
        }
        */
    }

    public class Review
    {
        public int Reviewer;
        public int Movie;
        public int Grade;
        public DateTime Date;
    }
}
