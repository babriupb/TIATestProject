using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace MainProject.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void FakeInitialize()
        {
            Thread.Sleep(2500);
        }

        [TestMethod]
        public void Add_OnlyPositives()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(12, 14);

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegatvie()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(12, -14);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Add_OnlyNegative()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(-12, -14);

            Assert.AreEqual(-26, result);
        }


        [TestMethod]
        public void Substract_OnlyPositives()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Substract(14, 12);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Substract_PositiveAndNegative()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Substract(12, -14);

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void Substract_OnlyNegative()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Substract(-12, -14);

            Assert.AreEqual(2, result);
        }

        private Calculator CreateSystemUnderTest()
        {
            return new Calculator();
        }
    }
}
