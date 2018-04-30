using System.Threading;

namespace QuickNetChat.Control.Server
{
    /// <summary>
    ///     The server handler takes care about the communication of the local server.
    /// </summary>
    public class ServerHandler
    {
        /// <summary>
        ///     Thread for the server.
        ///     <see cref="Server" />
        /// </summary>
        public Thread ServerThread;
    }
}