﻿using System.Net;
using NetCoreServer;

namespace Alibi.WebSocket
{
    internal class WebSocketProxy : WsServer
    {
        public WebSocketProxy(IPAddress address, int port) : base(address, port)
        {
        }

        protected override TcpSession CreateSession()
        {
            return new WebSocketSession(this);
        }
    }
}