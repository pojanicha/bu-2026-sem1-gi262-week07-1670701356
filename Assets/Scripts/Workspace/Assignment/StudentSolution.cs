using NUnit.Framework;
using System;
using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            // ...

            for (int i = 0; i < array.Length; i++)
            { 

                if (array[i] == target)
                {
                    index = i;
                    break;
                }

            }

            if (index == -1)
            { 
                Debug.Log("File not Found!");


            }


            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...

            for (int i = 0; i < array.GetLength(0); i++)
            { 
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    if (array[i, j] == target)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1 && col != -1)
                {
                    break;
                }



            }

            // ...

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            int left = 0;
            int right = array.Length - 1;


            // Your code here ...

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }
            }



            // ...

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    lastIndex = i;
                }
            }

            if (firstIndex == -1)
            {
                return new int[] { -1 };
            }
            else
            {
                return new int[] { firstIndex, lastIndex };
            }


        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int max = -1;
            bool found = false;

            for (int i = 0; i< array.Length; i++)
                            {
                if (array[i] < target)
                {
                    if (!found || array[i] > max)
                    {
                        max = array[i];
                        found = true;
                    }
                }
            }

            if (!found)
            {
                return -1;
            }
            else
            {
                return max;
            }

        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
           List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }
            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
