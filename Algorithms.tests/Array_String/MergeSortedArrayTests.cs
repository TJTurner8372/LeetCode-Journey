using Algorithms.Array_String;
using Xunit;


namespace Algorithms.tests.Array_String
{
    public class MergeSortedArrayTests
    {
        // use attributes to tell the test runner how to behave
        [Theory]
        // Example 1
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        // Example 2
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        // Example 3
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]

        public void Merge_ShouldModifyNums1Correctly(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            // 1. ARRANGE
            var solution = new MergeSortedArray();

            // 2. ACT
            solution.Merge(nums1, m, nums2, n);

            // 3. ASSERT
            
            Assert.Equal(expected, nums1);
        }
    }
}
