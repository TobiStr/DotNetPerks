using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetPerks.Tests.Async
{
	[TestFixture]
	public class TaskSequenceExtensionsTests
	{
		[Test]
		public async Task WhenAllSequentialAsync_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var taskSequenceExtensions = new TaskSequenceExtensions();
			IEnumerable tasks = null;

			// Act
			var result = await taskSequenceExtensions.WhenAllSequentialAsync(
				tasks);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task WhenAllSequentialAsync_StateUnderTest_ExpectedBehavior1()
		{
			// Arrange
			var taskSequenceExtensions = new TaskSequenceExtensions();
			IEnumerable tasks = null;

			// Act
			await taskSequenceExtensions.WhenAllSequentialAsync(
				tasks);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task WhenAllAsync_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var taskSequenceExtensions = new TaskSequenceExtensions();
			IEnumerable tasks = null;

			// Act
			var result = await taskSequenceExtensions.WhenAllAsync(
				tasks);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task WhenAllAsync_StateUnderTest_ExpectedBehavior1()
		{
			// Arrange
			var taskSequenceExtensions = new TaskSequenceExtensions();
			IEnumerable tasks = null;

			// Act
			await taskSequenceExtensions.WhenAllAsync(
				tasks);

			// Assert
			Assert.Fail();
		}

		[Test]
		public void Select_StateUnderTest_ExpectedBehavior()
		{
			// Arrange
			var taskSequenceExtensions = new TaskSequenceExtensions();
			IEnumerable tasks = null;
			Func selector = null;

			// Act
			var result = taskSequenceExtensions.Select(
				tasks,
				selector);

			// Assert
			Assert.Fail();
		}
	}
}
