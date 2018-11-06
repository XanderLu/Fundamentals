using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void isPrimeTest()
        {
            Assert.IsTrue(Program.isPrime(7));
        }

        [TestMethod()]
        public void isPrimeTest2()
        {
            Assert.IsFalse(Program.isPrime(10));
        }

        [TestMethod()]
        public void isPrimeTest3()
        {
            Assert.IsFalse(Program.isPrime(235));
        }

        [TestMethod()]
        public void isPrimeTest4()
        {
            Assert.IsFalse(Program.isPrime(55));
        }
    }
}