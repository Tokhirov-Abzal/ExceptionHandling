using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException() { }
        public InvalidUserException(string message) { }

        public InvalidUserException(string message, Exception innerException) { }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() { }
        public UserNotFoundException(string message) { }

        public UserNotFoundException(string message, Exception innerException) { }
    }

    public class TaskAlreadyExistsException : Exception
    {
        public TaskAlreadyExistsException() { }
        public TaskAlreadyExistsException(string message) { }

        public TaskAlreadyExistsException(string message, Exception innerException) { }

    }
}