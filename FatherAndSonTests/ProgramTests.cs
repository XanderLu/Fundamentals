using Microsoft.VisualStudio.TestTools.UnitTesting;
using FatherAndSon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatherAndSon.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void WhatYearTest1()
        {
            Assert.AreEqual(5, Program.WhatYear(35, 15));
        }

        [TestMethod()]
        public void WhatYearTest2()
        {
            Assert.AreEqual(20, Program.WhatYear(26, 3));
        }

        [TestMethod()]
        public void WhatYearTest3()
        {
            Assert.AreEqual(-6, Program.WhatYear(50, 28));
        }

        [TestMethod()]
        public void WhatYearTest4()
        {
            Assert.AreEqual(0, Program.WhatYear(40, 20));
        }


    }
}