using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq
{
	public static class TaskSequenceExtensions
	{
		/// <summary>
		/// Executes and awaits every task of the sequence in order.
		/// </summary>
		public static async Task<IEnumerable<T>> WhenAllSequentialAsync<T>(this IEnumerable<Task<T>> tasks)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			var results = new List<T>();
			foreach (var task in tasks)
				results.Add(await task.ConfigureAwait(false));
			return results;
		}

		/// <summary>
		/// Executes and awaits every task of the sequence in order.
		/// </summary>
		public static async Task WhenAllSequentialAsync(this IEnumerable<Task> tasks)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			foreach (var task in tasks)
				await task.ConfigureAwait(false);
		}

		/// <summary>
		/// Executes and awaits every task of the sequence with no respect to the order.
		/// </summary>
		public static async Task<IEnumerable<T>> WhenAllAsync<T>(this IEnumerable<Task<T>> tasks)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			return await Task
				.WhenAll(tasks)
				.ConfigureAwait(false);
		}

		/// <summary>
		/// Executes and awaits every task of the sequence with no respect to the order.
		/// </summary>
		public static async Task WhenAllAsync(this IEnumerable<Task> tasks)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			await Task
				.WhenAll(tasks)
				.ConfigureAwait(false);
		}

		/// <summary>
		/// Executes and awaits every task of the sequence with no respect to the order and explicitly parallelized.
		/// </summary>
		public static async Task WhenAllParallelAsync(
			this IEnumerable<Task> tasks,
			int maxParallelCount,
			CancellationToken cancellationToken = default
		)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			var options = new ParallelOptions()
			{
				MaxDegreeOfParallelism = maxParallelCount,
				CancellationToken = cancellationToken
			};

			Parallel.ForEach(tasks, options, async task => await task.ConfigureAwait(false));
		}

		/// <summary>
		/// Executes and awaits every task of the sequence with no respect to the order and explicitly parallelized.
		/// </summary>
		public static async Task<IEnumerable<T>> WhenAllParallelAsync<T>(
			this IEnumerable<Task<T>> tasks,
			int maxParallelCount,
			CancellationToken cancellationToken = default
		)
		{
			if (tasks is null)
				throw new ArgumentNullException(nameof(tasks));

			var options = new ParallelOptions()
			{
				MaxDegreeOfParallelism = maxParallelCount,
				CancellationToken = cancellationToken
			};

			var results = new List<T>();

			Parallel.ForEach(tasks, options, async task => results.Add(await task.ConfigureAwait(false)));

			return results;
		}

		/// <summary>
		/// Applies an asynchronous selector on each element of the sequence.
		/// </summary>
		public static IEnumerable<Task<TOut>> Select<TIn, TOut>(
			this IEnumerable<Task<TIn>> tasks,
			Func<TIn, TOut> selector
		)
		{
			return tasks.Select(t => t.SelectAsync(selector));
		}
	}
}