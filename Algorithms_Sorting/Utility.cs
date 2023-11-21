using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Algorithms_Sorting
{
    public static class Utility
    {
        public static string Path = ($"{Directory.GetCurrentDirectory()}\\Files");
        public static string FilePath = $"{Path}\\scores.txt";
        public static int ArraySize;

        public static int[] ConvertStringArrayToIntArray(string[] stringArray)
        {

            int[] intArray = new int[stringArray.Length];


            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
                ArraySize++;
            }
            return intArray;
        }

        public static int[] SetArray()
        {
            FilePath = Utility.FilePath;

            string[] lines = File.ReadAllLines(FilePath);

            int[] nums;

            return nums = Utility.ConvertStringArrayToIntArray(lines);
        }

        //public void PrintArray(int[] nums)
        //{
        //    foreach (int num in nums)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
