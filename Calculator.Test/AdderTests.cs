using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
	[TestClass]
	public class AdderTests
	{
		[TestMethod]
		public void AddFloatsTwoNegativesTest()
		{
			var sut = new Adder();
			double result = sut.AddFloats(-1, -2);
			Assert.AreEqual(-3, result);
		}
		[TestMethod]
		public void AddIntsTwoPositivesTest()
		{
			var sut = new Adder();
			double result = sut.AddInts(6, 7);
			Assert.AreEqual(13, result);
		}
		[TestMethod]
		public void AddIntsTwoPositivesTest2()
		{
			var sut = new Adder();
			double result = sut.AddInts(2, 4);
			Assert.AreEqual(6, result);
		}
	}
}
