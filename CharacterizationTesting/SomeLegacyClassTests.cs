using NUnit.Framework;

namespace CharacterizationTesting
{
	public class SomeClassTests
	{
		// Instructions:
		// 1. Explore and lock down the behavior of SomeLegacyClass by writing tests. This is called characterization testing.
		// 2. Clean up the code.
		// 3. Add a new fitting method to SomeLegacyClass.
		
		[Test]
		public void SomeTest()
		{
			var x = new SomeLegacyClass();
			Assert.Pass();
		}
	}
}