using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainProject.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_OnlyPositives()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(12, 14);

            Assert.AreEqual(26, result);
        }

        private Calculator CreateSystemUnderTest()
        {
            return new Calculator();
        }
    }
}
