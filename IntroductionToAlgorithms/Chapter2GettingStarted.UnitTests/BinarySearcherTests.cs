using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted.UnitTests
{
    /// <summary>
    /// Tests the <see cref="BinarySearcher"/> class.
    /// </summary>
    [TestClass]
    public class BinarySearcherTests
    {
        /// <summary>
        /// Tests the <see cref="BinarySearcher.Search{T}"/> method
        /// when an null argument is passed.
        /// </summary>
        [TestMethod]
        public void TestNullList()
        {
            var searcher = new BinarySearcher();
            var output = searcher.Search(null, 1);
            Assert.IsFalse(output);
        }

        /// <summary>
        /// Tests the <see cref="BinarySearcher.Search{T}"/> method
        /// when an empty list is passed.
        /// </summary>
        [TestMethod]
        public void TestEmptyList()
        {
            var searcher = new BinarySearcher();
            var output = searcher.Search(new List<int> { }, 1);
            Assert.IsFalse(output);
        }

        /// <summary>
        /// Tests the <see cref="BinarySearcher.Search{T}"/> method
        /// when an proper list is passed.
        /// </summary>
        [TestMethod]
        public void TestWhenElementNotPresent()
        {
            var searcher = new BinarySearcher();
            var output = searcher.Search(new List<int> { 3, 2, 1, 9, 7 }, 6);
            Assert.IsFalse(output);
        }

        /// <summary>
        /// Tests the <see cref="BinarySearcher.Search{T}"/> method
        /// when an proper list is passed.
        /// </summary>
        [TestMethod]
        public void TestWhenElementPresent()
        {
            var searcher = new BinarySearcher();
            var output = searcher.Search(new List<int> { 3, 2, 1, 9, 7 }, 1);
            Assert.IsTrue(output);
        }
    }
}
