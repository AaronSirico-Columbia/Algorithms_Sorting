namespace Algorithms_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort
            BubbleSortClass BubbleClass = new BubbleSortClass();
            BubbleClass.SetUpBubbleSort(Utility.SetArray());
            
            //Insertion Sort
            InsertionSortClass InsertClass = new InsertionSortClass();
            InsertClass.SetUpInsertionSort(Utility.SetArray());

            //Selection Sort
            SelectionSortClass SelectClass = new SelectionSortClass();
            SelectClass.SetUpSelectionSort(Utility.SetArray());

            //Heap Sort
            HeapSortClass HeapClass = new HeapSortClass();
            HeapClass.SetUpHeap(Utility.SetArray());

            //Quick Sort
            QuickSortClass QuickClass = new QuickSortClass();
            QuickClass.SetUpQuickSort(Utility.SetArray(), 0, Utility.SetArray().Length - 1);

            //Merge Sort
            MergeSortClass MergeClass = new MergeSortClass();
            MergeClass.SetUpMergeSort(Utility.SetArray());
        }
    }
}