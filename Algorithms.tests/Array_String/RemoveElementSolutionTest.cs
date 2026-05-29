using Algorithms.Array_String;
using Xunit;

namespace Algorithms.tests.Array_String
{
    public class RemoveElementSolutionTest
    {
        // use attributes to tell the test runner how to behave
        [Theory]
        // Example 1
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2,2 })]
        // Example 2
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 4, 0, 3 })]

        public void RemoveElement_ShouldModifyArrayInPlace(int[] nums, int val, int expectedK, int[] expectedNums)
        {
            // 1. ARRANGE
            var solution = new RemoveElementSolution();

            // 2. ACT
            int k = solution.RemoveElement(nums, val);

            // 3. ASSERT

            Assert.Equal(expectedK, k);

            // Assert 2: Does the modified array match the expected array?
            Array.Sort(nums, 0, k);
            Array.Sort(expectedNums);

            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }
    }
}
