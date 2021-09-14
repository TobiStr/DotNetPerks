using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerks.Tests.Utility
{
	internal static class TestEnumerableProvider
	{
		public static IEnumerable<int> GetTestEnumerable()
		{
			return Enumerable.Range(0, 100);
		}

		public static IEnumerable<Task<int>> GetTestAsyncEnumerable()
		{
			return Enumerable.Range(0, 100)
				.Select(i => Task.FromResult(i));
		}
	}
}