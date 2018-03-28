using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace MainProject.Test
{
    [TestClass]
    public class CalculatorTest
    {
		public TestContext TestContext { get; set; }

        [TestInitialize]
        public void FakeInitialize()
        {
            Thread.Sleep(500);
        }

        [TestMethod]
        [TestCategory("A")]
        [TestCategory("C")]
        public void Add_OnlyPositives()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(12, 14);

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        [TestCategory("B")]
        public void Add_PositiveAndNegatvie()
        {
            var sut = CreateSystemUnderTest();

            double result = sut.Add(12, -14);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        [TestCategory("C")]
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

		[TestMethod]
		[DeploymentItem("DataDrivenTestExample.xml")]
		[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
				   "|DataDirectory|\\DataDrivenTestExample.xml",
				   "Row",
					DataAccessMethod.Sequential)]
		public void DataDrivenTestExampleTest()
		{
			int a1 = int.Parse((string)TestContext.DataRow["A1"]);
			int a2 = int.Parse((string)TestContext.DataRow["A2"]);
			int result = int.Parse((string)TestContext.DataRow["Result"]);

			var sut = CreateSystemUnderTest();

			var actualResult = sut.Add(a1, a2);

			Assert.AreEqual(result, actualResult);
		}

		private Calculator CreateSystemUnderTest()
        {
            return new Calculator();
        }
    }
}
