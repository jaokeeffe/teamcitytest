using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityTestConsoleApp;

namespace TeamCityTestConsoleAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(5, c.Add(2, 3));
        }
        [TestMethod]
        public void SubtractTest()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(5, c.Subtract(8,3));
        }
    }
}
