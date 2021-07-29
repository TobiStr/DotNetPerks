using NUnit.Framework;
using System;
using System.Linq;

namespace DotNetPerks.Tests.Linq
{
	[TestFixture]
	public class ExtensionsTests
	{
		[Test]
		public void Of_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var extensions = new Extensions();
			T[] elements = null;

			// Act
			var result = extensions.Of(
				elements);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Map_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var extensions = new Extensions();
			(TKey, TValue)[] elements = null;

			// Act
			var result = extensions.Map(
				elements);

			// Assert
			Assert.Fail();
		}
	}
}
