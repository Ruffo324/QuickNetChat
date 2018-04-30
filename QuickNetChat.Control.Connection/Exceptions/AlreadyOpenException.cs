using System;

namespace QuickNetChat.Control.Connection.Exceptions
{
    public class AlreadyOpenException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        ///     Throws a new already open exception.
        ///     Used if an connection is already open.
        /// </summary>
        public AlreadyOpenException(string message) : base(message)
        {
        }
    }
}
