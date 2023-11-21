/// <summary>
/// Selection Sort Algorithm
/// Explanation: Selection sort is an in-place comparison sorting algorithm. 
/// It is inefficient on large lists, and generally performs worse than insertion sort. 
/// Asymptotic Notation:
/// Best case = O(n^2)
/// Worst case = O(n^2)
/// Psuedo Code:
/// START
/// ArrayLength = length(nums)
///  for i from 0 to ArrayLength - 2
///    IndexMin = i
///        for z from i + 1 to ArrayLength - 1
///            if nums[z] < nums[IndexMin]
///                IndexMin = z
///        // Swap the found minimum element with the first element
///        temp = nums[IndexMin]
///        nums[IndexMin] = nums[i]
///        nums[i] = temp
/// END
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Sorting
{
    public class SelectionSortClass
    {
        public string? FilePath;


        public void SetUpSelectionSort(int[] nums)
        {
            int ArrayLength = nums.Length;

            for (int i = 0; i < ArrayLength - 1; i++)
            {
                int IndexMin = i;
                for (int z = i + 1; z < ArrayLength; z++)
                {
                    if (nums[z] < nums[IndexMin])
                    {
                        IndexMin = z;
                    }
                }
                int temp = nums[IndexMin];
                nums[IndexMin] = nums[i];
                nums[i] = temp;
            }
        }

    }
}
