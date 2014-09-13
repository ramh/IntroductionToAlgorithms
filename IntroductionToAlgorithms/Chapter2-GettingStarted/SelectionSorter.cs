using System;
using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Class that performs selection sort.
    /// </summary>
    class SelectionSorter : ISorter
    {
        /// <summary>
        /// Performs selection sort on the given items.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="input">The input list to be sorted.</param>
        public void Sort<T>(List<T> input) where T : IComparable<T>
        {
            if (input == null)
            {
                return;
            }

            for (var i = 0; i < input.Count - 1; i++)
            {
                var small = i;
                for (var j = i + 1; j < input.Count; j++)
                {
                    if (input[j].CompareTo(input[small]) < 0)
                    {
                        small = j;
                    }
                }

                var temp = input[i];
                input[i] = input[small];
                input[small] = temp;
            }
        }
    }
}
