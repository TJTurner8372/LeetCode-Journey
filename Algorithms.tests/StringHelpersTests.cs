using Algorithms;
using Xunit;

namespace Algorithms.tests
{
    // test classes MUST be public
    public class StringHelpersTests
    {
        // use attributes to tell the test runner how to behave
        [Theory]
        [InlineData("racecar", true)] // standard palindrome.
        [InlineData("hello", false)] // not a palindrome.
        [InlineData("a", true)] // single character edge case.
        [InlineData("", false)] // empty string edge case.

        public void IsPallindrome_ShouldReturnCorrectBoolean(string testWord, bool expectedResult)
        {
            // 1. ARRANGE
            // Instantiate the class that contains the algorithm
            var helper = new StringHelpers();

            // 2. ACT
            // Call the method and store what it actually returns
            bool actualResult = helper.IsPalindrome(testWord);

            // 3. ASSERT
            // Check if the actual result matches what we expected it to be
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
