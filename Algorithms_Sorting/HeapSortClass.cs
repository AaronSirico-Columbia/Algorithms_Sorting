/// <summary>
/// Heap Sort Algorithm
/// Explanation: Heapsort is a comparison-based sort-in-place algorithm that takes no extra storage. 
/// It is often described as an improved selection sort.
/// Asymptotic Notation:
/// Best case = O(n log n)
/// Worst case = O(n log n)
/// Psuedo Code:
///START
///  Start Method
///   HeapSort(nums)
///   
///    ArrayLength = length(nums)
///    
///    for i from ArrayLength / 2 - 1 down to 0
///        Heap(nums, ArrayLength, i)
///   
///    for i from ArrayLength - 1 down to 1
///       
///        temp = nums[0]
///        nums[0] = nums[i]
///        nums[i] = temp
///       
///        Heap(nums, i, 0)
///  End Method
///  Start Method
///   Heap(nums, n, i)
///    largest = i
///    leftChild = 2 * i + 1
///    rightChild = 2 * i + 2
///   
///    if leftChild < n and nums[leftChild] > nums[largest]
///        largest = leftChild
///   
///    if rightChild < n and nums[rightChild] > nums[largest]
///        largest = rightChild
///    
///    if largest != i
///        swap(nums[i], nums[largest])
///        
///        Heap(nums, n, largest)
///  End Method
///END
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Sorting
{
    public class HeapSortClass
    {
        public string? FilePath;
        public int[]? nums;

        public void SetUpHeap(int[] nums)
        {
            int ArrayLength = nums.Length;

            for (int i = ArrayLength / 2 - 1; i >= 0; i--)
            {
                Heap(nums, ArrayLength, i);
            }

            for (int i = ArrayLength - 1; i > 0; i--)
            {
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;

                Heap(nums, i, 0);
            }
        }
        
        public void Heap(int[] nums, int x, int y)
        {
            int largest = y;
            int leftChild = 2 * y + 1;
            int rightChild = 2 * y + 2;

            if (leftChild < x && nums[leftChild] > nums[largest])
            {
                largest = leftChild;
            }

            if (rightChild < x && nums[rightChild] > nums[largest])
            {
                largest = rightChild;
            }

            if (largest != y)
            {
                int swap = nums[y];
                nums[y] = nums[largest];
                nums[largest] = swap;

                Heap(nums, x, largest);
            }
        }
    }
}
