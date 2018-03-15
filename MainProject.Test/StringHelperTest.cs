using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainProject.Test
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void Concat_BothNotNull()
        {
            var sut = CreateSystemUnderTest();

            string result = sut.ConcatStrings("Test_", "Test2");

            Assert.AreEqual("Test_Test2", result);
        }

		[TestMethod]
        [TestCategory("A")]
		public void Add_OnlyPositives() //SameName as in other class
		{
			var sut = CreateSystemUnderTest();

			string result = sut.ConcatStrings("1_", "2");

			Assert.AreEqual("1_3", result);
		}

		private StringHelper CreateSystemUnderTest()
        {
            return new StringHelper();
        }
    }
}
