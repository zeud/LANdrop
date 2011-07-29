﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LANdrop.Networking.PeerDiscovery
{
    /// <summary>
    /// Discovers peers using IPv6 multicasting.
    /// </summary>
    class MulticastPeerDiscoverer : IPeerDiscoverer
    {
        public event DiscoveryUtils.PeersDiscoveredHandler PeersDiscovered;

        private IPAddress multicastAddress = IPAddress.Parse( Protocol.MulticastGroupAddress );

        private bool connected;

        private Thread sendThread, listenThread;

        public MulticastPeerDiscoverer( )
        {
            connected = true;

            // Set up the thread to send our announcements out periodically.
            sendThread = new Thread( SendLoop );
            sendThread.Name = "MulticastPeerDiscoverer Broadcast";
            sendThread.IsBackground = true;
            sendThread.Priority = ThreadPriority.BelowNormal;            

            // Set up the thread to listen for new accouncements.
            listenThread = new Thread( ListenLoop );
            listenThread.Name = "MulticastPeerDiscoverer Listen";
            listenThread.IsBackground = true;
            listenThread.Priority = ThreadPriority.BelowNormal;                                   
        }

        public void Start( )
        {
            sendThread.Start( );
            listenThread.Start( );
        }

        public void Refresh()
        {
            sendThread.Interrupt( );
        }

        public void Stop( )
        {            
            connected = false;
            sendThread.Interrupt( ); // Will send a "goodbye" message to remove us from other peer lists immediately.
            listenThread.Abort( );
        }     

        /// <summary>
        /// Perpetually announces our information every second.
        /// </summary>
        protected void SendLoop( )
        {
            using ( Socket socket = new Socket( AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp ) )
            {
                InitializeOutgoingSocket( socket );
  
                while ( connected )
                {
                    SendAnnouncement( socket );

                    try
                    {
                        Thread.Sleep( 1000 );
                    }
                    catch ( ThreadInterruptedException ) { } // Occurs naturally when Refresh() is called.
                }

                // Send a goodbye message so we're removed immediately.
                SendAnnouncement( socket );
                socket.Close( );
            }
        }

        /// <summary>
        /// Perpetually listens for another LANdrop clients' announcements.
        /// </summary>
        protected void ListenLoop( )
        {
            using ( Socket listenSocket = new Socket( AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp ) )
            {
                InitializeIncomingSocket( listenSocket );

                while ( connected )
                {
                    byte[] packet = new byte[1024];
                    listenSocket.Receive( packet ); // Halt here until a packet is received.

                    ParseAnnouncement( packet );

                    // Update the UI.
                    // MainForm.Instance.UpdatePeerList( );
                }
            }
        }

        protected void InitializeOutgoingSocket( Socket socket )
        {
            int sendPort = Util.BindToFirstPossiblePort( socket, Protocol.MulticastPort + 50 );
            if ( sendPort == -1 )
            {
                // TODO: Smarter handling of this error.
                // TODO: Detect other instances of LANdrop at startup.
                MessageBox.Show( "Failed to bind the multicast sender.\nAnother instance of LANdrop might be running.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                Environment.Exit( -1 );
            }
            else
                Trace.WriteLine( "Multicast sender bound to port " + sendPort + "." );

            socket.SetSocketOption( SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption( multicastAddress ) );
            socket.SetSocketOption( SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 8 );
            socket.Connect( new IPEndPoint( multicastAddress, Protocol.MulticastPort ) );
        }

        protected void InitializeIncomingSocket( Socket listenSocket )
        {
            int listenPort = Util.BindToFirstPossiblePort( listenSocket, Protocol.MulticastPort ); // Must get this one to receive the multicast messages.
            if ( listenPort == -1 )
            {
                MessageBox.Show( "Failed to bind the multicast listener.\nAnother instance of LANdrop might be running.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                Environment.Exit( -1 );
            }
            else if ( listenPort != Protocol.MulticastPort )
                MessageBox.Show( "The multicast listener was unable to bind to port " + Protocol.MulticastPort + " (instead, it got " + listenPort + ")." +
                    "\n\nLANdrop will still work, but you won't probably won't see any clients to connect to.", "Startup Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            Trace.WriteLine( "Multicast listener bound to port " + listenPort + "." );
            listenSocket.SetSocketOption( SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption( multicastAddress, IPAddress.Any ) );

        }

        protected void SendAnnouncement( Socket socket )
        {
            using ( BinaryWriter message = new BinaryWriter( new MemoryStream( ) ) )
            {
                // Send our name, protocol versions and IP.
                message.Write( (Int32) Protocol.Version );
                message.Write( Configuration.CurrentSettings.Username );
                message.Write( Util.GetLocalAddress( ).ToString( ) );
                message.Write( connected );

                try
                {
                    socket.Send( ( (MemoryStream) message.BaseStream ).ToArray( ) );
                }
                catch ( SocketException ) { }
            }
        }

        protected void ParseAnnouncement( byte[] packet )
        {
            using ( BinaryReader message = new BinaryReader( new MemoryStream( packet ) ) )
            {
                // First read the protocol version. We can only peer with LANdrop clients of the same version.
                if ( message.ReadInt32( ) != Protocol.Version )
                    return;

                // Parse in the peer, and forward it to the PeerManager.
                var peer = new Peer
                {
                    Name = message.ReadString( ),
                    EndPoint = new IPEndPoint( IPAddress.Parse( message.ReadString( ) ), Protocol.DefaultServerPort ),
                    LastSeen = DateTime.Now,
                    LastLookedUp = DateTime.Now
                };

                if ( message.ReadBoolean( ) ) // Are they saying goodbye?
                    PeerManager.Add( peer );
                else
                    PeerManager.Remove( peer );
            }
        }
    }
}
