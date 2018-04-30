namespace QuickNetChat.Control.Connection
{
    /// <summary>
    ///     This is the local server for each programm instance.
    ///     The server boardcasting him self to the network.
    ///     This is necessary to auto detect other chat instances in the network.
    ///     <para>
    ///         <remarks>The LocalServer runs in Singletone pattern.</remarks>
    ///     </para>
    /// </summary>
    public class LocalServer
    {
        /// <summary>
        ///     Private constructor of the local server
        /// </summary>
        private LocalServer()
        {

        }

        
        /// <summary>
        ///     Starts the local server.
        /// </summary>
        /// <returns>True if start successfully. False otherwise.</returns>
        public bool Start()
        {
            return true;
        }

        /// <summary>
        ///     Singleton instance of the local server.
        /// </summary>
        private static LocalServer Instance { get; set; }

        /// <summary>
        ///     Returns the singleton instance of the local server.
        /// </summary>
        /// <returns>Înstance of the local server.</returns>
        public static LocalServer GetInstance()
        {
            return Instance ?? (Instance = new LocalServer());
        }
    }
}