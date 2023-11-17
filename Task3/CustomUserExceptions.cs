using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException() { }
        public InvalidUserException(string message) : base(message) { }

        public InvalidUserException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() { }
        public UserNotFoundException(string message) : base(message) { }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class TaskAlreadyExistsException : Exception
    {
        public TaskAlreadyExistsException() { }
        public TaskAlreadyExistsException(string message) : base(message) { }

        public TaskAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }

    }
}