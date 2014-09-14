using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted.UnitTests
{
    /// <summary>
    /// Tests the <see cref="MergeSorter"/> class.
    /// </summary>
    [TestClass]
    public class MergeSorterTests
    {
        /// <summary>
        /// Tests the <see cref="MergeSorter.Sort{T}"/> method
        /// when an null argument is passed.
        /// </summary>
        [TestMethod]
        public void TestNullList()
        {
            var sorter = new MergeSorter();
            sorter.Sort<int>(null);
        }

        /// <summary>
        /// Tests the <see cref="MergeSorter.Sort{T}"/> method
        /// when an empty list is passed.
        /// </summary>
        [TestMethod]
        public void TestEmptyList()
        {
            var sorter = new MergeSorter();
            var list = new List<int> { };
            sorter.Sort(list);
            Assert.AreEqual(0, list.Count);
        }

        /// <summary>
        /// Tests the <see cref="MergeSorter.Sort{T}"/> method
        /// when an proper list is passed.
        /// </summary>
        [TestMethod]
        public void TestProperList()
        {
            var sorter = new MergeSorter();
            var list = new List<int> { 3, 2, 1, 9, 7 };
            sorter.Sort(list);
            Assert.AreEqual(5, list.Count);
            Assert.IsTrue(list.SequenceEqual(new List<int> { 1, 2, 3, 7, 9 }));
        }
    }
}
