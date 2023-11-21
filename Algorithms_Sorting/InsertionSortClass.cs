/// <summary>
/// Insertion Sort Algorithm
/// Explanation: Insertion sort is a simple sorting algorithm that builds the final sorted set one item at a time. 
/// It is efficient on small data sets but is much less efficient on large sets.
/// Asymptotic Notation:
/// Best case = O(n)
/// Worst case = O(n^2)
/// Psuedo Code:
/// START
///    for i from 1 to ArrayLength - 1
///        keyValue = nums[i]
///        z = i - 1
///        while z >= 0 and nums[z] > keyValue
///            nums[z + 1] = nums[z]
///            z = z - 1
///        nums[z + 1] = keyValue
/// END
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Sorting
{
    public class InsertionSortClass
    {
        public string? FilePath;
        public void SetUpInsertionSort(int[] nums)
        {
            int ArrayLength = nums.Length;

            for (int i = 1; i < ArrayLength; i++)
            {
                int keyValue = nums[i];
                int z = i - 1;

                while (z >= 0 && nums[z] > keyValue)
                {
                    nums[z + 1] = nums[z];
                    z = z - 1;
                }

                nums[z + 1] = keyValue;
            }
          
        }

    }
}
