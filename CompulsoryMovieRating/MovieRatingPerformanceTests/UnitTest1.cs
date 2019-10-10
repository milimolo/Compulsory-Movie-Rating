using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompulsoryMovieRating;
using System.Diagnostics;

namespace MovieRatingPerformanceTests
{
    [TestClass]
    public class UnitTest1
    {
        static readonly Movie movie = new Movie("ratings.json");

        const double MAXTIME = 4;

        [TestMethod]
        public void PerformanceTest1()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetReviewsFromReviewer(1);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);

        }
    }
}
