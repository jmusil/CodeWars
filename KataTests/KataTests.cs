using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KataTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void EmptyStringReturnsEMptyString()
        {
            Assert.AreEqual("", Kata.Kata.Order(""));
        }

        [TestMethod]
        public void GetNumberFromStringReturnsCorrectNumber()
        {
            Assert.AreEqual(1, Kata.Kata.GetNumberFromString("Ah1oj"));
        }

        [TestMethod]
        public void ReturnsCorrectlyOrderedWords()
        {
            Assert.AreEqual("Slav1a naz2dar vyle3tu", Kata.Kata.Order("naz2dar Slav1a vyle3tu"));
        }
    }
}
