namespace System.Threading.Tasks
{
	public static class TaskExtensions
	{
		/// <summary>
		/// Maps a Task to another Task using the async selector function.
		/// </summary>
		/// <typeparam name="TIn"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="task"></param>
		/// <param name="selector"></param>
		/// <returns></returns>
		public static async Task<TOut> SelectAsync<TIn, TOut>(
		   this Task<TIn> task,
		   Func<TIn, Task<TOut>> selector
		)
		{
			if (task is null)
				throw new ArgumentNullException(nameof(task));

			if (selector is null)
				throw new ArgumentNullException(nameof(selector));

			return await selector(await task);
		}

		/// <summary>
		/// Maps a Task to another Task using the selector function.
		/// </summary>
		/// <typeparam name="TIn"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="task"></param>
		/// <param name="selector"></param>
		/// <returns></returns>
		public static async Task<TOut> SelectAsync<TIn, TOut>(
			this Task<TIn> task,
			Func<TIn, TOut> selector
		)
		{
			if (task is null)
				throw new ArgumentNullException(nameof(task));

			if (selector is null)
				throw new ArgumentNullException(nameof(selector));

			return selector(await task);
		}

		/// <summary>
		/// Executes an async function on the Task.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="task"></param>
		/// <param name="action"></param>
		/// <returns></returns>
		public static async Task<T> DoAsync<T>(
			this Task<T> task,
			Func<T, Task> action
		)
		{
			if (task is null)
				throw new ArgumentNullException(nameof(task));

			if (action is null)
				throw new ArgumentNullException(nameof(action));

			var res = await task;
			await action(res);
			return res;
		}

		/// <summary>
		/// Executes an action on the Task.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="task"></param>
		/// <param name="action"></param>
		/// <returns></returns>
		public static async Task<T> DoAsync<T>(
			this Task<T> task,
			Action<T> action
		)
		{
			if (task is null)
				throw new ArgumentNullException(nameof(task));

			if (action is null)
				throw new ArgumentNullException(nameof(action));

			var res = await task;
			action(res);
			return res;
		}
	}
}