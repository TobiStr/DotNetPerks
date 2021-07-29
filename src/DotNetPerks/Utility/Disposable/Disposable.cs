using System.Collections.Generic;

namespace System
{
	public class Disposable : IDisposable
	{
		private readonly List<Action> disposeActions =
			new List<Action>();

		public Disposable(Action disposeAction)
		{
			disposeActions.Add(
				disposeAction ?? throw new ArgumentNullException(nameof(disposeAction))
			);
		}

		public static IDisposable Create(Action dispose) =>
			new Disposable(dispose);

		public void Add(Action disposeAction) =>
			disposeActions.Add(disposeAction);

		public void Dispose()
		{
			foreach (var disposeAction in disposeActions)
				disposeAction();
		}
	}
}