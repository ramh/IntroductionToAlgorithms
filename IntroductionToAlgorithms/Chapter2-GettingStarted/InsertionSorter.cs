using System;
using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Class that performs insertion sort
    /// </summary>
    internal sealed class InsertionSorter : ISorter
    {
        /// <summary>
        /// Performs insertion sort on the input items in ascending order.
        /// </summary>
        /// <param name="input">The elements to be sorted.</param>
        public void Sort<T>(List<T> input) where T : IComparable<T>
        {
            if (input == null)
            {
                return;
            }

            for (var i = 1; i < input.Count; i++)
            {
                var j = i - 1;
                var key = input[i];
                while (j >= 0 && input[j].CompareTo(key) > 0)
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j + 1] = key;
            }
        }
    }
}
