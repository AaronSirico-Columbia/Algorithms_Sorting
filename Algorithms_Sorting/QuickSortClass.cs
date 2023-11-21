/// <summary>
/// Quick Sort Algorithm
/// Explanation:  It is a comparison sort and employs a divide-and-conquer strategy. 
/// The key idea behind QuickSort is to partition the array into two smaller sub-arrays, then recursively sort each sub-array.
/// Asymptotic Notation:
/// Best case = O(n log n)
/// Worst case = O(n^2)
/// Psuedo Code:
///START
///  Start Method
///   SetUpQuickSort(nums, low, high)
///    if low < high
///        IndexPivot = Partition(nums, low, high)    
///        SetUpQuickSort(nums, low, IndexPivot - 1)
///        SetUpQuickSort(nums, IndexPivot + 1, high)
///  End Method
///  Start Method
///  Partition(nums, low, high)
///   pivot = nums[high] // Choose the pivot (often the last element)
///    i = low - 1
///    for z from low to high - 1 
///        if nums[z] <= pivot
///            i = i + 1
///            Swap(nums[i], nums[z])
///    Swap(nums[i + 1], nums[high])
///    return i + 1 // Return the index of the pivot
///  End Method
///  Start Method
///   Swap(a, b)
///    temp = a
///     a = b
///     b = temp
///  End Method
///END
/// </summary>
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Sorting
{
    public class QuickSortClass
    {   
        public void SetUpQuickSort(int[] nums, int low, int high)
        {

            if (low < high)
            {
                int IndexPivot = Partition(nums, low, high);

                SetUpQuickSort(nums, low, IndexPivot - 1);
                SetUpQuickSort(nums, IndexPivot + 1, high);
            }
        }

        public int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];

            int i = low - 1;

            for (int z = low; z <= high - 1; z++)
            {
                if (nums[z] <= pivot)
                {
                    i = i + 1;

                    Swap(ref nums[i], ref nums[z]);
                }
            }

            Swap(ref nums[i + 1], ref nums[high]);

            return i + 1;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


    }
}
