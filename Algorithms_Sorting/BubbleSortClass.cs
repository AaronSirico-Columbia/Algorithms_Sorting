/// <summary>
/// Bubble Sort Algorithm
/// Explanation: Bubble sort starts at the beginning of an array and swaps the first two elements if the first is greater than the second. 
/// Moving to the next pair, the same comparison is made.
/// Asymptotic Notation:
/// Best case = O(n)
/// Worst case = O(n^2)
/// Psuedo Code:
///START
/// for i from 0 to ArrayLength - 1
/// for z from 0 to ArrayLength - i - 1
///   if nums[z] > nums[z + 1] then
///       # Swap elements if they are in the wrong order
///       temp = nums[z]
///     nums[z] = nums[z + 1]
///     nums[z + 1] = temp
///   end if
///  end for
/// end for
///END
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms_Sorting
{
    public class BubbleSortClass
    {
        public string? FilePath;

        public void SetUpBubbleSort(int[] nums)
        {

            int ArrayLength = nums.Length;

            for (int i = 0; i < ArrayLength - 1; i++)
            {
                for (int z = 0; z < ArrayLength - i - 1; z++)
                {
                    if (nums[z] > nums[z + 1])
                    {
                        int temp = nums[z];
                        nums[z] = nums[z + 1];
                        nums[z + 1] = temp;
                    }
                }
            }

        }

        
    }
}
