using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataStructures.BIT;

namespace UnitTests {
    [TestClass]
    public class Tests {
        [TestMethod]
        public void BIT_Tests() {
            List<int> list = new List<int> { 1, 7, 3, 0, 5, 8, 3, 2, 6, 2, 1, 1, 4, 5 };
            BinaryIndexedTree bit = new BinaryIndexedTree(list);

            Assert.IsNotNull(bit);
            Assert.AreEqual(43, bit.SumTo(12));
            Assert.AreEqual(27, bit.SumTo(6));
            Assert.AreEqual(23, bit.SumRange(1, 5));

            bit.Update(4, 2);

            Assert.AreEqual(45, bit.SumTo(12));
            Assert.AreEqual(29, bit.SumTo(6));
            Assert.AreEqual(25, bit.SumRange(1, 5));
        }
    }
}
