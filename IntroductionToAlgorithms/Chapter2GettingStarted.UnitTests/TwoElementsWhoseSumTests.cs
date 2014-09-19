using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.techsnippets.IntroductionToAlgorithms.Chapter2GettingStarted.UnitTests
{
    /// <summary>
    /// Unit tests for the <see cref="TwoElementsWhoseSum"/> class.
    /// </summary>
    [TestClass]
    public class TwoElementsWhoseSumTests
    {
        /// <summary>
        /// Test when list is null.
        /// </summary>
        [TestMethod]
        public void TestWhenListIsNull()
        {
            var target = new TwoElementsWhoseSum();
            Assert.IsFalse(target.SumExists(null, 10));
        }

        /// <summary>
        /// Test when list is empty.
        /// </summary>
        [TestMethod]
        public void TestWhenListIsEmpty()
        {
            var target = new TwoElementsWhoseSum();
            Assert.IsFalse(target.SumExists(new List<int>(), 10));
        }

        /// <summary>
        /// Test when list does not contain two elements whose sum is the given value.
        /// </summary>
        [TestMethod]
        public void TestWhenNotPresent()
        {
            var target = new TwoElementsWhoseSum();
            var list = new List<int> {3, 2, 1, 9, 7, 11, 2};
            Assert.IsFalse(target.SumExists(list, 6));
        }

        /// <summary>
        /// Test when list contains two elements whose sum is the given value.
        /// </summary>
        [TestMethod]
        public void TestWhenPresent()
        {
            var target = new TwoElementsWhoseSum();
            var list = new List<int> { 3, 2, 1, 9, 7, 11, 2 };
            Assert.IsTrue(target.SumExists(list, 10));
        }
    }
}
