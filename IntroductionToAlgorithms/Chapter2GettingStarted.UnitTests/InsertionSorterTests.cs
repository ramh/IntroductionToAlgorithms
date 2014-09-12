using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted.UnitTests
{
    /// <summary>
    /// Tests the <see cref="InsertionSorter"/> class.
    /// </summary>
    [TestClass]
    public class InsertionSorterTests
    {
        /// <summary>
        /// Tests the <see cref="InsertionSorter.Sort{T}"/> method
        /// when an null argument is passed.
        /// </summary>
        [TestMethod]
        public void TestNullList()
        {
            var insertionSorter = new InsertionSorter();
            insertionSorter.Sort<int>(null);
        }

        /// <summary>
        /// Tests the <see cref="InsertionSorter.Sort{T}"/> method
        /// when an empty list is passed.
        /// </summary>
        [TestMethod]
        public void TestEmptyList()
        {
            var insertionSorter = new InsertionSorter();
            var list = new List<int> { };
            insertionSorter.Sort(list);
            Assert.AreEqual(0, list.Count);
        }

        /// <summary>
        /// Tests the <see cref="InsertionSorter.Sort{T}"/> method
        /// when an proper list is passed.
        /// </summary>
        [TestMethod]
        public void TestProperList()
        {
            var insertionSorter = new InsertionSorter();
            var list = new List<int> { 3, 2, 1, 9, 7 };
            insertionSorter.Sort(list);
            Assert.AreEqual(5, list.Count);
            Assert.IsTrue(list.SequenceEqual(new List<int> { 1, 2, 3, 7, 9 }));
        }
    }
}
