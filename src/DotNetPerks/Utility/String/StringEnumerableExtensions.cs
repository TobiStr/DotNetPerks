using System.Collections.Generic;

namespace System.Linq
{
	public static class StringEnumerableExtensions
	{
		public static string Join(this IEnumerable<string> strings, string separator)
			=> string.Join(separator, strings);
	}
}