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

        [TestMethod]
        public void PerformanceTest2()
        {
            Stopwatch sw = Stopwatch.StartNew();
            movie.GetAverageGradeFromReviewer(1);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest3()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetReviewersExactGrade(2, 4);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest4()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetNumberOfReviewsByMovie(1488844);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest5()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetAverageMovieRating(1488844);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest6()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetSpecificRatingOfMovie(1488844, 3);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest7()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetMoviesWithHighestReview();
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest8()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetTopReviewer();
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest10()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetReviewedMoviesByReviewer(1);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }

        [TestMethod]
        public void PerformanceTest11()
        {
            Stopwatch sw = Stopwatch.StartNew(); ;
            movie.GetReviewersByMovie(822109);
            sw.Stop();

            var seconds = sw.ElapsedMilliseconds / 1000.0;

            Assert.IsTrue(seconds <= MAXTIME);
        }
    }
}
