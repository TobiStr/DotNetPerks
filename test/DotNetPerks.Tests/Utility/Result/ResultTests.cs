using NUnit.Framework;
using System;

namespace DotNetPerks.Tests.Utility.Result
{
	[TestFixture]
	public class ResultTests
	{
		[Test]
		public void Ok_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var result = new Result(TODO, TODO);

			// Act
			var result = result.Ok();

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Error_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var result = new Result(TODO, TODO);
			string message = null;

			// Act
			var result = result.Error(
				message);

			// Assert
			Assert.Fail();
		}
	}
}
