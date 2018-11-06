using Microsoft.VisualStudio.TestTools.UnitTesting;
using oppositeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppositeNumber.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void oppositeNumberTest()
        {
            Assert.AreEqual(-2, Program.oppositeNumber(2));
        }

        [TestMethod()]
        public void oppositeNumberTest2()
        {
            Assert.AreEqual(-573, Program.oppositeNumber(573));
        }


    }
}