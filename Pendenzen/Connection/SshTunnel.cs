using System;

namespace Pendenzen
{
    class SshTunnel //: IDisposable
    {/*
        private SshClient client;
        private ForwardedPortLocal port;
        private int localPort;

        public SshTunnel(ConnectionInfo connectionInfo, uint remotePort)
        {
            try
            {
                client = new SshClient(connectionInfo);

                // using 0 for the client port to dynamically allocate it
                port = new ForwardedPortLocal("127.0.0.3", 0, "127.0.0.3", remotePort);

                client.Connect();
                client.AddForwardedPort(port);
                Debug.WriteLine("Client: " + client.ConnectionInfo.Host);
                port.Start();

                // HACK to get the dynamically allocated client port

                var listener = (TcpListener)typeof(ForwardedPortLocal).GetField("_listener", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(port);
                Debug.WriteLine("Listener: " + listener);


                //var listener = (TcpListener)typeof(ForwardedPortLocal).GetField("_listener", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(port);
                localPort = ((System.Net.IPEndPoint)listener.LocalEndpoint).Port;
            }
            catch
            {
                Dispose();
               // throw;
            }
        }

        public int LocalPort { get { return localPort; } }

        public void Dispose()
        {
            if (port != null)
                port.Dispose();
            if (client != null)
                client.Dispose();
        }*/
    }
}
