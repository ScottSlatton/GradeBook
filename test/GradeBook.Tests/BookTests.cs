using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            //arrange
            var book = new Book("");
            book.AddGrade(12.1);
            book.AddGrade(30.0);
            book.AddGrade(96.2);

            //act
            var result = book.GetStats();

            //assert

            Assert.Equal(12.1, result.Low, 1);
            Assert.Equal(96.2, result.High, 1);
            Assert.Equal(46.1, result.Average, 1);


        }
    }
}
