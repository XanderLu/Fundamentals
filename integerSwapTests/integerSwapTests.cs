using Microsoft.VisualStudio.TestTools.UnitTesting;
using integerSwap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace integerSwap.Tests
{
    [TestClass()]
    public class integerSwapTests
    {
        [TestMethod()]
        public void IntSwapTest1()
        {
            Assert.AreEqual("2,3", integerSwap.IntSwap(3, 2));
        }

        [TestMethod()]
        public void IntSwapTest2()
        {
            Assert.AreEqual("-2,3", integerSwap.IntSwap(3, -2));
        }
        [TestMethod()]
        public void IntSwapTest3()
        {
            Assert.AreEqual("2,-3", integerSwap.IntSwap(-3, 2));
        }
        [TestMethod()]
        public void IntSwapTest4()
        {
            Assert.AreEqual("0,356", integerSwap.IntSwap(356, 0));
        }

        [TestMethod()]
        public void IntSwapTest5()
        {
            Assert.AreEqual("366,366", integerSwap.IntSwap(366, 366));
        }

    }
}