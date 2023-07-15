using System;
using System.ComponentModel;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", false)]
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();

            bool actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
