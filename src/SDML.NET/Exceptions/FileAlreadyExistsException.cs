using System;

namespace SDML.NET
{
	public class FileAlreadyExistsException : Exception
	{
		private const string defaultMessage = "File is already exists!";

		public FileAlreadyExistsException() : base(defaultMessage) { }
		public FileAlreadyExistsException(string message) : base(message) { }
	}
}
