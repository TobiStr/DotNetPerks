using NUnit.Framework;
using System;

namespace DotNetPerks.Tests.Utility.Disposable
{
	[TestFixture]
	public class DisposableTests
	{
		[Test]
		public void Create_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var disposable = new Disposable(TODO);
			Action dispose = null;

			// Act
			var result = disposable.Create(
				dispose);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Add_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var disposable = new Disposable(TODO);
			Action disposeAction = null;

			// Act
			disposable.Add(
				disposeAction);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Dispose_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var disposable = new Disposable(TODO);

			// Act
			disposable.Dispose();

			// Assert
			Assert.Fail();
		}
	}
}
