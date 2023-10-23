using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("dog", false)]
        [InlineData("cat", false)]
        [InlineData("civic", true)]
        [InlineData("noon", true)]
        [InlineData("tattarrattat", true)]

        public void Test1(string name, bool expected)
        {
            //Arrange
            var pal = new WordSmith();

            //Act

            var actual = pal.IsAPalindrome(name);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
