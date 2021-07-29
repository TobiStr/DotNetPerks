using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace DotNetPerks.Tests.Async
{
	[TestFixture]
	public class TaskExtensionsTests
	{
		[Test]
		public async Task SelectAsync_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var taskExtensions = new TaskExtensions();
			Task task = null;
			Func selector = null;

			// Act
			var result = await taskExtensions.SelectAsync(
				task,
				selector);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task SelectAsync_StateUnderTest_ExpectedBehavior1()
		{
			// Arrange
			var taskExtensions = new TaskExtensions();
			Task task = null;
			Func selector = null;

			// Act
			var result = await taskExtensions.SelectAsync(
				task,
				selector);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task DoAsync_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var taskExtensions = new TaskExtensions();
			Task task = null;
			Func action = null;

			// Act
			var result = await taskExtensions.DoAsync(
				task,
				action);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task DoAsync_StateUnderTest_ExpectedBehavior1()
		{
			// Arrange
			var taskExtensions = new TaskExtensions();
			Task task = null;
			Action action = null;

			// Act
			var result = await taskExtensions.DoAsync(
				task,
				action);

			// Assert
			Assert.Fail();
		}
	}
}
