using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test_Lab_Work;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationsConstructorTest()
        {
            Calculations calcObject = new Calculations();
        }

        [TestMethod]
        public void AddNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(3, 4);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, result);
        }
    }
}