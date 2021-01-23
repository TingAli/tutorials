using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OurClassLibrary.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void VerifyAddTen()
		{
			var value = 2102;

			var result = OurClassLibrary.Class1.AddTen(value);

			Assert.AreEqual(2112, result);
		}
	}
}
