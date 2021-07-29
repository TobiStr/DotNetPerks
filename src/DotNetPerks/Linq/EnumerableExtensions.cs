using System.Collections.Generic;

namespace System.Linq
{
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Returns distinct elements from a sequence by using the <paramref name="keySelector"/>
		/// to compare values.
		/// </summary>
		/// <typeparam name="TSource">The type of the elements of source.</typeparam>
		/// <typeparam name="TKey">The type of the key for the <paramref name="keySelector"/></typeparam>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <param name="keySelector">The selector function to get the compare value.</param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> that contains distinct elements from
		/// the source sequence.
		/// </returns>
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
		   this IEnumerable<TSource> source,
		   Func<TSource, TKey> keySelector
		)
		{
			if (source is null)
				throw new ArgumentNullException(nameof(source));

			if (keySelector is null)
				throw new ArgumentNullException(nameof(keySelector));

			HashSet<TKey> distinctKeys = new HashSet<TKey>();
			return source.Where(element => distinctKeys.Add(keySelector(element)));
		}

		/// <summary>
		/// Executes an action on each element of a sequence.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="action"></param>
		/// <returns></returns>
		public static IEnumerable<TSource> Do<TSource>(
			this IEnumerable<TSource> source,
			Action<TSource> action
		)
		{
			foreach (var item in source)
			{
				action(item);
				yield return item;
			}
		}

		/// <summary>
		/// Returns elements that are not null.
		/// </summary>
		public static IEnumerable<T> Choose<T>(this IEnumerable<T?> source) =>
			source.Where(e => e != null).Select(e => e!);

		/// <summary>
		/// Concatenates multiple sequences at once.
		/// </summary>
		public static IEnumerable<T> Concat<T>(this IEnumerable<T> source, params IEnumerable<T>[] sequences)
			=> source.Concat(sequences.SelectMany(s => s));
	}
}