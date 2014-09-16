using System;
using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Implements the binary searching technique.
    /// </summary>
    internal class BinarySearcher : ISearcher
    {
        /// <summary>
        /// Implements binary search on the given sorted list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The sorted list in which search should be performed.</param>
        /// <param name="item">The item to be searched.</param>
        /// <returns>True if item is found, else false.</returns>
        public bool Search<T>(List<T> list, T item) where T : IComparable<T>
        {
            // Step 1: Sort
            new MergeSorter().Sort(list);

            // Step 2: Search
            return list != null && BinarySearch(list, item, 0, list.Count-1);
        }

        /// <summary>
        /// Performs binary search on the given sorted list between indices.
        /// </summary>
        /// <typeparam name="T">The type of value in the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item searched for.</param>
        /// <param name="start">The start index.</param>
        /// <param name="end">The end index.</param>
        /// <returns>True if item is found, else false.</returns>
        private bool BinarySearch<T>(List<T> list, T item, int start, int end) where T: IComparable<T>
        {
            if (list == null || end < start) return false;
            if (start == end)
            {
                return list[start].CompareTo(item) == 0;
            }

            var middle = (end + start)/2;
            if (item.CompareTo(list[middle]) < 0) return BinarySearch<T>(list, item, start, middle - 1);
            if (item.CompareTo(list[middle]) > 0) return BinarySearch<T>(list, item, middle + 1, end);
            return true;
        }
    }
}
