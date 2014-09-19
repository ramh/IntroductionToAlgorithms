using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Class that contains program to solve:
    /// Exercise: 2.3-7
    /// Page: 37
    /// </summary>
    internal sealed class TwoElementsWhoseSum
    {
        /// <summary>
        /// Checks if the given list contains two elements whose sum is <paramref name="sum"/>.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="sum">The sum.</param>
        /// <returns>True, if present, false otherwise.</returns>
        internal bool SumExists(List<int> list, int sum)
        {
            if (list == null || list.Count <= 1)
            {
                return false;
            }

            // Sort
            new MergeSorter().Sort(list);

            // Right and left pointer based check
            var left = 0;
            var right = list.Count - 1;

            while (left < right)
            {
                var total = list[left] + list[right];
                if (total < sum)
                    left++;
                else if (total > sum)
                    right--;
                else
                    return true;
            }

            return false;
        }
    }
}
