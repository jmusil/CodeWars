using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KataTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("", Kata.Kata.Order(""));
        }

        [TestMethod]
        public void GetNumberFromStringReturnsCorrectNumber()
        {
            Assert.AreEqual(1, Kata.Kata.GetNumberFromString("Ah1oj"));
        }
    }
}
