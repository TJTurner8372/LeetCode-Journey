using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Array_String
{
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            // counter and pointer where to put the notVal numbers
            int notVal = 0;
            for (int readPtr = 0; readPtr < nums.Length; readPtr++)
            {
                if (nums[readPtr] != val)
                {
                    // saving the pointer to the current safe index of notVal
                    nums[notVal] = nums[readPtr];
                    notVal++;
                }

                
            }
            return notVal;
        }
    }
}
