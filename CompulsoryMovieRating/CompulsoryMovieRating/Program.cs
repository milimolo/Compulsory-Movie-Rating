using System;

namespace CompulsoryMovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            foreach (var review in movie.reviews)
            {
                System.Console.WriteLine($"List of reviewers {review.Reviewer} movie number: {review.Movie}, Grade: {review.Grade}, Date: {review.Date}");

                

                movie.PrintTimeInSeconds();
            }
            
        }
    }
}
