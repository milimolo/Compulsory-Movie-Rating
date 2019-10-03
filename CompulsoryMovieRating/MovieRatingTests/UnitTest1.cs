using CompulsoryMovieRating;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MovieRatingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumberOfReviews()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test1_1.json");
            Assert.AreEqual(4, movie.GetReviewsFromReviewer(1));
        }

        [TestMethod]
        public void Test1IsNegative()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test1_1.json");
            Assert.IsFalse(movie.GetReviewsFromReviewer(1) < 0);
        }

        [TestMethod]
        public void TestAverageReviews()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test2_1.json");
            Assert.AreEqual(4, movie.GetAverageGradeFromReviewer(1));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This reviewer has not graded any movies.")]
        public void TestAverageException()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test2_1.json");
            movie.GetAverageGradeFromReviewer(4);
        }

        [TestMethod]
        public void TestReviewersExactGrade()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test3_1.json");
            Assert.AreEqual(3, movie.getReviewersExactGrade(2, 4));
        }

        [TestMethod]
        public void TestNumberOfReviewsByMovie()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test4_1.json");
            Assert.AreEqual(3, movie.getNumberOfReviewsByMovie(1488844));
        }

        [TestMethod]
        public void TestAverageMovieRating()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test5_1.json");
            Assert.AreEqual(4, movie.getAverageMovieRating(1488844));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This Movie has no ratings")]
        public void TestAverageMovieRatingException()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test5_1.json");
            movie.getAverageMovieRating(885014);
            
        }

        [TestMethod]
        public void TestSpecificRatingOfMovie()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test6_1.json");
            Assert.AreEqual(3, movie.getSpecificRatingOfMovie(1488844, 3));
        }

        [TestMethod]
        public void TestMoviesWithHighestReview()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test7_1.json");
            Assert.AreEqual(44937, movie.getMoviesWithHighestReview());
        }

        [TestMethod]
        public void TestMoviesWithHighestReview2()
        {
            Movie movie = new Movie();
            movie.loadData("TestJsons/Test7_1.json");
            Assert.AreEqual(712664, movie.getMoviesWithHighestReview());
        }
    }
}
