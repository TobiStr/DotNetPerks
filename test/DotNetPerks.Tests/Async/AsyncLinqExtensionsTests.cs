using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetPerks.Tests.Async
{
	[TestFixture]
	public class AsyncLinqExtensionsTests
	{
		[Test]
		public async Task AnyAsyncTest()
		{
			// Arrange
			var enumerable = new[]
			{
				1,2,3,4,5
			};

			// Act
			var result = await asyncLinqExtensions.AnyAsync(
				source,
				asyncPredicate);

			// Assert
			Assert.Fail();
		}

		[Test]
		public async Task FirstOrDefaultAsyncTest()
		{
			// Arrange
			var asyncLinqExtensions = new AsyncLinqExtensions();
			IEnumerable source = null;
			Func asyncPredicate = null;
			T? @default = default(T);

			// Act
			var result = await asyncLinqExtensions.FirstOrDefaultAsync(
				source,
				asyncPredicate,
				@default);

			// Assert
			Assert.Fail();
		}
	}
}