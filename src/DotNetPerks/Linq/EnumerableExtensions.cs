using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Linq
{
	/// <summary>
	/// Extensions for IEnumerables
	/// </summary>
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
		/// Returns elements from a sequence except those elements from a second sequence, where a condition is met.
		/// </summary>
		/// <typeparam name="TSource">The type of the elements of source.</typeparam>
		/// <param name="source">The sequence to remove elements from.</param>
		/// <param name="second">The sequence that holds elements to be removed.</param>
		/// <param name="predicate">The condition, that elements from the second sequence need to fulfill, to be removed from the source sequence.</param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> that contains elements from
		/// the source sequence except those elements from a second sequence, where a condition is met.
		/// </returns>
		public static IEnumerable<TSource> ExceptWhere<TSource>(
			this IEnumerable<TSource> source,
			IEnumerable<TSource> second,
			Func<TSource, bool> predicate
		)
			=> source.Except(second.Where(predicate));

		/// <summary>
		/// Negative Where.
		/// </summary>
		public static IEnumerable<TSource> WhereNot<TSource>(
			this IEnumerable<TSource> source,
			Func<TSource, bool> predicate
		)
			=> source.Where(e => !predicate(e));

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

		/// <summary>
		/// Returns chunks of the source sequence, each containing <paramref name="chunkSize"/> elements.
		/// </summary>
		public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, long chunkSize)
		{
			var list = new List<T>();

			foreach (var item in source)
			{
				list.Add(item);
				if (list.Count >= chunkSize)
				{
					yield return list;
					list.Clear();
				}
			}
			yield return list;
		}

		/// <summary>
		/// Transforms the source sequence and aggregates it.
		/// </summary>
		public static TTarget AggregateTransform<TSource, TTarget>(
			this IEnumerable<TSource> source,
			Func<TSource, TTarget> transform,
			Func<TTarget, TTarget, TTarget> aggregate
		)
		{
			return source
				.Select(transform)
				.Aggregate((a, b) => aggregate(a, b));
		}

		/// <summary>
		/// Applies an action on each element of the source sequence.
		/// </summary>
		public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
		{
			foreach (var item in source)
				action(item);
		}

		/// <summary>
		/// Applies an action on each element and the index of the source sequence.
		/// </summary>
		public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
		{
			int i = 0;
			foreach (var item in source)
			{
				action(item, i);
				i++;
			}
		}

		/// <summary>
		/// Applies a task on each element of the source sequence.
		/// </summary>
		public static async Task ForEach<TSource>(this IEnumerable<TSource> source, Func<TSource, Task> task)
		{
			foreach (var item in source)
				await task(item).ConfigureAwait(false);
		}

		/// <summary>
		/// Applies a task on each element and the index of the source sequence.
		/// </summary>
		public static async Task ForEach<TSource>(this IEnumerable<TSource> source, Func<TSource, int, Task> task)
		{
			int i = 0;
			foreach (var item in source)
			{
				await task(item, i).ConfigureAwait(false);
				i++;
			}
		}

		/// <summary>
		/// Enumerates the sequence.
		/// </summary>
		public static IEnumerable<T> Enumerate<T>(this IEnumerable<T> source)
			=> source.ToArray();

		/// <summary>
		/// Returns all elements that are not null
		/// </summary>
		public static IEnumerable<T> NotNull<T>(this IEnumerable<T> source)
			=> source.Where(e => e is not null);
	}
}