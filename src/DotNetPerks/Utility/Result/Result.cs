namespace System
{
	/// <summary>
	/// Class for clean return values of functions.
	/// </summary>
	public class Result
	{
		public bool Success { get; }

		public string Message { get; }

		public Result(bool success, string message)
		{
			Success = success;
			Message = message;
		}

		public static Result Ok()
			=> new Result(true, "");

		public static Result Error(string message)
			=> new Result(false, message);

		public static implicit operator Result(string message) =>
			Error(message);
	}

	/// <summary>
	/// Class for clean return values of functions with a generic type argument.
	/// </summary>
	public class Result<T> : Result
	{
		public T? Payload { get; }

		public Result(bool success, string message, T? payload) : base(success, message)
		{
			Payload = payload;
		}

		public static Result<T> Ok<T>(T payload)
			=> new Result<T>(true, "", payload);

		public static Result<T> Error(string message)
			=> new Result<T>(false, message, default);

		public static implicit operator Result<T>(T payload) =>
			Ok(payload);

		public static implicit operator Result<T>(string message) =>
			Error(message);
	}
}