using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Class that perform merge sort.
    /// </summary>
    internal sealed class MergeSorter : ISorter
    {
        /// <summary>
        /// Performs merge sort on the given list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="input">The input list</param>
        public void Sort<T>(List<T> input) where T : IComparable<T>
        {
            if (input == null)
            {
                return;
            }

            MergeSort(input, 0, input.Count - 1);
        }

        /// <summary>
        /// Performs merge sort on list between and including the given indices.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="input">The input list.</param>
        /// <param name="p">The begin index.</param>
        /// <param name="r">The end index.</param>
        private void MergeSort<T>(List<T> input, int p, int r) where T: IComparable<T>
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(input, p, q);
                MergeSort(input, q + 1, r);
                Merge(input, p, q, r);
            }
        }

        /// <summary>
        /// Merges a list that is sorted separately into a single sorted list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="input">The input list.</param>
        /// <param name="p">The begin index if sorted first half.</param>
        /// <param name="q">The end index of sorted first half.</param>
        /// <param name="r">The end index of sorted second half.</param>
        /// <remarks>
        /// The begin index of sorted second half is <paramref name="q"/> + 1.
        /// </remarks>
        private void Merge<T>(List<T> input, int p, int q, int r) where T: IComparable<T>
        {
            var n1 = q - p + 1;
            var n2 = r - q;
            var left = new List<T>(n1);
            var right = new List<T>(n2);

            for (var i = 0; i < n1; i++) left.Add(input[p + i]);
            for (var j = 0; j < n2; j++) right.Add(input[q + j + 1]);

            var x = 0;
            var y = 0;
            for (var k = p; k <= r; k++)
            {
                if (y >= n2 || (x < n1 && left[x].CompareTo(right[y]) <= 0))
                {
                    input[k] = left[x];
                    x++;
                }
                else
                {
                    input[k] = right[y];
                    y++;
                }
            }
        }
    }
}
