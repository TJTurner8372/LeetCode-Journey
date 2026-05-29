using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Array_String
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // num1 has a bunch of empty space

            // index of nums1. this should be the largest number in the array
            int p1 = m - 1;
            // index of num2. this should be the largest number in the array
            int p2 = n - 1;
            // last index of the nums1 array where we will be putting the numbers into
            int pMerge = n + m - 1;

            // compare while both arrays still have elements
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    // if the value in num1 is bigger keep it and move the pointer back 1 space
                    nums1[pMerge] = nums1[p1];
                    p1--;
                }
                else
                {
                    // otherwise nums2 number is larger so put that in the nums1 array
                    nums1[pMerge] = nums2[p2];
                    p2--;
                }
                // spot is always filled so back track the pMerge pointer in the nums1 array
                pMerge--;
            }

            // handles left overs in nums2
            while (p2 >= 0)
            {
                nums1[pMerge] = nums2[p2];
                p2--;
                pMerge--;
            }
        }
    }
}
