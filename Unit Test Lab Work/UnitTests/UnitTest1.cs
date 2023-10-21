using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test_Lab_Work;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        #region FirstHalfOfSheet
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

        [TestMethod]
        public void AddNumbersTest2()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(5, 9);
            int expectedResult = 14;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MultiplyNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Multiply(3, 4);
            int expectedResult = 12;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Subtract(32, 4);
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DivideByZeroTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Divide(32, 0);
        }
        #endregion
    }
}