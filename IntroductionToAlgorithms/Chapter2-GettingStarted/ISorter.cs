using System;
using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Defines the methods to be implemented by a sorting technique.
    /// </summary>
    internal interface ISorter
    {
        /// <summary>
        /// Performs sorting on the given items.
        /// </summary>
        /// <param name="input">
        /// The input list of items.
        /// </param>
        void Sort<T>(List<T> input) where T : IComparable<T>;
    }
}
