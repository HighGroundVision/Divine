using System.Collections.Generic;
using System.Linq;
using HGV.Divine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HGV.Divine.Tests
{
    [TestClass]
    public class RankSorterTest
    {
        [TestMethod]
        public void SortAlreadySortedTest()
        {
            IEnumerable<string> people = new[] { "One", "Two", "Three" };
            int[] ranks = new[] { 1, 2, 3 };

            RankSorter.Sort(ref people, ref ranks);

            CollectionAssert.AreEqual(new[] { "One", "Two", "Three" }, people.ToArray());
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ranks);
        }

        [TestMethod]
        public void SortUnsortedTest()
        {
            IEnumerable<string> people = new[] { "Five", "Two1", "Two2", "One", "Four" };
            int[] ranks = new[] { 5, 2, 2, 1, 4 };

            RankSorter.Sort(ref people, ref ranks);

            CollectionAssert.AreEqual(new[] { "One", "Two1", "Two2", "Four", "Five" }, people.ToArray());
            CollectionAssert.AreEqual(new[] { 1, 2, 2, 4, 5 }, ranks);
        }
    }
}