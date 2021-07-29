namespace System
{
	public static class ResultExtensions
	{
		/// <summary>
		/// Returns the Ok Payload of the result.
		/// </summary>
		public static T GetOk<T>(this Result<T> result) =>
			result.Payload ?? throw new NullReferenceException("Payload of Result is null.");

		/// <summary>
		/// Returns the error message of the result.
		/// </summary>
		public static string GetError(this Result result) =>
			result.Message;

		/// <summary>
		/// Throws an exception containing the result message, when Success is false.
		/// </summary>
		/// <param name="result"></param>
		public static void Test(this Result result)
		{
			if (!result.Success)
				throw new ResultException(result.Message);
		}
	}
}