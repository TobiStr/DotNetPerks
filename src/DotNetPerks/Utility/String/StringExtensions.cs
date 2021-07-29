namespace System
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmpty(this string input) =>
			string.IsNullOrEmpty(input);

		public static bool IsNullOrWhiteSpace(this string input) =>
			string.IsNullOrWhiteSpace(input);

		public static bool Equals(this string instance, string value) =>
			string.Equals(instance, value, StringComparison.OrdinalIgnoreCase);
	}
}