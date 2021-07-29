using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Linq
{
	public static class AsyncLinqExtensions
	{
		public static async Task<bool> AnyAsync<T>(
			this IEnumerable<T> source,
			Func<T, Task<bool>> asyncPredicate
		)
		{
			foreach (var task in source.Select(asyncPredicate))
				if (await task) return true;

			return false;
		}

		public static async Task<T?> FirstOrDefaultAsync<T>(
			this IEnumerable<T> source,
			Func<T, Task<bool>> asyncPredicate,
			T? @default = default
		)
		{
			if (source is null)
				throw new ArgumentNullException(nameof(source));

			if (asyncPredicate is null)
				throw new ArgumentNullException(nameof(asyncPredicate));

			foreach (var item in source)
				if (await asyncPredicate(item)) return item;

			return @default;
		}
	}
}