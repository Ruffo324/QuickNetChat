using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using QuickNetChat.DataRepository.Entitys;

namespace QuickNetChat.Server
{
    public class TcpHandler
    {
        public TcpClient Client;

        public TcpListener Server;

        public Thread ServerThread;

        public void StartServer()
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            Server = new TcpListener(localAddr, 5001);
            Server.Start();
            ServerThread = new Thread(AcceptClients);
            ServerThread.Start();
        }

        public void AcceptClients()
        {
            while (true)
            {
                TcpClient client = new TcpClient();
                client = Server.AcceptTcpClient(); // AcceptTcpClient();
                if (client.Connected)
                {
                    Thread clientThread = new Thread(AcceptClientsThread);
                    clientThread.Start(client);
                }
            }
        }

        public static void AcceptClientsThread(object aTcpClient)
        {
            var tcpClient = (TcpClient) aTcpClient;
            NetworkStream stream = tcpClient.GetStream();

            if (stream.CanRead)
            {
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                stream.Read(bytes, 0, tcpClient.ReceiveBufferSize);
                string returndata = Encoding.UTF8.GetString(bytes);
            }
        }

        public bool ConnectToIp(IPAddress aipAddress, int aPort)
        {
            Ping pingIpaddressPing = new Ping();
            int timeout = 500;
            PingReply reply = pingIpaddressPing.Send(aipAddress, timeout);
            if (reply != null && reply.Status == IPStatus.Success)
                try
                {
                    Client = new TcpClient();
                    Client.Connect(aipAddress, aPort);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                    return false;
                }

            return false;
        }

        // ALLES AB HIER IGNORIEREN
/*
        private readonly DataRepository.DataRepository _dataRepository;

        public TcpClient TcpClient = new TcpClient();

        public TcpHandler()
        {
            _dataRepository = new DataRepository.DataRepository();
            using (var context = _dataRepository.GetContext())
            {
                List<User> users = context.Users
                    .Where(usr => usr.IpAddress != null)
                    .Where((usr) => usr.Mail == "test@web.de")
                    .ToList();
                foreach (var user in users)
                {
                  //user.Name     
                }

                //test2((usr) => { return true; });





            }
        }
        */
        private bool Test(User Ausr)
        {
            return Ausr.Mail == "test@web.de";
        }

        /*
        private bool test2(Func<User, bool> usrFunc)
        {

        }*/
    }
}