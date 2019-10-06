using CompulsoryMovieRating;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MovieRatingTests
{
    [TestClass]
    public class UnitTest1
    {
        //Test for opgave 1
        [TestMethod]
        public void TestNumberOfReviews()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test1_1.json");
            Assert.AreEqual(4, movie.GetReviewsFromReviewer(1));
        }

        [TestMethod]
        public void Test1IsNegative()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test1_1.json");
            Assert.IsFalse(movie.GetReviewsFromReviewer(1) < 0);
        }

        //Test for opgave 2
        [TestMethod]
        public void TestAverageReviews()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test2_1.json");
            Assert.AreEqual(4, movie.GetAverageGradeFromReviewer(1));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This reviewer has not graded any movies.")]
        public void TestAverageException()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test2_1.json");
            movie.GetAverageGradeFromReviewer(4);
        }

        //Test for opgave 3
        [TestMethod]
        public void TestReviewersExactGrade()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test3_1.json");
            Assert.AreEqual(3, movie.GetReviewersExactGrade(2, 4));
        }

        //Test for opgave 4
        [TestMethod]
        public void TestNumberOfReviewsByMovie()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test4_1.json");
            Assert.AreEqual(3, movie.GetNumberOfReviewsByMovie(1488844));
        }

        //Test for opgave 5
        [TestMethod]
        public void TestAverageMovieRating()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test5_1.json");
            Assert.AreEqual(4, movie.GetAverageMovieRating(1488844));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This Movie has no ratings")]
        public void TestAverageMovieRatingException()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test5_1.json");
            movie.GetAverageMovieRating(885014);
            
        }

        //Test for opgave 6
        [TestMethod]
        public void TestSpecificRatingOfMovie()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test6_1.json");
            Assert.AreEqual(3, movie.GetSpecificRatingOfMovie(1488844, 3));
        }

        //Test for opgave 7
        [TestMethod]
        public void TestMoviesWithHighestReview()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test7_1.json");
            Assert.AreEqual(44937, movie.GetMoviesWithHighestReview());
        }

        //Test for opgave 8
        [TestMethod]
        public void TestReviewerWithMostReviews()
        {
            Movie movie = new Movie();
            movie.LoadData("TestJsons/Test8_1.json");
            Assert.AreEqual(2, movie.GetTopReviewer());
        }


    }
}
