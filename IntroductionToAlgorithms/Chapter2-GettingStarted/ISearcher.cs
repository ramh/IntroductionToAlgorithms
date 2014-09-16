using System;
using System.Collections.Generic;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted
{
    /// <summary>
    /// Defines methods to implement the searching technique.
    /// </summary>
    internal interface ISearcher
    {
        /// <summary>
        /// Performs searching on the given items.
        /// </summary>
        /// <param name="list">
        /// The input list of items.
        /// </param>
        /// <param name="item">The item to search.</param>
        /// <returns>True if item is found, else false.
        /// </returns>
        bool Search<T>(List<T> list, T item) where T : IComparable<T>;
    }
}
