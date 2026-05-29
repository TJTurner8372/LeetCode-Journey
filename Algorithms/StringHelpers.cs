using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StringHelpers
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right]) return false;
                left++;
                right--;
            }
            return true;
          
        }
    }
}
