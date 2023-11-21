using System.Reflection;
using System;
/// <summary>
/// Merge Sort Algorithm
/// Explanation:  It works by dividing the input array into two halves, recursively sorting each half, and then merging the sorted halves to produce a fully sorted array. 
/// Merge Sort is a stable sort, meaning that it preserves the relative order of equal elements.
/// Asymptotic Notation:
/// Best case = O(n log n)
/// Worst case = O(n log n)
/// Psuedo Code:
///START
/// Start Method
///  SetUpMergeSort(nums)
///    ArrayLength = length(nums)
///    if ArrayLength > 1
///        middle = ArrayLength / 2
///        // Create left and right subarrays
///        left = new array of length middle
///        right = new array of length(ArrayLength - middle)
///        // Populate left and right subarrays
///        for i from 0 to middle - 1
///            left[i] = nums[i]
///        for z from 0 to(ArrayLength - middle) - 1
///            right[z] = nums[middle + z]
///        // Recursively set up MergeSort for the left and right subarrays
///        SetUpMergeSort(left)
///        SetUpMergeSort(right)
///        // Merge the sorted left and right subarrays
///        Merge(nums, left, right)
/// Method End
/// Method Start
///  procedure Merge(nums, left, right)
///    a = 0
///    b = 0
///    c = 0
///    // Compare elements from left and right, and merge them into nums
///    while a < length(left) and b<length(right)
///        if left[a] <= right[b]
///            nums[c] = left[a]
///            a = a + 1
///        else
///    nums[c] = right[b]
///            b = b + 1
///        c = c + 1
///    // Copy the remaining elements of left and right, if any
///    while a < length(left)
///        nums[c] = left[a]
///        a = a + 1
///        c = c + 1
///    while b < length(right)
///        nums[c] = right[b]
///        b = b + 1
///        c = c + 1
/// End Method
///END
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Sorting
{
    public class MergeSortClass
    {
        public void SetUpMergeSort(int[] nums)
        {
            int ArrayLength = nums.Length;

            if (ArrayLength > 1)
            {
                int middle = ArrayLength / 2;

                int[] left = new int[middle];
                int[] right = new int[ArrayLength - middle];

                for (int i = 0; i < middle; i++)
                {
                    left[i] = nums[i];
                }

                for (int z = 0;  z < ArrayLength - middle;  z++)
                {
                    right[z] = nums[middle + z];
                }

                SetUpMergeSort(left);
                SetUpMergeSort(right);

                Merge(nums, left, right);
            }
        }


        public void Merge(int[] nums, int[] left, int[] right)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            while (a < left.Length && b < right.Length)
            {
                if (left[a] <= right[b])
                {
                    nums[c] = left[a];
                    a++;
                }
                else
                {
                    nums[c] = right[b];
                    b++;
                }
                c++;
            }

            while (a < left.Length)
            {
                nums[c] = left[a];
                a++;
                c++;
            }

            while (b < right.Length)
            {
                nums[c] = right[b];
                b++;
                c++;
            }
        }

    }
}
