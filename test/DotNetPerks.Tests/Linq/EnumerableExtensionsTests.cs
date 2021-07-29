using NUnit.Framework;
using System;
using System.Linq;

namespace DotNetPerks.Tests.Linq
{
	[TestFixture]
	public class EnumerableExtensionsTests
	{
		[Test]
		public void DistinctBy_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var enumerableExtensions = new EnumerableExtensions();
			IEnumerable source = null;
			Func keySelector = null;

			// Act
			var result = enumerableExtensions.DistinctBy(
				source,
				keySelector);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Do_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var enumerableExtensions = new EnumerableExtensions();
			IEnumerable source = null;
			Action action = null;

			// Act
			var result = enumerableExtensions.Do(
				source,
				action);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Choose_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var enumerableExtensions = new EnumerableExtensions();
			IEnumerable source = null;

			// Act
			var result = enumerableExtensions.Choose(
				source);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Concat_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var enumerableExtensions = new EnumerableExtensions();
			IEnumerable source = null;
			IEnumerable<T>[] sequences = null;

			// Act
			var result = enumerableExtensions.Concat(
				source,
				sequences);

			// Assert
			Assert.Fail();
		}
	}
}
