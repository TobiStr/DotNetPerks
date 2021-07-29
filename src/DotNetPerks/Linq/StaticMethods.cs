using System.Collections.Generic;

namespace System.Linq
{
	public static class Extensions
	{
		/// <summary>
		/// Returns an <see cref="IEnumerable{T}"/> from a list of parameters. Shorter than initializing a new array.
		/// </summary>
		public static IEnumerable<T> Of<T>(params T[] elements) =>
			elements;

		/// <summary>
		/// Returns an <see cref="IDictionary{TKey, TValue}"/> from a list of parameters. Shorter than initializing a new dictionary.
		/// </summary>
		public static IDictionary<TKey, TValue> Map<TKey, TValue>(params (TKey, TValue)[] elements)
		   where TKey : notnull
		{
			return elements.ToDictionary(
				keySelector: e => e.Item1,
				elementSelector: e => e.Item2
			);
		}
	}
}