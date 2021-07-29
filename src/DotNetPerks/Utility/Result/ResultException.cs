using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	internal class ResultException : Exception
	{
		public ResultException()
		{
		}

		public ResultException(string message) : base(message)
		{
		}

		public ResultException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ResultException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}