using NUnit.Framework;
using System;

namespace DotNetPerks.Tests.Utility.String
{
	[TestFixture]
	public class StringExtensionsTests
	{
		[Test]
		public void IsNullOrEmpty_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var stringExtensions = new StringExtensions();
			string input = null;

			// Act
			var result = stringExtensions.IsNullOrEmpty(
				input);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void IsNullOrWhiteSpace_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var stringExtensions = new StringExtensions();
			string input = null;

			// Act
			var result = stringExtensions.IsNullOrWhiteSpace(
				input);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Equals_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var stringExtensions = new StringExtensions();
			string instance = null;
			string value = null;

			// Act
			var result = stringExtensions.Equals(
				instance,
				value);

			// Assert
			Assert.Fail();
		}
	}
}
