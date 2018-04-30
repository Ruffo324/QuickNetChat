using System;

namespace QuickNetChat.Control.Server.Exceptions
{
    public class AlreadyOpenException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        ///     Throws a new already open exception.
        ///     Used if an connection is already open.
        /// </summary>
        public AlreadyOpenException() => throw new AlreadyOpenException();
    }
}
